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
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using System.Reflection;

namespace CFR.App_Code
{
    public static class library
    {
        public static void getData(AutoCompleteStringCollection dataCollection, string sql)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            connetionString = "Trusted_Connection=Yes;Integrated Security=True;Initial Catalog=TestCFR; Data Source=GARCIEDE5";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    dataCollection.Add(row[0].ToString());
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.ToString());
            }
        }

        public static string dataTable(string company, string CIK, int filedon, string formType, string auditor, string industry, string sector, string fileText, bool snp5, bool fortune1, bool todate, bool fromdate, int toDate, int fromDate, string query)
        {
            
            
            string Conditions = "";

            if (!string.IsNullOrEmpty(company) || !string.IsNullOrWhiteSpace(company)) Conditions += "AND SC.Company like ('%"+company+"%') ";
            if (!string.IsNullOrEmpty(CIK) || !string.IsNullOrWhiteSpace(CIK)) Conditions += "AND SC.CIK='"+CIK+"' ";
            //if (!string.IsNullOrEmpty(filedon) || !string.IsNullOrWhiteSpace(filedon)) Conditions += "AND year(SC.fileDate) = "+filedon;
            if (filedon != 0) Conditions += "AND year(SC.fileDate) = " + filedon+" ";
            if (!string.IsNullOrEmpty(formType) || !string.IsNullOrWhiteSpace(formType)) Conditions += "AND SC.FormType='"+formType+"' ";
            if (!string.IsNullOrEmpty(auditor) || !string.IsNullOrWhiteSpace(auditor)) Conditions += "AND CC.AuditorClass='"+auditor+"' ";
            if (!string.IsNullOrEmpty(industry) || !string.IsNullOrWhiteSpace(industry)) Conditions += "AND CC.IndustryClass='" + industry + "' ";
            if (!string.IsNullOrEmpty(sector) || !string.IsNullOrWhiteSpace(sector)) Conditions += "AND F.Sector='" + sector + "' ";
            if (!string.IsNullOrEmpty(fileText) || !string.IsNullOrWhiteSpace(fileText)) Conditions += "AND CONTAINS(SC.FileText, '"+ string.Format("\"{0}\"", fileText) +"')";
            if (snp5 == true) Conditions += "AND CC.sp500 is not null ";
            if (fortune1 == true) Conditions += "AND CC.fortune100 = 1 ";
            if ((todate == true) && (fromdate == true)) Conditions += "AND month(SC.filedate) between "+ fromDate+" and "+ toDate;

            if (Conditions.Length > 0)
                query += " WHERE " + Conditions.Substring(3);
            return query;
            
        }

       

    }
}
