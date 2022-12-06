
namespace _291_Project
{
    partial class ReportingScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.employeeNav = new System.Windows.Forms.MenuStrip();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoLnk = new System.Windows.Forms.LinkLabel();
            this.mostActiveEmpTab = new System.Windows.Forms.TabControl();
            this.salesReportTab = new System.Windows.Forms.TabPage();
            this.genSalesReportButton = new System.Windows.Forms.Button();
            this.selectDateText = new System.Windows.Forms.Label();
            this.dateTimeSalesReport = new System.Windows.Forms.DateTimePicker();
            this.dataGridSalesReport = new System.Windows.Forms.DataGridView();
            this.currentOrderTab = new System.Windows.Forms.TabPage();
            this.dataGridCurOrders = new System.Windows.Forms.DataGridView();
            this.cusNameCurCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieTitleCurCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieAmountCurCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateCurCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allOrdersTab = new System.Windows.Forms.TabPage();
            this.dataGridAllOrders = new System.Windows.Forms.DataGridView();
            this.custNameAllCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOrdered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pickUpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dropOffDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highRatedMoviesTab = new System.Windows.Forms.TabPage();
            this.dataGridHighRating = new System.Windows.Forms.DataGridView();
            this.movieTitleHighCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieRatingCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timesRented = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersTab = new System.Windows.Forms.TabPage();
            this.dataGridCustList = new System.Windows.Forms.DataGridView();
            this.custID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameCusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerRatingCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailingListTab = new System.Windows.Forms.TabPage();
            this.dataGridMailList = new System.Windows.Forms.DataGridView();
            this.custNameMailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custAddressMailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridMostActiveEmp = new System.Windows.Forms.DataGridView();
            this.employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersHandled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserLBL = new System.Windows.Forms.Label();
            this.SignOutLnk = new System.Windows.Forms.LinkLabel();
            this.subTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revenueCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNav.SuspendLayout();
            this.mostActiveEmpTab.SuspendLayout();
            this.salesReportTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalesReport)).BeginInit();
            this.currentOrderTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCurOrders)).BeginInit();
            this.allOrdersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllOrders)).BeginInit();
            this.highRatedMoviesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHighRating)).BeginInit();
            this.customersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustList)).BeginInit();
            this.mailingListTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMailList)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMostActiveEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(323, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reports";
            // 
            // employeeNav
            // 
            this.employeeNav.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.employeeNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMenuItem,
            this.reportsMenuItem});
            this.employeeNav.Location = new System.Drawing.Point(0, 0);
            this.employeeNav.Name = "employeeNav";
            this.employeeNav.Size = new System.Drawing.Size(800, 24);
            this.employeeNav.TabIndex = 2;
            this.employeeNav.Text = "employeeNav";
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.actorsToolStripMenuItem,
            this.moviesToolStripMenuItem});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editMenuItem.Text = "Edit";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.employeesToolStripMenuItem.Text = "Employees";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // actorsToolStripMenuItem
            // 
            this.actorsToolStripMenuItem.Name = "actorsToolStripMenuItem";
            this.actorsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.actorsToolStripMenuItem.Text = "Actors";
            this.actorsToolStripMenuItem.Click += new System.EventHandler(this.actorsToolStripMenuItem_Click);
            // 
            // moviesToolStripMenuItem
            // 
            this.moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.moviesToolStripMenuItem.Text = "Movies";
            this.moviesToolStripMenuItem.Click += new System.EventHandler(this.moviesToolStripMenuItem_Click);
            // 
            // reportsMenuItem
            // 
            this.reportsMenuItem.Name = "reportsMenuItem";
            this.reportsMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsMenuItem.Text = "Reports";
            // 
            // LogoLnk
            // 
            this.LogoLnk.ActiveLinkColor = System.Drawing.Color.Gold;
            this.LogoLnk.AutoSize = true;
            this.LogoLnk.BackColor = System.Drawing.Color.Transparent;
            this.LogoLnk.DisabledLinkColor = System.Drawing.Color.Gold;
            this.LogoLnk.Font = new System.Drawing.Font("Showcard Gothic", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogoLnk.LinkColor = System.Drawing.Color.Gold;
            this.LogoLnk.Location = new System.Drawing.Point(12, 36);
            this.LogoLnk.Name = "LogoLnk";
            this.LogoLnk.Size = new System.Drawing.Size(134, 43);
            this.LogoLnk.TabIndex = 3;
            this.LogoLnk.TabStop = true;
            this.LogoLnk.Text = "TBMRS";
            this.LogoLnk.VisitedLinkColor = System.Drawing.Color.Gold;
            // 
            // mostActiveEmpTab
            // 
            this.mostActiveEmpTab.Controls.Add(this.salesReportTab);
            this.mostActiveEmpTab.Controls.Add(this.currentOrderTab);
            this.mostActiveEmpTab.Controls.Add(this.allOrdersTab);
            this.mostActiveEmpTab.Controls.Add(this.highRatedMoviesTab);
            this.mostActiveEmpTab.Controls.Add(this.customersTab);
            this.mostActiveEmpTab.Controls.Add(this.mailingListTab);
            this.mostActiveEmpTab.Controls.Add(this.tabPage1);
            this.mostActiveEmpTab.Location = new System.Drawing.Point(12, 192);
            this.mostActiveEmpTab.Name = "mostActiveEmpTab";
            this.mostActiveEmpTab.SelectedIndex = 0;
            this.mostActiveEmpTab.Size = new System.Drawing.Size(776, 246);
            this.mostActiveEmpTab.TabIndex = 4;
            // 
            // salesReportTab
            // 
            this.salesReportTab.BackColor = System.Drawing.Color.MidnightBlue;
            this.salesReportTab.Controls.Add(this.genSalesReportButton);
            this.salesReportTab.Controls.Add(this.selectDateText);
            this.salesReportTab.Controls.Add(this.dateTimeSalesReport);
            this.salesReportTab.Controls.Add(this.dataGridSalesReport);
            this.salesReportTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.salesReportTab.Location = new System.Drawing.Point(4, 24);
            this.salesReportTab.Name = "salesReportTab";
            this.salesReportTab.Padding = new System.Windows.Forms.Padding(3);
            this.salesReportTab.Size = new System.Drawing.Size(768, 218);
            this.salesReportTab.TabIndex = 0;
            this.salesReportTab.Text = "Sales Report";
            // 
            // genSalesReportButton
            // 
            this.genSalesReportButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.genSalesReportButton.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genSalesReportButton.ForeColor = System.Drawing.Color.Gold;
            this.genSalesReportButton.Location = new System.Drawing.Point(54, 118);
            this.genSalesReportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genSalesReportButton.Name = "genSalesReportButton";
            this.genSalesReportButton.Size = new System.Drawing.Size(193, 86);
            this.genSalesReportButton.TabIndex = 3;
            this.genSalesReportButton.Text = "Generate";
            this.genSalesReportButton.UseVisualStyleBackColor = false;
            this.genSalesReportButton.Click += new System.EventHandler(this.genSalesReportButton_Click);
            // 
            // selectDateText
            // 
            this.selectDateText.AutoSize = true;
            this.selectDateText.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectDateText.ForeColor = System.Drawing.Color.Gold;
            this.selectDateText.Location = new System.Drawing.Point(69, 37);
            this.selectDateText.Name = "selectDateText";
            this.selectDateText.Size = new System.Drawing.Size(158, 26);
            this.selectDateText.TabIndex = 2;
            this.selectDateText.Text = "Select Month";
            // 
            // dateTimeSalesReport
            // 
            this.dateTimeSalesReport.Location = new System.Drawing.Point(44, 76);
            this.dateTimeSalesReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeSalesReport.Name = "dateTimeSalesReport";
            this.dateTimeSalesReport.Size = new System.Drawing.Size(219, 23);
            this.dateTimeSalesReport.TabIndex = 1;
            // 
            // dataGridSalesReport
            // 
            this.dataGridSalesReport.AllowUserToAddRows = false;
            this.dataGridSalesReport.AllowUserToDeleteRows = false;
            this.dataGridSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSalesReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subTypeCol,
            this.revenueCol});
            this.dataGridSalesReport.Location = new System.Drawing.Point(320, -3);
            this.dataGridSalesReport.Name = "dataGridSalesReport";
            this.dataGridSalesReport.ReadOnly = true;
            this.dataGridSalesReport.RowHeadersWidth = 51;
            this.dataGridSalesReport.RowTemplate.Height = 25;
            this.dataGridSalesReport.Size = new System.Drawing.Size(453, 218);
            this.dataGridSalesReport.TabIndex = 0;
            // 
            // currentOrderTab
            // 
            this.currentOrderTab.BackColor = System.Drawing.Color.MidnightBlue;
            this.currentOrderTab.Controls.Add(this.dataGridCurOrders);
            this.currentOrderTab.Location = new System.Drawing.Point(4, 24);
            this.currentOrderTab.Name = "currentOrderTab";
            this.currentOrderTab.Padding = new System.Windows.Forms.Padding(3);
            this.currentOrderTab.Size = new System.Drawing.Size(768, 218);
            this.currentOrderTab.TabIndex = 1;
            this.currentOrderTab.Text = "Current Orders";
            // 
            // dataGridCurOrders
            // 
            this.dataGridCurOrders.AllowUserToAddRows = false;
            this.dataGridCurOrders.AllowUserToDeleteRows = false;
            this.dataGridCurOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCurOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cusNameCurCol,
            this.movieTitleCurCol,
            this.movieAmountCurCol,
            this.returnDateCurCol});
            this.dataGridCurOrders.Location = new System.Drawing.Point(0, 0);
            this.dataGridCurOrders.Name = "dataGridCurOrders";
            this.dataGridCurOrders.ReadOnly = true;
            this.dataGridCurOrders.RowHeadersWidth = 51;
            this.dataGridCurOrders.RowTemplate.Height = 25;
            this.dataGridCurOrders.Size = new System.Drawing.Size(772, 222);
            this.dataGridCurOrders.TabIndex = 0;
            // 
            // cusNameCurCol
            // 
            this.cusNameCurCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cusNameCurCol.HeaderText = "Customer";
            this.cusNameCurCol.MinimumWidth = 6;
            this.cusNameCurCol.Name = "cusNameCurCol";
            this.cusNameCurCol.ReadOnly = true;
            this.cusNameCurCol.Width = 84;
            // 
            // movieTitleCurCol
            // 
            this.movieTitleCurCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.movieTitleCurCol.HeaderText = "Title";
            this.movieTitleCurCol.MinimumWidth = 6;
            this.movieTitleCurCol.Name = "movieTitleCurCol";
            this.movieTitleCurCol.ReadOnly = true;
            this.movieTitleCurCol.Width = 54;
            // 
            // movieAmountCurCol
            // 
            this.movieAmountCurCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.movieAmountCurCol.HeaderText = "Amount";
            this.movieAmountCurCol.MinimumWidth = 6;
            this.movieAmountCurCol.Name = "movieAmountCurCol";
            this.movieAmountCurCol.ReadOnly = true;
            this.movieAmountCurCol.Width = 76;
            // 
            // returnDateCurCol
            // 
            this.returnDateCurCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.returnDateCurCol.HeaderText = "Return Date";
            this.returnDateCurCol.MinimumWidth = 6;
            this.returnDateCurCol.Name = "returnDateCurCol";
            this.returnDateCurCol.ReadOnly = true;
            this.returnDateCurCol.Width = 94;
            // 
            // allOrdersTab
            // 
            this.allOrdersTab.BackColor = System.Drawing.Color.MidnightBlue;
            this.allOrdersTab.Controls.Add(this.dataGridAllOrders);
            this.allOrdersTab.Location = new System.Drawing.Point(4, 24);
            this.allOrdersTab.Name = "allOrdersTab";
            this.allOrdersTab.Padding = new System.Windows.Forms.Padding(3);
            this.allOrdersTab.Size = new System.Drawing.Size(768, 218);
            this.allOrdersTab.TabIndex = 2;
            this.allOrdersTab.Text = "All Orders";
            // 
            // dataGridAllOrders
            // 
            this.dataGridAllOrders.AllowUserToAddRows = false;
            this.dataGridAllOrders.AllowUserToDeleteRows = false;
            this.dataGridAllOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAllOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custNameAllCol,
            this.dataGridViewTextBoxColumn1,
            this.Amount,
            this.dateOrdered,
            this.pickUpDate,
            this.dropOffDate});
            this.dataGridAllOrders.Location = new System.Drawing.Point(0, 0);
            this.dataGridAllOrders.Name = "dataGridAllOrders";
            this.dataGridAllOrders.ReadOnly = true;
            this.dataGridAllOrders.RowHeadersWidth = 51;
            this.dataGridAllOrders.RowTemplate.Height = 25;
            this.dataGridAllOrders.Size = new System.Drawing.Size(771, 222);
            this.dataGridAllOrders.TabIndex = 0;
            // 
            // custNameAllCol
            // 
            this.custNameAllCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.custNameAllCol.HeaderText = "Customer";
            this.custNameAllCol.MinimumWidth = 6;
            this.custNameAllCol.Name = "custNameAllCol";
            this.custNameAllCol.ReadOnly = true;
            this.custNameAllCol.Width = 84;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Title";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 54;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 76;
            // 
            // dateOrdered
            // 
            this.dateOrdered.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dateOrdered.HeaderText = "Date Ordered";
            this.dateOrdered.MinimumWidth = 6;
            this.dateOrdered.Name = "dateOrdered";
            this.dateOrdered.ReadOnly = true;
            this.dateOrdered.Width = 102;
            // 
            // pickUpDate
            // 
            this.pickUpDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pickUpDate.HeaderText = "Pick Up Date";
            this.pickUpDate.MinimumWidth = 6;
            this.pickUpDate.Name = "pickUpDate";
            this.pickUpDate.ReadOnly = true;
            this.pickUpDate.Width = 99;
            // 
            // dropOffDate
            // 
            this.dropOffDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dropOffDate.HeaderText = "Drop Off Date";
            this.dropOffDate.MinimumWidth = 6;
            this.dropOffDate.Name = "dropOffDate";
            this.dropOffDate.ReadOnly = true;
            this.dropOffDate.Width = 105;
            // 
            // highRatedMoviesTab
            // 
            this.highRatedMoviesTab.BackColor = System.Drawing.Color.MidnightBlue;
            this.highRatedMoviesTab.Controls.Add(this.dataGridHighRating);
            this.highRatedMoviesTab.Location = new System.Drawing.Point(4, 24);
            this.highRatedMoviesTab.Name = "highRatedMoviesTab";
            this.highRatedMoviesTab.Padding = new System.Windows.Forms.Padding(3);
            this.highRatedMoviesTab.Size = new System.Drawing.Size(768, 218);
            this.highRatedMoviesTab.TabIndex = 3;
            this.highRatedMoviesTab.Text = "Highly Rated Movies";
            // 
            // dataGridHighRating
            // 
            this.dataGridHighRating.AllowUserToAddRows = false;
            this.dataGridHighRating.AllowUserToDeleteRows = false;
            this.dataGridHighRating.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHighRating.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieTitleHighCol,
            this.genre,
            this.movieRatingCol,
            this.timesRented});
            this.dataGridHighRating.Location = new System.Drawing.Point(0, 0);
            this.dataGridHighRating.Name = "dataGridHighRating";
            this.dataGridHighRating.ReadOnly = true;
            this.dataGridHighRating.RowHeadersWidth = 51;
            this.dataGridHighRating.RowTemplate.Height = 25;
            this.dataGridHighRating.Size = new System.Drawing.Size(768, 218);
            this.dataGridHighRating.TabIndex = 0;
            // 
            // movieTitleHighCol
            // 
            this.movieTitleHighCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.movieTitleHighCol.HeaderText = "Title";
            this.movieTitleHighCol.MinimumWidth = 6;
            this.movieTitleHighCol.Name = "movieTitleHighCol";
            this.movieTitleHighCol.ReadOnly = true;
            this.movieTitleHighCol.Width = 54;
            // 
            // genre
            // 
            this.genre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.genre.HeaderText = "Genre";
            this.genre.MinimumWidth = 6;
            this.genre.Name = "genre";
            this.genre.ReadOnly = true;
            this.genre.Width = 63;
            // 
            // movieRatingCol
            // 
            this.movieRatingCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.movieRatingCol.HeaderText = "Rating";
            this.movieRatingCol.MinimumWidth = 6;
            this.movieRatingCol.Name = "movieRatingCol";
            this.movieRatingCol.ReadOnly = true;
            this.movieRatingCol.Width = 66;
            // 
            // timesRented
            // 
            this.timesRented.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.timesRented.HeaderText = "Times Rented";
            this.timesRented.MinimumWidth = 6;
            this.timesRented.Name = "timesRented";
            this.timesRented.ReadOnly = true;
            this.timesRented.Width = 103;
            // 
            // customersTab
            // 
            this.customersTab.BackColor = System.Drawing.Color.MidnightBlue;
            this.customersTab.Controls.Add(this.dataGridCustList);
            this.customersTab.Location = new System.Drawing.Point(4, 24);
            this.customersTab.Name = "customersTab";
            this.customersTab.Padding = new System.Windows.Forms.Padding(3);
            this.customersTab.Size = new System.Drawing.Size(768, 218);
            this.customersTab.TabIndex = 4;
            this.customersTab.Text = "Customers";
            // 
            // dataGridCustList
            // 
            this.dataGridCustList.AllowUserToAddRows = false;
            this.dataGridCustList.AllowUserToDeleteRows = false;
            this.dataGridCustList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custID,
            this.customerNameCusCol,
            this.accType,
            this.customerRatingCol});
            this.dataGridCustList.Location = new System.Drawing.Point(3, 0);
            this.dataGridCustList.Name = "dataGridCustList";
            this.dataGridCustList.ReadOnly = true;
            this.dataGridCustList.RowHeadersWidth = 51;
            this.dataGridCustList.RowTemplate.Height = 25;
            this.dataGridCustList.Size = new System.Drawing.Size(766, 218);
            this.dataGridCustList.TabIndex = 0;
            // 
            // custID
            // 
            this.custID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.custID.HeaderText = "ID";
            this.custID.MinimumWidth = 6;
            this.custID.Name = "custID";
            this.custID.ReadOnly = true;
            this.custID.Width = 43;
            // 
            // customerNameCusCol
            // 
            this.customerNameCusCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.customerNameCusCol.HeaderText = "Name";
            this.customerNameCusCol.MinimumWidth = 6;
            this.customerNameCusCol.Name = "customerNameCusCol";
            this.customerNameCusCol.ReadOnly = true;
            this.customerNameCusCol.Width = 64;
            // 
            // accType
            // 
            this.accType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.accType.HeaderText = "Account Type";
            this.accType.MinimumWidth = 6;
            this.accType.Name = "accType";
            this.accType.ReadOnly = true;
            this.accType.Width = 104;
            // 
            // customerRatingCol
            // 
            this.customerRatingCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.customerRatingCol.HeaderText = "Rating";
            this.customerRatingCol.MinimumWidth = 6;
            this.customerRatingCol.Name = "customerRatingCol";
            this.customerRatingCol.ReadOnly = true;
            this.customerRatingCol.Width = 66;
            // 
            // mailingListTab
            // 
            this.mailingListTab.BackColor = System.Drawing.Color.MidnightBlue;
            this.mailingListTab.Controls.Add(this.dataGridMailList);
            this.mailingListTab.Location = new System.Drawing.Point(4, 24);
            this.mailingListTab.Name = "mailingListTab";
            this.mailingListTab.Padding = new System.Windows.Forms.Padding(3);
            this.mailingListTab.Size = new System.Drawing.Size(768, 218);
            this.mailingListTab.TabIndex = 5;
            this.mailingListTab.Text = "Customer Mailing List";
            // 
            // dataGridMailList
            // 
            this.dataGridMailList.AllowUserToAddRows = false;
            this.dataGridMailList.AllowUserToDeleteRows = false;
            this.dataGridMailList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMailList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custNameMailCol,
            this.email,
            this.custAddressMailCol,
            this.movieTitle,
            this.dataGridViewTextBoxColumn2,
            this.OrderDate});
            this.dataGridMailList.Location = new System.Drawing.Point(0, 0);
            this.dataGridMailList.Name = "dataGridMailList";
            this.dataGridMailList.ReadOnly = true;
            this.dataGridMailList.RowHeadersWidth = 51;
            this.dataGridMailList.RowTemplate.Height = 25;
            this.dataGridMailList.Size = new System.Drawing.Size(769, 218);
            this.dataGridMailList.TabIndex = 0;
            // 
            // custNameMailCol
            // 
            this.custNameMailCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.custNameMailCol.HeaderText = "Name";
            this.custNameMailCol.MinimumWidth = 6;
            this.custNameMailCol.Name = "custNameMailCol";
            this.custNameMailCol.ReadOnly = true;
            this.custNameMailCol.Width = 64;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.email.HeaderText = "E-Mail";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 66;
            // 
            // custAddressMailCol
            // 
            this.custAddressMailCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.custAddressMailCol.HeaderText = "Address";
            this.custAddressMailCol.MinimumWidth = 6;
            this.custAddressMailCol.Name = "custAddressMailCol";
            this.custAddressMailCol.ReadOnly = true;
            this.custAddressMailCol.Width = 74;
            // 
            // movieTitle
            // 
            this.movieTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.movieTitle.HeaderText = "Movie";
            this.movieTitle.MinimumWidth = 6;
            this.movieTitle.Name = "movieTitle";
            this.movieTitle.ReadOnly = true;
            this.movieTitle.Width = 65;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Pick Up Date";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 99;
            // 
            // OrderDate
            // 
            this.OrderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OrderDate.HeaderText = "Order Date";
            this.OrderDate.MinimumWidth = 6;
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            this.OrderDate.Width = 89;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MidnightBlue;
            this.tabPage1.Controls.Add(this.dataGridMostActiveEmp);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(768, 218);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "Most Active Employee";
            // 
            // dataGridMostActiveEmp
            // 
            this.dataGridMostActiveEmp.AllowUserToAddRows = false;
            this.dataGridMostActiveEmp.AllowUserToDeleteRows = false;
            this.dataGridMostActiveEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMostActiveEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employee,
            this.ordersHandled});
            this.dataGridMostActiveEmp.Location = new System.Drawing.Point(0, 0);
            this.dataGridMostActiveEmp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridMostActiveEmp.Name = "dataGridMostActiveEmp";
            this.dataGridMostActiveEmp.ReadOnly = true;
            this.dataGridMostActiveEmp.RowHeadersWidth = 51;
            this.dataGridMostActiveEmp.RowTemplate.Height = 29;
            this.dataGridMostActiveEmp.Size = new System.Drawing.Size(769, 221);
            this.dataGridMostActiveEmp.TabIndex = 0;
            // 
            // employee
            // 
            this.employee.HeaderText = "Employee";
            this.employee.MinimumWidth = 6;
            this.employee.Name = "employee";
            this.employee.ReadOnly = true;
            this.employee.Width = 125;
            // 
            // ordersHandled
            // 
            this.ordersHandled.HeaderText = "Orders Handled";
            this.ordersHandled.MinimumWidth = 6;
            this.ordersHandled.Name = "ordersHandled";
            this.ordersHandled.ReadOnly = true;
            this.ordersHandled.Width = 125;
            // 
            // UserLBL
            // 
            this.UserLBL.AutoSize = true;
            this.UserLBL.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserLBL.ForeColor = System.Drawing.Color.Gold;
            this.UserLBL.Location = new System.Drawing.Point(152, 37);
            this.UserLBL.Name = "UserLBL";
            this.UserLBL.Size = new System.Drawing.Size(91, 17);
            this.UserLBL.TabIndex = 101;
            this.UserLBL.Text = "Hello User!";
            // 
            // SignOutLnk
            // 
            this.SignOutLnk.ActiveLinkColor = System.Drawing.Color.Gold;
            this.SignOutLnk.AutoSize = true;
            this.SignOutLnk.BackColor = System.Drawing.Color.Transparent;
            this.SignOutLnk.DisabledLinkColor = System.Drawing.Color.Gold;
            this.SignOutLnk.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignOutLnk.LinkColor = System.Drawing.Color.Gold;
            this.SignOutLnk.Location = new System.Drawing.Point(717, 36);
            this.SignOutLnk.Name = "SignOutLnk";
            this.SignOutLnk.Size = new System.Drawing.Size(72, 18);
            this.SignOutLnk.TabIndex = 102;
            this.SignOutLnk.TabStop = true;
            this.SignOutLnk.Text = "Sign Out";
            this.SignOutLnk.VisitedLinkColor = System.Drawing.Color.Gold;
            this.SignOutLnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignOutLnk_LinkClicked);
            // 
            // subTypeCol
            // 
            this.subTypeCol.HeaderText = "Subscription Type";
            this.subTypeCol.MinimumWidth = 6;
            this.subTypeCol.Name = "subTypeCol";
            this.subTypeCol.ReadOnly = true;
            this.subTypeCol.Width = 125;
            // 
            // revenueCol
            // 
            this.revenueCol.HeaderText = "Revenue";
            this.revenueCol.MinimumWidth = 6;
            this.revenueCol.Name = "revenueCol";
            this.revenueCol.ReadOnly = true;
            this.revenueCol.Width = 125;
            // 
            // ReportingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SignOutLnk);
            this.Controls.Add(this.UserLBL);
            this.Controls.Add(this.mostActiveEmpTab);
            this.Controls.Add(this.LogoLnk);
            this.Controls.Add(this.employeeNav);
            this.Controls.Add(this.label1);
            this.Name = "ReportingScreen";
            this.Text = "ReportingScreen";
            this.Load += new System.EventHandler(this.ReportingScreen_Load);
            this.employeeNav.ResumeLayout(false);
            this.employeeNav.PerformLayout();
            this.mostActiveEmpTab.ResumeLayout(false);
            this.salesReportTab.ResumeLayout(false);
            this.salesReportTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalesReport)).EndInit();
            this.currentOrderTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCurOrders)).EndInit();
            this.allOrdersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllOrders)).EndInit();
            this.highRatedMoviesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHighRating)).EndInit();
            this.customersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustList)).EndInit();
            this.mailingListTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMailList)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMostActiveEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip employeeNav;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsMenuItem;
        private System.Windows.Forms.LinkLabel LogoLnk;
        private System.Windows.Forms.TabControl mostActiveEmpTab;
        private System.Windows.Forms.TabPage salesReportTab;
        private System.Windows.Forms.DataGridView dataGridSalesReport;
        private System.Windows.Forms.TabPage currentOrderTab;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage allOrdersTab;
        private System.Windows.Forms.DataGridView dataGridAllOrders;
        private System.Windows.Forms.TabPage highRatedMoviesTab;
        private System.Windows.Forms.TabPage customersTab;
        private System.Windows.Forms.DataGridView dataGridHighRating;
        private System.Windows.Forms.DataGridView dataGridCustList;
        private System.Windows.Forms.TabPage mailingListTab;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem;
        private System.Windows.Forms.Button genSalesReportButton;
        private System.Windows.Forms.Label selectDateText;
        private System.Windows.Forms.DateTimePicker dateTimeSalesReport;
        private System.Windows.Forms.DataGridView dataGridCurOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn custNameAllCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOrdered;
        private System.Windows.Forms.DataGridViewTextBoxColumn pickUpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dropOffDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieTitleHighCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieRatingCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn timesRented;
        private System.Windows.Forms.DataGridViewTextBoxColumn custID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameCusCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn accType;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerRatingCol;
        private System.Windows.Forms.DataGridView dataGridMailList;
        private System.Windows.Forms.DataGridViewTextBoxColumn custNameMailCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn custAddressMailCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridMostActiveEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordersHandled;
        private System.Windows.Forms.Label UserLBL;
        private System.Windows.Forms.LinkLabel SignOutLnk;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusNameCurCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieTitleCurCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieAmountCurCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateCurCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn revenueCol;
    }
}