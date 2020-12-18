using System.Windows.Forms;

namespace CFR
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.cfr_label = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.grid = new MetroFramework.Controls.MetroGrid();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.company = new MetroFramework.Controls.MetroTextBox();
            this.cik = new MetroFramework.Controls.MetroTextBox();
            this.filedon = new MetroFramework.Controls.MetroTextBox();
            this.formType = new MetroFramework.Controls.MetroTextBox();
            this.auditor = new MetroFramework.Controls.MetroTextBox();
            this.industry = new MetroFramework.Controls.MetroTextBox();
            this.sector = new MetroFramework.Controls.MetroTextBox();
            this.snp = new MetroFramework.Controls.MetroCheckBox();
            this.fortune = new MetroFramework.Controls.MetroCheckBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.left = new MetroFramework.Controls.MetroButton();
            this.right = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.keyword = new MetroFramework.Controls.MetroTextBox();
            this.fromDate = new MetroFramework.Controls.MetroDateTime();
            this.toDate = new MetroFramework.Controls.MetroDateTime();
            this.search = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.grid2 = new MetroFramework.Controls.MetroGrid();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.export = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(1113, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "UserName";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // cfr_label
            // 
            this.cfr_label.AutoSize = true;
            this.cfr_label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.cfr_label.Location = new System.Drawing.Point(683, 11);
            this.cfr_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cfr_label.Name = "cfr_label";
            this.cfr_label.Size = new System.Drawing.Size(174, 25);
            this.cfr_label.TabIndex = 2;
            this.cfr_label.Text = "SEC Edgar Database";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(13, 60);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1262, 626);
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.tableLayoutPanel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 6;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1254, 584);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Main";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1254, 584);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.grid, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.webBrowser, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 105);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 445F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1250, 445);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle8;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid.Location = new System.Drawing.Point(2, 2);
            this.grid.Margin = new System.Windows.Forms.Padding(2);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid.RowTemplate.Height = 33;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(621, 441);
            this.grid.TabIndex = 0;
            this.grid.SelectionChanged += new System.EventHandler(this.grid_SelectionChanged);
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(627, 2);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(2);
            this.webBrowser.MinimumSize = new System.Drawing.Size(13, 13);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(621, 441);
            this.webBrowser.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 16;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel2.Controls.Add(this.company, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cik, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.filedon, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.formType, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.auditor, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.industry, 10, 0);
            this.tableLayoutPanel2.Controls.Add(this.sector, 12, 0);
            this.tableLayoutPanel2.Controls.Add(this.snp, 14, 0);
            this.tableLayoutPanel2.Controls.Add(this.fortune, 15, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 37);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1250, 25);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // company
            // 
            // 
            // 
            // 
            this.company.CustomButton.Image = null;
            this.company.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.company.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.company.CustomButton.Name = "";
            this.company.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.company.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.company.CustomButton.TabIndex = 1;
            this.company.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.company.CustomButton.UseSelectable = true;
            this.company.CustomButton.Visible = false;
            this.company.Dock = System.Windows.Forms.DockStyle.Fill;
            this.company.Lines = new string[0];
            this.company.Location = new System.Drawing.Point(2, 2);
            this.company.Margin = new System.Windows.Forms.Padding(2);
            this.company.MaxLength = 32767;
            this.company.Name = "company";
            this.company.PasswordChar = '\0';
            this.company.PromptText = "Company";
            this.company.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.company.SelectedText = "";
            this.company.SelectionLength = 0;
            this.company.SelectionStart = 0;
            this.company.ShortcutsEnabled = true;
            this.company.Size = new System.Drawing.Size(133, 21);
            this.company.TabIndex = 0;
            this.company.UseSelectable = true;
            this.company.WaterMark = "Company";
            this.company.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.company.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cik
            // 
            // 
            // 
            // 
            this.cik.CustomButton.Image = null;
            this.cik.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.cik.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.cik.CustomButton.Name = "";
            this.cik.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.cik.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cik.CustomButton.TabIndex = 1;
            this.cik.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cik.CustomButton.UseSelectable = true;
            this.cik.CustomButton.Visible = false;
            this.cik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cik.Lines = new string[0];
            this.cik.Location = new System.Drawing.Point(151, 2);
            this.cik.Margin = new System.Windows.Forms.Padding(2);
            this.cik.MaxLength = 32767;
            this.cik.Name = "cik";
            this.cik.PasswordChar = '\0';
            this.cik.PromptText = "CIK";
            this.cik.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cik.SelectedText = "";
            this.cik.SelectionLength = 0;
            this.cik.SelectionStart = 0;
            this.cik.ShortcutsEnabled = true;
            this.cik.Size = new System.Drawing.Size(133, 21);
            this.cik.TabIndex = 1;
            this.cik.UseSelectable = true;
            this.cik.WaterMark = "CIK";
            this.cik.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cik.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // filedon
            // 
            // 
            // 
            // 
            this.filedon.CustomButton.Image = null;
            this.filedon.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.filedon.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.filedon.CustomButton.Name = "";
            this.filedon.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.filedon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.filedon.CustomButton.TabIndex = 1;
            this.filedon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.filedon.CustomButton.UseSelectable = true;
            this.filedon.CustomButton.Visible = false;
            this.filedon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filedon.Lines = new string[0];
            this.filedon.Location = new System.Drawing.Point(300, 2);
            this.filedon.Margin = new System.Windows.Forms.Padding(2);
            this.filedon.MaxLength = 32767;
            this.filedon.Name = "filedon";
            this.filedon.PasswordChar = '\0';
            this.filedon.PromptText = "File Year";
            this.filedon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.filedon.SelectedText = "";
            this.filedon.SelectionLength = 0;
            this.filedon.SelectionStart = 0;
            this.filedon.ShortcutsEnabled = true;
            this.filedon.Size = new System.Drawing.Size(133, 21);
            this.filedon.TabIndex = 2;
            this.filedon.UseSelectable = true;
            this.filedon.WaterMark = "File Year";
            this.filedon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.filedon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // formType
            // 
            // 
            // 
            // 
            this.formType.CustomButton.Image = null;
            this.formType.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.formType.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.formType.CustomButton.Name = "";
            this.formType.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.formType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.formType.CustomButton.TabIndex = 1;
            this.formType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.formType.CustomButton.UseSelectable = true;
            this.formType.CustomButton.Visible = false;
            this.formType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formType.Lines = new string[0];
            this.formType.Location = new System.Drawing.Point(449, 2);
            this.formType.Margin = new System.Windows.Forms.Padding(2);
            this.formType.MaxLength = 32767;
            this.formType.Name = "formType";
            this.formType.PasswordChar = '\0';
            this.formType.PromptText = "Form Type";
            this.formType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.formType.SelectedText = "";
            this.formType.SelectionLength = 0;
            this.formType.SelectionStart = 0;
            this.formType.ShortcutsEnabled = true;
            this.formType.Size = new System.Drawing.Size(133, 21);
            this.formType.TabIndex = 3;
            this.formType.UseSelectable = true;
            this.formType.WaterMark = "Form Type";
            this.formType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.formType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // auditor
            // 
            // 
            // 
            // 
            this.auditor.CustomButton.Image = null;
            this.auditor.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.auditor.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.auditor.CustomButton.Name = "";
            this.auditor.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.auditor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.auditor.CustomButton.TabIndex = 1;
            this.auditor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.auditor.CustomButton.UseSelectable = true;
            this.auditor.CustomButton.Visible = false;
            this.auditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.auditor.Lines = new string[0];
            this.auditor.Location = new System.Drawing.Point(598, 2);
            this.auditor.Margin = new System.Windows.Forms.Padding(2);
            this.auditor.MaxLength = 32767;
            this.auditor.Name = "auditor";
            this.auditor.PasswordChar = '\0';
            this.auditor.PromptText = "Auditor";
            this.auditor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.auditor.SelectedText = "";
            this.auditor.SelectionLength = 0;
            this.auditor.SelectionStart = 0;
            this.auditor.ShortcutsEnabled = true;
            this.auditor.Size = new System.Drawing.Size(133, 21);
            this.auditor.TabIndex = 4;
            this.auditor.UseSelectable = true;
            this.auditor.WaterMark = "Auditor";
            this.auditor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.auditor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // industry
            // 
            // 
            // 
            // 
            this.industry.CustomButton.Image = null;
            this.industry.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.industry.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.industry.CustomButton.Name = "";
            this.industry.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.industry.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.industry.CustomButton.TabIndex = 1;
            this.industry.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.industry.CustomButton.UseSelectable = true;
            this.industry.CustomButton.Visible = false;
            this.industry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.industry.Lines = new string[0];
            this.industry.Location = new System.Drawing.Point(747, 2);
            this.industry.Margin = new System.Windows.Forms.Padding(2);
            this.industry.MaxLength = 32767;
            this.industry.Name = "industry";
            this.industry.PasswordChar = '\0';
            this.industry.PromptText = "Industry";
            this.industry.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.industry.SelectedText = "";
            this.industry.SelectionLength = 0;
            this.industry.SelectionStart = 0;
            this.industry.ShortcutsEnabled = true;
            this.industry.Size = new System.Drawing.Size(133, 21);
            this.industry.TabIndex = 5;
            this.industry.UseSelectable = true;
            this.industry.WaterMark = "Industry";
            this.industry.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.industry.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // sector
            // 
            // 
            // 
            // 
            this.sector.CustomButton.Image = null;
            this.sector.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.sector.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.sector.CustomButton.Name = "";
            this.sector.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.sector.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.sector.CustomButton.TabIndex = 1;
            this.sector.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.sector.CustomButton.UseSelectable = true;
            this.sector.CustomButton.Visible = false;
            this.sector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sector.Lines = new string[0];
            this.sector.Location = new System.Drawing.Point(896, 2);
            this.sector.Margin = new System.Windows.Forms.Padding(2);
            this.sector.MaxLength = 32767;
            this.sector.Name = "sector";
            this.sector.PasswordChar = '\0';
            this.sector.PromptText = "Sector";
            this.sector.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sector.SelectedText = "";
            this.sector.SelectionLength = 0;
            this.sector.SelectionStart = 0;
            this.sector.ShortcutsEnabled = true;
            this.sector.Size = new System.Drawing.Size(133, 21);
            this.sector.TabIndex = 6;
            this.sector.UseSelectable = true;
            this.sector.WaterMark = "Sector";
            this.sector.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sector.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // snp
            // 
            this.snp.AutoSize = true;
            this.snp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.snp.Location = new System.Drawing.Point(1045, 2);
            this.snp.Margin = new System.Windows.Forms.Padding(2);
            this.snp.Name = "snp";
            this.snp.Size = new System.Drawing.Size(96, 21);
            this.snp.TabIndex = 7;
            this.snp.Text = "SNP 500";
            this.snp.UseSelectable = true;
            // 
            // fortune
            // 
            this.fortune.AutoSize = true;
            this.fortune.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fortune.Location = new System.Drawing.Point(1145, 2);
            this.fortune.Margin = new System.Windows.Forms.Padding(2);
            this.fortune.Name = "fortune";
            this.fortune.Size = new System.Drawing.Size(103, 21);
            this.fortune.TabIndex = 8;
            this.fortune.Text = "Fortune 100";
            this.fortune.UseSelectable = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(2, 554);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1250, 28);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 5;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.040404F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.010101F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.040404F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel6.Controls.Add(this.left, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.right, 3, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(627, 2);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(621, 24);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // left
            // 
            this.left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.left.Location = new System.Drawing.Point(284, 2);
            this.left.Margin = new System.Windows.Forms.Padding(2);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(21, 20);
            this.left.TabIndex = 0;
            this.left.Text = "<";
            this.left.UseSelectable = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // right
            // 
            this.right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.right.Location = new System.Drawing.Point(315, 2);
            this.right.Margin = new System.Windows.Forms.Padding(2);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(21, 20);
            this.right.TabIndex = 1;
            this.right.Text = ">";
            this.right.UseSelectable = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel7.Controls.Add(this.export, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(621, 24);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.45827F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9992867F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.97604F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9992867F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.97604F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.292465F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.298619F));
            this.tableLayoutPanel3.Controls.Add(this.keyword, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.fromDate, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.toDate, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.search, 6, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 71);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1250, 25);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // keyword
            // 
            // 
            // 
            // 
            this.keyword.CustomButton.Image = null;
            this.keyword.CustomButton.Location = new System.Drawing.Point(706, 1);
            this.keyword.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.keyword.CustomButton.Name = "";
            this.keyword.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.keyword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.keyword.CustomButton.TabIndex = 1;
            this.keyword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.keyword.CustomButton.UseSelectable = true;
            this.keyword.CustomButton.Visible = false;
            this.keyword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyword.Lines = new string[0];
            this.keyword.Location = new System.Drawing.Point(2, 2);
            this.keyword.Margin = new System.Windows.Forms.Padding(2);
            this.keyword.MaxLength = 32767;
            this.keyword.Name = "keyword";
            this.keyword.PasswordChar = '\0';
            this.keyword.PromptText = "Keyword Search";
            this.keyword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.keyword.SelectedText = "";
            this.keyword.SelectionLength = 0;
            this.keyword.SelectionStart = 0;
            this.keyword.ShortcutsEnabled = true;
            this.keyword.Size = new System.Drawing.Size(726, 21);
            this.keyword.TabIndex = 9;
            this.keyword.UseSelectable = true;
            this.keyword.WaterMark = "Keyword Search";
            this.keyword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.keyword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.keyword.TextChanged += new System.EventHandler(this.keyword_TextChanged);
            // 
            // fromDate
            // 
            this.fromDate.CustomFormat = "MMMM";
            this.fromDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDate.Location = new System.Drawing.Point(744, 2);
            this.fromDate.Margin = new System.Windows.Forms.Padding(2);
            this.fromDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.fromDate.Name = "fromDate";
            this.fromDate.ShowCheckBox = true;
            this.fromDate.Size = new System.Drawing.Size(133, 30);
            this.fromDate.TabIndex = 10;
            // 
            // toDate
            // 
            this.toDate.CustomFormat = "MMMM";
            this.toDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDate.Location = new System.Drawing.Point(893, 2);
            this.toDate.Margin = new System.Windows.Forms.Padding(2);
            this.toDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.toDate.Name = "toDate";
            this.toDate.ShowCheckBox = true;
            this.toDate.Size = new System.Drawing.Size(133, 30);
            this.toDate.TabIndex = 11;
            // 
            // search
            // 
            this.search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search.Location = new System.Drawing.Point(1146, 2);
            this.search.Margin = new System.Windows.Forms.Padding(2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(102, 21);
            this.search.TabIndex = 12;
            this.search.Text = "Search";
            this.search.UseSelectable = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.tableLayoutPanel8);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 6;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1254, 584);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Paragraph";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 7;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.grid2, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.flowLayoutPanel1, 0, 3);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 4;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(1254, 584);
            this.tableLayoutPanel8.TabIndex = 2;
            // 
            // grid2
            // 
            this.grid2.AllowUserToAddRows = false;
            this.grid2.AllowUserToDeleteRows = false;
            this.grid2.AllowUserToResizeRows = false;
            this.grid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid2.DefaultCellStyle = dataGridViewCellStyle11;
            this.grid2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid2.EnableHeadersVisualStyles = false;
            this.grid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid2.Location = new System.Drawing.Point(2, 12);
            this.grid2.Margin = new System.Windows.Forms.Padding(2);
            this.grid2.Name = "grid2";
            this.grid2.ReadOnly = true;
            this.grid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.grid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid2.RowTemplate.Height = 33;
            this.grid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid2.Size = new System.Drawing.Size(623, 508);
            this.grid2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.progressBar1);
            this.flowLayoutPanel1.Controls.Add(this.lblStatus);
            this.flowLayoutPanel1.Controls.Add(this.lblCount);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 535);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(621, 46);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(157, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(166, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 17);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "label1";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(218, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(46, 17);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "label1";
            // 
            // export
            // 
            this.export.Dock = System.Windows.Forms.DockStyle.Fill;
            this.export.Location = new System.Drawing.Point(2, 2);
            this.export.Margin = new System.Windows.Forms.Padding(2);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(617, 20);
            this.export.TabIndex = 13;
            this.export.Text = "Export";
            this.export.UseSelectable = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackImage = global::CFR.Properties.Resources.hp__1920x1200__wallpaper_1661082315;
            this.ClientSize = new System.Drawing.Size(1288, 699);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.cfr_label);
            this.Controls.Add(this.metroLabel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Padding = new System.Windows.Forms.Padding(13, 60, 13, 13);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.TransparencyKey = System.Drawing.Color.LightSkyBlue;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel cfr_label;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel4;
        private MetroFramework.Controls.MetroGrid grid;
        private WebBrowser webBrowser;
        private TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroTextBox company;
        private MetroFramework.Controls.MetroTextBox cik;
        private MetroFramework.Controls.MetroTextBox filedon;
        private MetroFramework.Controls.MetroTextBox formType;
        private MetroFramework.Controls.MetroTextBox auditor;
        private MetroFramework.Controls.MetroTextBox industry;
        private MetroFramework.Controls.MetroTextBox sector;
        private MetroFramework.Controls.MetroCheckBox snp;
        private MetroFramework.Controls.MetroCheckBox fortune;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private MetroFramework.Controls.MetroButton left;
        private MetroFramework.Controls.MetroButton right;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel3;
        private MetroFramework.Controls.MetroTextBox keyword;
        private MetroFramework.Controls.MetroDateTime fromDate;
        private MetroFramework.Controls.MetroDateTime toDate;
        private MetroFramework.Controls.MetroButton search;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private TableLayoutPanel tableLayoutPanel8;
        private MetroFramework.Controls.MetroGrid grid2;
        private FlowLayoutPanel flowLayoutPanel1;
        private ProgressBar progressBar1;
        private Label lblStatus;
        private Label lblCount;
        private MetroFramework.Controls.MetroButton export;
    }
}

