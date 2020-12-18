using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;
using CFR.App_Code;
using mshtml;
using System.Net;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.IO;
using System.Xml.XPath;
using HtmlAgilityPack;
using System.Web;
using System.Text.RegularExpressions;
using ClosedXML.Excel;

namespace CFR
{
    public partial class Form1 : MetroForm
    {
        private string conn = System.Configuration.ConfigurationManager.ConnectionStrings["conn_CFR"].ConnectionString;
        BackgroundWorker m_oWorker;

        public Form1()
        {
            InitializeComponent();
            metroLabel1.Text = "Welcome, " + System.DirectoryServices.AccountManagement.UserPrincipal.Current.GivenName;
            right.Visible = false;
            left.Visible = false;

            m_oWorker = new BackgroundWorker();
            // Create a background worker thread that ReportsProgress &
            // SupportsCancellation
            // Hook up the appropriate events.
            m_oWorker.DoWork += new DoWorkEventHandler(m_oWorker_DoWork);
            m_oWorker.ProgressChanged += new ProgressChangedEventHandler
                    (m_oWorker_ProgressChanged);
            m_oWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler
                    (m_oWorker_RunWorkerCompleted);
            m_oWorker.WorkerReportsProgress = true;
            m_oWorker.WorkerSupportsCancellation = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Company text box
            company.AutoCompleteMode = AutoCompleteMode.Suggest;
            company.AutoCompleteSource = AutoCompleteSource.CustomSource;     
            AutoCompleteStringCollection DataCompany = new AutoCompleteStringCollection();
            string sqlComp = "select distinct sc.Company from f500 f (nolock) left join Staging_Crawler SC (nolock) on f.CIK = sc.CIK order by 1 asc";
            library.getData(DataCompany, sqlComp);
            company.AutoCompleteCustomSource = DataCompany;
            //#################

            //CIK text box
            cik.AutoCompleteMode = AutoCompleteMode.Suggest;
            cik.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCik = new AutoCompleteStringCollection();
            string sqlCik = "select CIK FROM dbo.F500 (nolock)";
            library.getData(DataCik, sqlCik);
            cik.AutoCompleteCustomSource = DataCik;
            //#################

            //Form text box
            formType.AutoCompleteMode = AutoCompleteMode.Suggest;
            formType.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataForm = new AutoCompleteStringCollection();
            string sqlForm = "select distinct formtype from Staging_Crawler (nolock)";
            library.getData(DataForm, sqlForm);
            formType.AutoCompleteCustomSource = DataForm;
            //#################

            //Auditor text box
            auditor.AutoCompleteMode = AutoCompleteMode.Suggest;
            auditor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataAuditor = new AutoCompleteStringCollection();
            string sqlAudit = "select distinct AuditorClass from CFR_Company (nolock)";
            library.getData(DataAuditor, sqlAudit);
            auditor.AutoCompleteCustomSource = DataAuditor;
            //#################

            //Industry text box
            industry.AutoCompleteMode = AutoCompleteMode.Suggest;
            industry.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataIndustry = new AutoCompleteStringCollection();
            string sqlIndustry = "select distinct IndustryClass from CFR_Company (nolock)";
            library.getData(DataIndustry, sqlIndustry);
            industry.AutoCompleteCustomSource = DataIndustry;
            //#################

            //Industry text box
            sector.AutoCompleteMode = AutoCompleteMode.Suggest;
            sector.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataSector = new AutoCompleteStringCollection();
            string sqlSector = "select distinct Sector from F500 (nolock)";
            library.getData(DataSector, sqlSector);
            sector.AutoCompleteCustomSource = DataSector;
            //#################
        }

