namespace VideoRental
{
    partial class VideosRental
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
            this.custGrid = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridVideo = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gridRentedMovie = new System.Windows.Forms.DataGridView();
            this.RMID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRented = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateReturned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gridMostBorrow = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.gridPopularVideo = new System.Windows.Forms.DataGridView();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.txtPlot = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.lblMovieId = new System.Windows.Forms.Label();
            this.btnIssueMovie = new System.Windows.Forms.Button();
            this.lblRMID = new System.Windows.Forms.Label();
            this.btnReturnMovie = new System.Windows.Forms.Button();
            this.btnShowRentedVideo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRentedOut = new System.Windows.Forms.Button();
            this.btnMostborrow = new System.Windows.Forms.Button();
            this.btnMostPopular = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.custGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVideo)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRentedMovie)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMostBorrow)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPopularVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // custGrid
            // 
            this.custGrid.AllowUserToAddRows = false;
            this.custGrid.AllowUserToDeleteRows = false;
            this.custGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.custGrid.Location = new System.Drawing.Point(6, 15);
            this.custGrid.Name = "custGrid";
            this.custGrid.ReadOnly = true;
            this.custGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.custGrid.Size = new System.Drawing.Size(639, 224);
            this.custGrid.TabIndex = 0;
            this.custGrid.Click += new System.EventHandler(this.custGrid_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(16, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(980, 271);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.custGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(972, 245);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridVideo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(972, 245);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movie";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridVideo
            // 
            this.gridVideo.AllowUserToAddRows = false;
            this.gridVideo.AllowUserToDeleteRows = false;
            this.gridVideo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVideo.Location = new System.Drawing.Point(6, 10);
            this.gridVideo.Name = "gridVideo";
            this.gridVideo.ReadOnly = true;
            this.gridVideo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridVideo.Size = new System.Drawing.Size(636, 224);
            this.gridVideo.TabIndex = 1;
            this.gridVideo.Click += new System.EventHandler(this.gridVideo_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gridRentedMovie);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(972, 245);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rented Movies";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gridRentedMovie
            // 
            this.gridRentedMovie.AllowUserToAddRows = false;
            this.gridRentedMovie.AllowUserToDeleteRows = false;
            this.gridRentedMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRentedMovie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RMID,
            this.CustId,
            this.FirstName,
            this.LastName,
            this.Address,
            this.Phone,
            this.MovieId,
            this.Title,
            this.ReleaseDate,
            this.RentalCost,
            this.Genre,
            this.Plot,
            this.DateRented,
            this.DateReturned});
            this.gridRentedMovie.Location = new System.Drawing.Point(6, 10);
            this.gridRentedMovie.Name = "gridRentedMovie";
            this.gridRentedMovie.ReadOnly = true;
            this.gridRentedMovie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRentedMovie.Size = new System.Drawing.Size(960, 224);
            this.gridRentedMovie.TabIndex = 2;
            this.gridRentedMovie.Click += new System.EventHandler(this.gridRentedMovie_Click);
            // 
            // RMID
            // 
            this.RMID.DataPropertyName = "RentedMovieId";
            this.RMID.HeaderText = "RMID";
            this.RMID.Name = "RMID";
            this.RMID.ReadOnly = true;
            this.RMID.Width = 50;
            // 
            // CustId
            // 
            this.CustId.DataPropertyName = "CustId";
            this.CustId.HeaderText = "CustId";
            this.CustId.Name = "CustId";
            this.CustId.ReadOnly = true;
            this.CustId.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 200;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Visible = false;
            // 
            // MovieId
            // 
            this.MovieId.DataPropertyName = "MovieId";
            this.MovieId.HeaderText = "MovieId";
            this.MovieId.Name = "MovieId";
            this.MovieId.ReadOnly = true;
            this.MovieId.Visible = false;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Movie Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 150;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.DataPropertyName = "ReleaseDate";
            this.ReleaseDate.HeaderText = "ReleaseDate";
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.ReadOnly = true;
            this.ReleaseDate.Visible = false;
            // 
            // RentalCost
            // 
            this.RentalCost.DataPropertyName = "RentalCost";
            this.RentalCost.HeaderText = "Rental Cost";
            this.RentalCost.Name = "RentalCost";
            this.RentalCost.ReadOnly = true;
            this.RentalCost.Width = 50;
            // 
            // Genre
            // 
            this.Genre.DataPropertyName = "Genre";
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            this.Genre.Visible = false;
            // 
            // Plot
            // 
            this.Plot.DataPropertyName = "Plot";
            this.Plot.HeaderText = "Plot";
            this.Plot.Name = "Plot";
            this.Plot.ReadOnly = true;
            this.Plot.Visible = false;
            // 
            // DateRented
            // 
            this.DateRented.DataPropertyName = "DateRented";
            this.DateRented.HeaderText = "Date Rented";
            this.DateRented.Name = "DateRented";
            this.DateRented.ReadOnly = true;
            this.DateRented.Width = 150;
            // 
            // DateReturned
            // 
            this.DateReturned.DataPropertyName = "DateReturned";
            this.DateReturned.HeaderText = "Date Returned";
            this.DateReturned.Name = "DateReturned";
            this.DateReturned.ReadOnly = true;
            this.DateReturned.Width = 150;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.gridMostBorrow);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(972, 245);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Most Borrows";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // gridMostBorrow
            // 
            this.gridMostBorrow.AllowUserToAddRows = false;
            this.gridMostBorrow.AllowUserToDeleteRows = false;
            this.gridMostBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMostBorrow.Location = new System.Drawing.Point(6, 6);
            this.gridMostBorrow.Name = "gridMostBorrow";
            this.gridMostBorrow.ReadOnly = true;
            this.gridMostBorrow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMostBorrow.Size = new System.Drawing.Size(639, 224);
            this.gridMostBorrow.TabIndex = 2;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.gridPopularVideo);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(972, 245);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Most Popular Movies";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // gridPopularVideo
            // 
            this.gridPopularVideo.AllowUserToAddRows = false;
            this.gridPopularVideo.AllowUserToDeleteRows = false;
            this.gridPopularVideo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPopularVideo.Location = new System.Drawing.Point(3, 15);
            this.gridPopularVideo.Name = "gridPopularVideo";
            this.gridPopularVideo.ReadOnly = true;
            this.gridPopularVideo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPopularVideo.Size = new System.Drawing.Size(643, 224);
            this.gridPopularVideo.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(22, 340);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(146, 340);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(270, 340);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(223, 49);
            this.txtAddress.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(517, 340);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(22, 375);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(75, 37);
            this.btnAddCustomer.TabIndex = 6;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(39, 44);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 7;
            this.lblId.Visible = false;
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(103, 375);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(75, 37);
            this.btnUpdateCustomer.TabIndex = 8;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(184, 375);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(75, 37);
            this.btnDeleteCustomer.TabIndex = 9;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Location = new System.Drawing.Point(182, 497);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(75, 37);
            this.btnDeleteMovie.TabIndex = 17;
            this.btnDeleteMovie.Text = "Delete Movie";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.Location = new System.Drawing.Point(101, 497);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(75, 37);
            this.btnUpdateMovie.TabIndex = 16;
            this.btnUpdateMovie.Text = "Update Movie";
            this.btnUpdateMovie.UseVisualStyleBackColor = true;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(20, 497);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(75, 37);
            this.btnAddMovie.TabIndex = 15;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // txtPlot
            // 
            this.txtPlot.Location = new System.Drawing.Point(517, 462);
            this.txtPlot.Name = "txtPlot";
            this.txtPlot.Size = new System.Drawing.Size(100, 20);
            this.txtPlot.TabIndex = 14;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(270, 462);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 12;
            this.txtCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCost_KeyPress);
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(393, 462);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(100, 20);
            this.txtGenre.TabIndex = 13;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(20, 462);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 10;
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtpReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReleaseDate.Location = new System.Drawing.Point(132, 462);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(129, 20);
            this.dtpReleaseDate.TabIndex = 11;
            this.dtpReleaseDate.ValueChanged += new System.EventHandler(this.dtpReleaseDate_ValueChanged);
            // 
            // lblMovieId
            // 
            this.lblMovieId.AutoSize = true;
            this.lblMovieId.Location = new System.Drawing.Point(80, 44);
            this.lblMovieId.Name = "lblMovieId";
            this.lblMovieId.Size = new System.Drawing.Size(0, 13);
            this.lblMovieId.TabIndex = 19;
            this.lblMovieId.Visible = false;
            // 
            // btnIssueMovie
            // 
            this.btnIssueMovie.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIssueMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueMovie.ForeColor = System.Drawing.Color.Red;
            this.btnIssueMovie.Location = new System.Drawing.Point(681, 331);
            this.btnIssueMovie.Name = "btnIssueMovie";
            this.btnIssueMovie.Size = new System.Drawing.Size(104, 37);
            this.btnIssueMovie.TabIndex = 20;
            this.btnIssueMovie.Text = "Issue Movie";
            this.btnIssueMovie.UseVisualStyleBackColor = false;
            this.btnIssueMovie.Click += new System.EventHandler(this.btnIssueMovie_Click);
            // 
            // lblRMID
            // 
            this.lblRMID.AutoSize = true;
            this.lblRMID.Location = new System.Drawing.Point(131, 43);
            this.lblRMID.Name = "lblRMID";
            this.lblRMID.Size = new System.Drawing.Size(0, 13);
            this.lblRMID.TabIndex = 21;
            this.lblRMID.Visible = false;
            // 
            // btnReturnMovie
            // 
            this.btnReturnMovie.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReturnMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMovie.ForeColor = System.Drawing.Color.Green;
            this.btnReturnMovie.Location = new System.Drawing.Point(795, 331);
            this.btnReturnMovie.Name = "btnReturnMovie";
            this.btnReturnMovie.Size = new System.Drawing.Size(104, 37);
            this.btnReturnMovie.TabIndex = 22;
            this.btnReturnMovie.Text = "Return Movie";
            this.btnReturnMovie.UseVisualStyleBackColor = false;
            this.btnReturnMovie.Click += new System.EventHandler(this.btnReturnMovie_Click);
            // 
            // btnShowRentedVideo
            // 
            this.btnShowRentedVideo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnShowRentedVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowRentedVideo.ForeColor = System.Drawing.Color.Red;
            this.btnShowRentedVideo.Location = new System.Drawing.Point(681, 390);
            this.btnShowRentedVideo.Name = "btnShowRentedVideo";
            this.btnShowRentedVideo.Size = new System.Drawing.Size(104, 37);
            this.btnShowRentedVideo.TabIndex = 23;
            this.btnShowRentedVideo.Text = "Show All Rented Movie";
            this.btnShowRentedVideo.UseVisualStyleBackColor = false;
            this.btnShowRentedVideo.Click += new System.EventHandler(this.btnShowRentedVideo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(533, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Phone No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Video Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(153, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Release Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(288, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Rental Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(405, 446);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Genre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(533, 446);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Plot";
            // 
            // btnRentedOut
            // 
            this.btnRentedOut.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRentedOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentedOut.ForeColor = System.Drawing.Color.Green;
            this.btnRentedOut.Location = new System.Drawing.Point(795, 390);
            this.btnRentedOut.Name = "btnRentedOut";
            this.btnRentedOut.Size = new System.Drawing.Size(104, 37);
            this.btnRentedOut.TabIndex = 33;
            this.btnRentedOut.Text = "Rented Out Movie";
            this.btnRentedOut.UseVisualStyleBackColor = false;
            this.btnRentedOut.Click += new System.EventHandler(this.btnRentedOut_Click);
            // 
            // btnMostborrow
            // 
            this.btnMostborrow.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMostborrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostborrow.ForeColor = System.Drawing.Color.Red;
            this.btnMostborrow.Location = new System.Drawing.Point(681, 445);
            this.btnMostborrow.Name = "btnMostborrow";
            this.btnMostborrow.Size = new System.Drawing.Size(104, 37);
            this.btnMostborrow.TabIndex = 34;
            this.btnMostborrow.Text = "Who Most Borrows Video?";
            this.btnMostborrow.UseVisualStyleBackColor = false;
            this.btnMostborrow.Click += new System.EventHandler(this.btnMostborrow_Click);
            // 
            // btnMostPopular
            // 
            this.btnMostPopular.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMostPopular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostPopular.ForeColor = System.Drawing.Color.Green;
            this.btnMostPopular.Location = new System.Drawing.Point(795, 446);
            this.btnMostPopular.Name = "btnMostPopular";
            this.btnMostPopular.Size = new System.Drawing.Size(104, 37);
            this.btnMostPopular.TabIndex = 35;
            this.btnMostPopular.Text = "Most Popular Video\'s";
            this.btnMostPopular.UseVisualStyleBackColor = false;
            this.btnMostPopular.Click += new System.EventHandler(this.btnMostPopular_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(381, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(236, 26);
            this.label10.TabIndex = 36;
            this.label10.Text = "Video Rental System";
            // 
            // VideosRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 544);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnMostPopular);
            this.Controls.Add(this.btnMostborrow);
            this.Controls.Add(this.btnRentedOut);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowRentedVideo);
            this.Controls.Add(this.btnReturnMovie);
            this.Controls.Add(this.lblRMID);
            this.Controls.Add(this.btnIssueMovie);
            this.Controls.Add(this.lblMovieId);
            this.Controls.Add(this.dtpReleaseDate);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.btnUpdateMovie);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.txtPlot);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.tabControl1);
            this.Name = "VideosRental";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VideosRental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.custGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVideo)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRentedMovie)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMostBorrow)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPopularVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView custGrid;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.DataGridView gridVideo;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.TextBox txtPlot;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.DateTimePicker dtpReleaseDate;
        private System.Windows.Forms.Label lblMovieId;
        private System.Windows.Forms.Button btnIssueMovie;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView gridRentedMovie;
        private System.Windows.Forms.Label lblRMID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RMID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plot;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRented;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateReturned;
        private System.Windows.Forms.Button btnReturnMovie;
        private System.Windows.Forms.Button btnShowRentedVideo;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView gridMostBorrow;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView gridPopularVideo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRentedOut;
        private System.Windows.Forms.Button btnMostborrow;
        private System.Windows.Forms.Button btnMostPopular;
        private System.Windows.Forms.Label label10;
    }
}

