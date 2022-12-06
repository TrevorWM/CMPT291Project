
namespace _291_Project
{
    partial class RentalScreen
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
            this.LogoLnk = new System.Windows.Forms.LinkLabel();
            this.SignOutLnk = new System.Windows.Forms.LinkLabel();
            this.AvailMovies = new System.Windows.Forms.Label();
            this.AccountLnk = new System.Windows.Forms.LinkLabel();
            this.AvailMovDGV = new System.Windows.Forms.DataGridView();
            this.movieTitleRentCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieGenreRentCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieCopiesNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieRentalFeeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieRatingCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorSearchLabel = new System.Windows.Forms.Label();
            this.SearchCB = new System.Windows.Forms.ComboBox();
            this.rentedMoviesLabel = new System.Windows.Forms.Label();
            this.CurrentlyRentedDGV = new System.Windows.Forms.DataGridView();
            this.movieTitleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PickupCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DropoffCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.MovTitleTB = new System.Windows.Forms.TextBox();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.RandRBTN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.RentBTN = new System.Windows.Forms.Button();
            this.CRM = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.QueueDGV = new System.Windows.Forms.DataGridView();
            this.MtitleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentfeeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PickupDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderHistoryTab = new System.Windows.Forms.TabPage();
            this.dataGridOrderHistory = new System.Windows.Forms.DataGridView();
            this.orderNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dropOffDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pickUpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.RecommendationDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovTitleRentTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchTB = new System.Windows.Forms.TextBox();
            this.RatingCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PickupDTP = new System.Windows.Forms.DateTimePicker();
            this.CSTitleLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AvailMovDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentlyRentedDGV)).BeginInit();
            this.CRM.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QueueDGV)).BeginInit();
            this.orderHistoryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderHistory)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecommendationDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoLnk
            // 
            this.LogoLnk.ActiveLinkColor = System.Drawing.Color.Gold;
            this.LogoLnk.AutoSize = true;
            this.LogoLnk.BackColor = System.Drawing.Color.Transparent;
            this.LogoLnk.DisabledLinkColor = System.Drawing.Color.Gold;
            this.LogoLnk.Font = new System.Drawing.Font("Showcard Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogoLnk.LinkColor = System.Drawing.Color.Gold;
            this.LogoLnk.Location = new System.Drawing.Point(12, 9);
            this.LogoLnk.Name = "LogoLnk";
            this.LogoLnk.Size = new System.Drawing.Size(134, 43);
            this.LogoLnk.TabIndex = 0;
            this.LogoLnk.TabStop = true;
            this.LogoLnk.Text = "TBMRS";
            this.LogoLnk.VisitedLinkColor = System.Drawing.Color.Gold;
            // 
            // SignOutLnk
            // 
            this.SignOutLnk.ActiveLinkColor = System.Drawing.Color.Gold;
            this.SignOutLnk.AutoSize = true;
            this.SignOutLnk.BackColor = System.Drawing.Color.Transparent;
            this.SignOutLnk.DisabledLinkColor = System.Drawing.Color.Gold;
            this.SignOutLnk.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignOutLnk.LinkColor = System.Drawing.Color.Gold;
            this.SignOutLnk.Location = new System.Drawing.Point(839, 9);
            this.SignOutLnk.Name = "SignOutLnk";
            this.SignOutLnk.Size = new System.Drawing.Size(72, 18);
            this.SignOutLnk.TabIndex = 6;
            this.SignOutLnk.TabStop = true;
            this.SignOutLnk.Text = "Sign Out";
            this.SignOutLnk.VisitedLinkColor = System.Drawing.Color.Gold;
            this.SignOutLnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignOutLnk_LinkClicked);
            // 
            // AvailMovies
            // 
            this.AvailMovies.AutoSize = true;
            this.AvailMovies.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AvailMovies.ForeColor = System.Drawing.Color.Gold;
            this.AvailMovies.Location = new System.Drawing.Point(12, 84);
            this.AvailMovies.Name = "AvailMovies";
            this.AvailMovies.Size = new System.Drawing.Size(191, 26);
            this.AvailMovies.TabIndex = 8;
            this.AvailMovies.Text = "Available Movies";
            // 
            // AccountLnk
            // 
            this.AccountLnk.ActiveLinkColor = System.Drawing.Color.Gold;
            this.AccountLnk.AutoSize = true;
            this.AccountLnk.BackColor = System.Drawing.Color.Transparent;
            this.AccountLnk.DisabledLinkColor = System.Drawing.Color.Gold;
            this.AccountLnk.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountLnk.LinkColor = System.Drawing.Color.Gold;
            this.AccountLnk.Location = new System.Drawing.Point(152, 9);
            this.AccountLnk.Name = "AccountLnk";
            this.AccountLnk.Size = new System.Drawing.Size(71, 18);
            this.AccountLnk.TabIndex = 10;
            this.AccountLnk.TabStop = true;
            this.AccountLnk.Text = "Account";
            this.AccountLnk.VisitedLinkColor = System.Drawing.Color.Gold;
            this.AccountLnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AccountLnk_LinkClicked);
            // 
            // AvailMovDGV
            // 
            this.AvailMovDGV.AllowUserToAddRows = false;
            this.AvailMovDGV.AllowUserToDeleteRows = false;
            this.AvailMovDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvailMovDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieTitleRentCol,
            this.movieGenreRentCol,
            this.movieCopiesNumCol,
            this.movieRentalFeeCol,
            this.movieRatingCol});
            this.AvailMovDGV.Location = new System.Drawing.Point(12, 113);
            this.AvailMovDGV.Name = "AvailMovDGV";
            this.AvailMovDGV.ReadOnly = true;
            this.AvailMovDGV.RowHeadersWidth = 51;
            this.AvailMovDGV.RowTemplate.Height = 25;
            this.AvailMovDGV.Size = new System.Drawing.Size(544, 423);
            this.AvailMovDGV.TabIndex = 11;
            // 
            // movieTitleRentCol
            // 
            this.movieTitleRentCol.HeaderText = "Title";
            this.movieTitleRentCol.MinimumWidth = 6;
            this.movieTitleRentCol.Name = "movieTitleRentCol";
            this.movieTitleRentCol.ReadOnly = true;
            this.movieTitleRentCol.Width = 125;
            // 
            // movieGenreRentCol
            // 
            this.movieGenreRentCol.HeaderText = "Genre";
            this.movieGenreRentCol.MinimumWidth = 6;
            this.movieGenreRentCol.Name = "movieGenreRentCol";
            this.movieGenreRentCol.ReadOnly = true;
            this.movieGenreRentCol.Width = 125;
            // 
            // movieCopiesNumCol
            // 
            this.movieCopiesNumCol.HeaderText = "Copies";
            this.movieCopiesNumCol.MinimumWidth = 6;
            this.movieCopiesNumCol.Name = "movieCopiesNumCol";
            this.movieCopiesNumCol.ReadOnly = true;
            this.movieCopiesNumCol.Width = 125;
            // 
            // movieRentalFeeCol
            // 
            this.movieRentalFeeCol.HeaderText = "Rental Fee";
            this.movieRentalFeeCol.MinimumWidth = 6;
            this.movieRentalFeeCol.Name = "movieRentalFeeCol";
            this.movieRentalFeeCol.ReadOnly = true;
            this.movieRentalFeeCol.Width = 125;
            // 
            // movieRatingCol
            // 
            this.movieRatingCol.HeaderText = "Rating";
            this.movieRatingCol.MinimumWidth = 6;
            this.movieRatingCol.Name = "movieRatingCol";
            this.movieRatingCol.ReadOnly = true;
            this.movieRatingCol.Width = 125;
            // 
            // actorSearchLabel
            // 
            this.actorSearchLabel.AutoSize = true;
            this.actorSearchLabel.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actorSearchLabel.ForeColor = System.Drawing.Color.Gold;
            this.actorSearchLabel.Location = new System.Drawing.Point(582, 173);
            this.actorSearchLabel.Name = "actorSearchLabel";
            this.actorSearchLabel.Size = new System.Drawing.Size(88, 18);
            this.actorSearchLabel.TabIndex = 16;
            this.actorSearchLabel.Text = "Search By:";
            // 
            // SearchCB
            // 
            this.SearchCB.BackColor = System.Drawing.Color.Gold;
            this.SearchCB.FormattingEnabled = true;
            this.SearchCB.Items.AddRange(new object[] {
            "Movie Title",
            "Actor Name (Full name)",
            "Genre"});
            this.SearchCB.Location = new System.Drawing.Point(582, 194);
            this.SearchCB.Name = "SearchCB";
            this.SearchCB.Size = new System.Drawing.Size(159, 23);
            this.SearchCB.TabIndex = 19;
            // 
            // rentedMoviesLabel
            // 
            this.rentedMoviesLabel.AutoSize = true;
            this.rentedMoviesLabel.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rentedMoviesLabel.ForeColor = System.Drawing.Color.Gold;
            this.rentedMoviesLabel.Location = new System.Drawing.Point(12, 548);
            this.rentedMoviesLabel.Name = "rentedMoviesLabel";
            this.rentedMoviesLabel.Size = new System.Drawing.Size(364, 26);
            this.rentedMoviesLabel.TabIndex = 21;
            this.rentedMoviesLabel.Text = "Currently Rented Movies/ Queue";
            // 
            // CurrentlyRentedDGV
            // 
            this.CurrentlyRentedDGV.AllowUserToAddRows = false;
            this.CurrentlyRentedDGV.AllowUserToDeleteRows = false;
            this.CurrentlyRentedDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CurrentlyRentedDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieTitleCol,
            this.PickupCol,
            this.DropoffCol});
            this.CurrentlyRentedDGV.Location = new System.Drawing.Point(-4, 0);
            this.CurrentlyRentedDGV.Name = "CurrentlyRentedDGV";
            this.CurrentlyRentedDGV.ReadOnly = true;
            this.CurrentlyRentedDGV.RowHeadersWidth = 51;
            this.CurrentlyRentedDGV.RowTemplate.Height = 25;
            this.CurrentlyRentedDGV.Size = new System.Drawing.Size(618, 184);
            this.CurrentlyRentedDGV.TabIndex = 22;
            // 
            // movieTitleCol
            // 
            this.movieTitleCol.HeaderText = "Title";
            this.movieTitleCol.MinimumWidth = 6;
            this.movieTitleCol.Name = "movieTitleCol";
            this.movieTitleCol.ReadOnly = true;
            this.movieTitleCol.Width = 200;
            // 
            // PickupCol
            // 
            this.PickupCol.HeaderText = "Pick Up Date";
            this.PickupCol.MinimumWidth = 6;
            this.PickupCol.Name = "PickupCol";
            this.PickupCol.ReadOnly = true;
            this.PickupCol.Width = 145;
            // 
            // DropoffCol
            // 
            this.DropoffCol.HeaderText = "Drop Off Date";
            this.DropoffCol.MinimumWidth = 6;
            this.DropoffCol.Name = "DropoffCol";
            this.DropoffCol.ReadOnly = true;
            this.DropoffCol.Width = 145;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(640, 675);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Movie Title to return:";
            // 
            // MovTitleTB
            // 
            this.MovTitleTB.BackColor = System.Drawing.Color.Gold;
            this.MovTitleTB.Location = new System.Drawing.Point(640, 696);
            this.MovTitleTB.MaxLength = 100;
            this.MovTitleTB.Name = "MovTitleTB";
            this.MovTitleTB.Size = new System.Drawing.Size(261, 23);
            this.MovTitleTB.TabIndex = 24;
            // 
            // SearchBTN
            // 
            this.SearchBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBTN.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchBTN.ForeColor = System.Drawing.Color.Gold;
            this.SearchBTN.Location = new System.Drawing.Point(747, 255);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(154, 46);
            this.SearchBTN.TabIndex = 83;
            this.SearchBTN.Text = "Search ";
            this.SearchBTN.UseVisualStyleBackColor = true;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // RandRBTN
            // 
            this.RandRBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandRBTN.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RandRBTN.ForeColor = System.Drawing.Color.Gold;
            this.RandRBTN.Location = new System.Drawing.Point(640, 724);
            this.RandRBTN.Name = "RandRBTN";
            this.RandRBTN.Size = new System.Drawing.Size(261, 63);
            this.RandRBTN.TabIndex = 84;
            this.RandRBTN.Text = "Return and Rate Movie";
            this.RandRBTN.UseVisualStyleBackColor = true;
            this.RandRBTN.Click += new System.EventHandler(this.RandRBTN_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Gold;
            this.button2.Location = new System.Drawing.Point(582, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 46);
            this.button2.TabIndex = 85;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ResetBTN_Click);
            // 
            // RentBTN
            // 
            this.RentBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RentBTN.Font = new System.Drawing.Font("Showcard Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RentBTN.ForeColor = System.Drawing.Color.Gold;
            this.RentBTN.Location = new System.Drawing.Point(582, 383);
            this.RentBTN.Name = "RentBTN";
            this.RentBTN.Size = new System.Drawing.Size(319, 60);
            this.RentBTN.TabIndex = 86;
            this.RentBTN.Text = "Rent Movie";
            this.RentBTN.UseVisualStyleBackColor = true;
            this.RentBTN.Click += new System.EventHandler(this.RentBTN_Click);
            // 
            // CRM
            // 
            this.CRM.Controls.Add(this.tabPage1);
            this.CRM.Controls.Add(this.tabPage2);
            this.CRM.Controls.Add(this.orderHistoryTab);
            this.CRM.Controls.Add(this.tabPage3);
            this.CRM.Location = new System.Drawing.Point(12, 579);
            this.CRM.Name = "CRM";
            this.CRM.SelectedIndex = 0;
            this.CRM.Size = new System.Drawing.Size(622, 208);
            this.CRM.TabIndex = 87;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CurrentlyRentedDGV);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(614, 180);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CRM";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.QueueDGV);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(614, 180);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "QUEUE";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // QueueDGV
            // 
            this.QueueDGV.AllowUserToAddRows = false;
            this.QueueDGV.AllowUserToDeleteRows = false;
            this.QueueDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QueueDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MtitleCol,
            this.GenreCol,
            this.RentfeeCol,
            this.PickupDateCol});
            this.QueueDGV.Location = new System.Drawing.Point(0, 0);
            this.QueueDGV.Name = "QueueDGV";
            this.QueueDGV.ReadOnly = true;
            this.QueueDGV.RowHeadersWidth = 51;
            this.QueueDGV.RowTemplate.Height = 25;
            this.QueueDGV.Size = new System.Drawing.Size(614, 180);
            this.QueueDGV.TabIndex = 0;
            // 
            // MtitleCol
            // 
            this.MtitleCol.HeaderText = "Title";
            this.MtitleCol.MinimumWidth = 6;
            this.MtitleCol.Name = "MtitleCol";
            this.MtitleCol.ReadOnly = true;
            this.MtitleCol.Width = 200;
            // 
            // GenreCol
            // 
            this.GenreCol.HeaderText = "Genre";
            this.GenreCol.MinimumWidth = 6;
            this.GenreCol.Name = "GenreCol";
            this.GenreCol.ReadOnly = true;
            this.GenreCol.Width = 160;
            // 
            // RentfeeCol
            // 
            this.RentfeeCol.HeaderText = "Rental Fee";
            this.RentfeeCol.MinimumWidth = 6;
            this.RentfeeCol.Name = "RentfeeCol";
            this.RentfeeCol.ReadOnly = true;
            this.RentfeeCol.Width = 130;
            // 
            // PickupDateCol
            // 
            this.PickupDateCol.HeaderText = "Pick Up Date";
            this.PickupDateCol.MinimumWidth = 6;
            this.PickupDateCol.Name = "PickupDateCol";
            this.PickupDateCol.ReadOnly = true;
            this.PickupDateCol.Width = 125;
            // 
            // orderHistoryTab
            // 
            this.orderHistoryTab.BackColor = System.Drawing.Color.MidnightBlue;
            this.orderHistoryTab.Controls.Add(this.dataGridOrderHistory);
            this.orderHistoryTab.Location = new System.Drawing.Point(4, 24);
            this.orderHistoryTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderHistoryTab.Name = "orderHistoryTab";
            this.orderHistoryTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderHistoryTab.Size = new System.Drawing.Size(614, 180);
            this.orderHistoryTab.TabIndex = 2;
            this.orderHistoryTab.Text = "HISTORY";
            // 
            // dataGridOrderHistory
            // 
            this.dataGridOrderHistory.AllowUserToAddRows = false;
            this.dataGridOrderHistory.AllowUserToDeleteRows = false;
            this.dataGridOrderHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrderHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNum,
            this.movieTitle,
            this.rentalFee,
            this.dropOffDate,
            this.pickUpDate});
            this.dataGridOrderHistory.Location = new System.Drawing.Point(-2, 0);
            this.dataGridOrderHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridOrderHistory.Name = "dataGridOrderHistory";
            this.dataGridOrderHistory.ReadOnly = true;
            this.dataGridOrderHistory.RowHeadersWidth = 51;
            this.dataGridOrderHistory.RowTemplate.Height = 29;
            this.dataGridOrderHistory.Size = new System.Drawing.Size(620, 184);
            this.dataGridOrderHistory.TabIndex = 0;
            // 
            // orderNum
            // 
            this.orderNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.orderNum.HeaderText = "Order Number";
            this.orderNum.MinimumWidth = 6;
            this.orderNum.Name = "orderNum";
            this.orderNum.ReadOnly = true;
            this.orderNum.Width = 109;
            // 
            // movieTitle
            // 
            this.movieTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.movieTitle.HeaderText = "Title";
            this.movieTitle.MinimumWidth = 6;
            this.movieTitle.Name = "movieTitle";
            this.movieTitle.ReadOnly = true;
            this.movieTitle.Width = 54;
            // 
            // rentalFee
            // 
            this.rentalFee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rentalFee.HeaderText = "Rental Fee";
            this.rentalFee.MinimumWidth = 6;
            this.rentalFee.Name = "rentalFee";
            this.rentalFee.ReadOnly = true;
            this.rentalFee.Width = 86;
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
            // pickUpDate
            // 
            this.pickUpDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pickUpDate.HeaderText = "Pick Up Date";
            this.pickUpDate.MinimumWidth = 6;
            this.pickUpDate.Name = "pickUpDate";
            this.pickUpDate.ReadOnly = true;
            this.pickUpDate.Width = 99;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.RecommendationDGV);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(614, 180);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "RECOMMENDATIONS";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // RecommendationDGV
            // 
            this.RecommendationDGV.AllowUserToAddRows = false;
            this.RecommendationDGV.AllowUserToDeleteRows = false;
            this.RecommendationDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecommendationDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.RecommendationDGV.Location = new System.Drawing.Point(-3, -2);
            this.RecommendationDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecommendationDGV.Name = "RecommendationDGV";
            this.RecommendationDGV.ReadOnly = true;
            this.RecommendationDGV.RowHeadersWidth = 51;
            this.RecommendationDGV.RowTemplate.Height = 29;
            this.RecommendationDGV.Size = new System.Drawing.Size(620, 184);
            this.RecommendationDGV.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 54;
            // 
            // MovTitleRentTB
            // 
            this.MovTitleRentTB.BackColor = System.Drawing.Color.Gold;
            this.MovTitleRentTB.Location = new System.Drawing.Point(582, 325);
            this.MovTitleRentTB.MaxLength = 100;
            this.MovTitleRentTB.Name = "MovTitleRentTB";
            this.MovTitleRentTB.Size = new System.Drawing.Size(319, 23);
            this.MovTitleRentTB.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(582, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 18);
            this.label2.TabIndex = 89;
            this.label2.Text = "Movie Title To Rent:";
            // 
            // SearchTB
            // 
            this.SearchTB.BackColor = System.Drawing.Color.Gold;
            this.SearchTB.Location = new System.Drawing.Point(582, 226);
            this.SearchTB.MaxLength = 100;
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(319, 23);
            this.SearchTB.TabIndex = 90;
            // 
            // RatingCB
            // 
            this.RatingCB.BackColor = System.Drawing.Color.Gold;
            this.RatingCB.FormattingEnabled = true;
            this.RatingCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.RatingCB.Location = new System.Drawing.Point(640, 649);
            this.RatingCB.Name = "RatingCB";
            this.RatingCB.Size = new System.Drawing.Size(101, 23);
            this.RatingCB.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(640, 628);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 92;
            this.label3.Text = "Rating";
            // 
            // PickupDTP
            // 
            this.PickupDTP.Location = new System.Drawing.Point(582, 354);
            this.PickupDTP.Name = "PickupDTP";
            this.PickupDTP.Size = new System.Drawing.Size(319, 23);
            this.PickupDTP.TabIndex = 93;
            // 
            // CSTitleLBL
            // 
            this.CSTitleLBL.AutoSize = true;
            this.CSTitleLBL.BackColor = System.Drawing.Color.Transparent;
            this.CSTitleLBL.Font = new System.Drawing.Font("Showcard Gothic", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.CSTitleLBL.ForeColor = System.Drawing.Color.Gold;
            this.CSTitleLBL.Location = new System.Drawing.Point(343, 29);
            this.CSTitleLBL.Name = "CSTitleLBL";
            this.CSTitleLBL.Size = new System.Drawing.Size(276, 43);
            this.CSTitleLBL.TabIndex = 102;
            this.CSTitleLBL.Text = "Movie Rentals";
            // 
            // RentalScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(923, 791);
            this.Controls.Add(this.CSTitleLBL);
            this.Controls.Add(this.PickupDTP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RatingCB);
            this.Controls.Add(this.SearchTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MovTitleRentTB);
            this.Controls.Add(this.CRM);
            this.Controls.Add(this.RentBTN);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RandRBTN);
            this.Controls.Add(this.SearchBTN);
            this.Controls.Add(this.MovTitleTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rentedMoviesLabel);
            this.Controls.Add(this.SearchCB);
            this.Controls.Add(this.actorSearchLabel);
            this.Controls.Add(this.AvailMovDGV);
            this.Controls.Add(this.AccountLnk);
            this.Controls.Add(this.AvailMovies);
            this.Controls.Add(this.SignOutLnk);
            this.Controls.Add(this.LogoLnk);
            this.Name = "RentalScreen";
            this.Text = "RentalScreen";
            this.Load += new System.EventHandler(this.RentalScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AvailMovDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentlyRentedDGV)).EndInit();
            this.CRM.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QueueDGV)).EndInit();
            this.orderHistoryTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderHistory)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RecommendationDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LogoLnk;
        private System.Windows.Forms.LinkLabel SignOutLnk;
        private System.Windows.Forms.Label AvailMovies;
        private System.Windows.Forms.LinkLabel AccountLnk;
        private System.Windows.Forms.DataGridView AvailMovDGV;
        private System.Windows.Forms.Label actorSearchLabel;
        private System.Windows.Forms.ComboBox SearchCB;
        private System.Windows.Forms.Label rentedMoviesLabel;
        private System.Windows.Forms.DataGridView CurrentlyRentedDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MovTitleTB;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.Button RandRBTN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button RentBTN;
        private System.Windows.Forms.TabControl CRM;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView QueueDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieTitleRentCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieGenreRentCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieCopiesNumCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieRentalFeeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieRatingCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieTitleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PickupCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DropoffCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MtitleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentfeeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PickupDateCol;
        private System.Windows.Forms.TabPage orderHistoryTab;
        private System.Windows.Forms.DataGridView dataGridOrderHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dropOffDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn pickUpDate;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView RecommendationDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox MovTitleRentTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchTB;
        private System.Windows.Forms.ComboBox RatingCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker PickupDTP;
        private System.Windows.Forms.Label CSTitleLBL;
    }
}