        private void search_Click(object sender, EventArgs e)
        {
            

            try {
               
                string Query = "select SC.CIK, SC.Company, SC.FormType, SC.fileDate, CC.IndustryClass, CC.AuditorClass, CC.fortune100, CC.fortune500, CC.sp500, F.Sector, SC.filepath from Staging_Crawler SC (nolock) left join CFR_Company CC (nolock) on(SC.CIK = CC.CIK) left join F500 F (nolock) on(SC.CIK = F.CIK)";

                if (string.IsNullOrEmpty(filedon.Text.ToString()) || string.IsNullOrWhiteSpace(filedon.Text.ToString())) {
                    filedon.Text = "0";
                }

                string query = library.dataTable(company.Text.ToString(), cik.Text.ToString(), int.Parse(filedon.Text), formType.Text.ToString(), auditor.Text.ToString(), industry.Text.ToString(), sector.Text.ToString(), keyword.Text.ToString(), snp.Checked, fortune.Checked, toDate.Checked, fromDate.Checked, toDate.Value.Month, fromDate.Value.Month, Query);

                string connetionString = null;
                SqlConnection connection;
                
                connetionString = "Trusted_Connection=Yes;Integrated Security=True;Initial Catalog=TestCFR; Data Source=GARCIEDE5";
                connection = new SqlConnection(connetionString);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                grid.ReadOnly = true;
                grid.DataSource = ds.Tables[0];
 
                List<object> paragraphs = new List<object>();

                DataTable dt = new DataTable("MyTable");
                dt.Columns.Add(new DataColumn("Company", typeof(string)));
                dt.Columns.Add(new DataColumn("FormType", typeof(string)));
                dt.Columns.Add(new DataColumn("fileDate", typeof(string)));
                dt.Columns.Add(new DataColumn("Paragraph", typeof(string)));
                dt.Columns.Add(new DataColumn("FilePath", typeof(string)));

                lblCount.Text = "(Total Files To Load - " + ds.Tables[0].Rows.Count + ")";
                object[] parameters = new object[] { ds, dt };
                m_oWorker.RunWorkerAsync(parameters);
            }
            
            catch (SqlException ex)
            {
                if (ex.Number == -2)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        
        private void Highlight(string path, string keyword, string company, string formtype, string filedate, string filepath, DataTable t)
        {
            
            HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
            htmlDoc.OptionFixNestedTags = true;
            htmlDoc.LoadHtml(path);
            
            keyword = keyword.ToLower();
            //DataTable dt = new DataTable("MyTable");
            DataRow dr = t.NewRow();
            foreach (HtmlNode node in htmlDoc.DocumentNode.SelectNodes("//text()"))
            {
                if (node.InnerText.ToLower().Contains(keyword)) {
                    //Console.WriteLine("text=" + node.InnerText);
                    dr = t.NewRow();
                    dr["Company"] = company;
                    dr["FormType"] = formtype;
                    dr["fileDate"] = filedate;
                    string encodedParagraph = node.InnerText;
                    string normalParagraph = WebUtility.HtmlDecode(encodedParagraph);
                    dr["Paragraph"] = normalParagraph;
                    dr["FilePath"] = filepath;
                    t.Rows.Add(dr);
                    //paras.Add(node.InnerText);
                }
            }
        }

        private void FindFirst(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            var doc = (IHTMLDocument2)webBrowser.Document.DomDocument;
            var sel = (IHTMLSelectionObject)doc.selection;
            sel.empty(); // get an empty selection, so we start from the beginning
            var rng = sel.createRange() as IHTMLTxtRange;
            if (rng != null && rng.findText(keyword.Text, 1000000000, 0))
            {
                rng.select();
                rng.scrollIntoView(false);
               // return true;
            }
            //return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyword.Text"></param>
        /// <returns></returns>
        public void FindNext()
        {

            var doc = (IHTMLDocument2)webBrowser.Document.DomDocument;
            var sel = (IHTMLSelectionObject)doc.selection;
            var rng = sel.createRange() as IHTMLTxtRange;
            if (rng != null)
            {
                rng.collapse(false); // collapse the current selection so we start from the end of the previous range
                if (rng.findText(keyword.Text, 1000000000, 0))
                {
                    rng.select();
                    rng.scrollIntoView(false);
                    //return true;
                }
                else
                    webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(FindFirst);
            }
            //return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyword.Text"></param>
        /// <returns></returns>
        public void FindPrevious()
        {
            var doc = (IHTMLDocument2)webBrowser.Document.DomDocument;
            var sel = (IHTMLSelectionObject)doc.selection;
            var rng = sel.createRange() as IHTMLTxtRange;
            if (rng != null)
            {

                rng.collapse(true); // it should be true,so it goes to start of the document
                var found = rng.findText(keyword.Text, -1, 0); // Range count value should give negative value
                if (!found)
                {
                    rng.moveEnd("textedit");
                    found = rng.findText(keyword.Text, -1, 0);
                }
                if (found)
                {
                    rng.select();
                    rng.scrollIntoView(false);
                    //return true;
                }
            }
            //return false;
        }

    

        private void left_Click(object sender, EventArgs e)
        {
            //webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(FindPrevious);
            FindPrevious();
        }

        private void right_Click(object sender, EventArgs e)
        {
            //webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(FindNext);
            FindNext();
        }

        private void keyword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(keyword.Text.ToString()) || !string.IsNullOrWhiteSpace(keyword.Text.ToString()))
            {
                right.Visible = true;
                left.Visible = true;
            }
            else
            {
                right.Visible = false;
                left.Visible = false;
            }
        }


        /// <summary>
        /// On completed do the appropriate task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void m_oWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // The background process is complete. We need to inspect
            // our response to see if an error occurred, a cancel was
            // requested or if we completed successfully. 

            if (e.Cancelled)
            {
                lblStatus.Text = "Task Cancelled.";
            }

            // Check to see if an error occurred in the background process.

            else if (e.Error != null)
            {
                lblStatus.Text = "Error while performing background operation.";
            }
            else
            {
                // Everything completed normally.
                lblStatus.Text = "Task Completed...";

                DataTable result = (DataTable)e.Result;
                grid2.ReadOnly = true;
                grid2.DataSource = result;
                grid2.Columns["FilePath"].Visible = false;
                grid2.Columns["fileDate"].Visible = false;

                grid2.Columns["Company"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                grid2.Columns["FormType"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                grid2.Columns["Paragraph"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }

            //Change the status of the buttons on the UI accordingly
            //btnStartAsyncOperation.Enabled = true;
            //btnCancel.Enabled = false;
        }

        /// <summary>
        /// Notification is performed here to the progress bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void m_oWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            // This function fires on the UI thread so it's safe to edit

            // the UI control directly, no funny business with Control.Invoke :)

            // Update the progressBar with the integer supplied to us from the

            // ReportProgress() function.  

            progressBar1.Value = e.ProgressPercentage;
            lblStatus.Text = "Loading......" + progressBar1.Value.ToString() + "%";
        }

        /// <summary>
        /// Time consuming operations go here </br>
        /// i.e. Database operations,Reporting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void m_oWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // The sender is the BackgroundWorker object we need it to
            // report progress and check for cancellation.
            //NOTE : Never play with the UI thread here...

            object[] parameters = e.Argument as object[];

            
            
            //Report 100% completion on operation completed
            

            DataSet ds = (DataSet)parameters[0];
            DataTable dt = (DataTable)parameters[1];
            int i = 0;

            int filesCount = ds.Tables[0].Rows.Count;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string filepath = row["FilePath"].ToString();
                string company = row["Company"].ToString();
                string formtype = row["FormType"].ToString();
                string filedate = row["fileDate"].ToString();


                WebRequest request = WebRequest.Create(filepath);
                WebResponse response = request.GetResponse();
                Stream data = response.GetResponseStream();
                string html = String.Empty;
                using (StreamReader sr = new StreamReader(data))
                {
                    html = sr.ReadToEnd();
                }
                Highlight(html, keyword.Text, company, formtype, filedate, filepath, dt);
                int percentage = (i + 1) * 100 / filesCount;
                m_oWorker.ReportProgress(percentage);
                i++;
            }

            m_oWorker.ReportProgress(100);
            e.Result = dt;

        }

        private void grid_SelectionChanged(object sender, EventArgs e)
        {
            if (grid.CurrentCell == null ||
                grid.CurrentCell.Value == null) return;

            if (grid.SelectedRows.Count > 0)
            {
                webBrowser.Navigate(new Uri(grid.SelectedCells[0].OwningRow.Cells[10].Value.ToString()));

            }
            if (!string.IsNullOrEmpty(keyword.Text.ToString()) || !string.IsNullOrWhiteSpace(keyword.Text.ToString()))
            {
                webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(FindFirst);
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            if (grid.RowCount == 0)
            {
                MessageBox.Show("No data to export. Please load data first");
            }
            else
            {
                //GuiCursor.WaitCursor(() => { ExportData(); });
                ExportData();
            }
        }

        private void ExportData()
        {
            // create xls if not exists
            DataTable table = (DataTable)(grid.DataSource);
          

            string filename = "Test.xlsx";
            string filepath = "C:\\Users\\bukhari\\Desktop\\SharedFolder\\" + filename;
            CreateAndSaveWorkbook(table, filepath);


        }
        private void CreateAndSaveWorkbook(DataTable table, string filepath)
        {
            try
            {
                var wb = new XLWorkbook();
                // Add a DataTable as a worksheet
                var ws = wb.Worksheets.Add(table);
                wb.SaveAs(filepath);
                MessageBox.Show("File Saved");
            }
            catch (IOException ioe)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                MessageBox.Show(ioe.Message + " Please close the file and try again");
            }
        }
    }
}
