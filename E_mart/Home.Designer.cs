
namespace E_mart
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.manager_dash = new FontAwesome.Sharp.IconButton();
            this.btn_stock = new FontAwesome.Sharp.IconButton();
            this.btn_manageemp = new FontAwesome.Sharp.IconButton();
            this.btn_report = new FontAwesome.Sharp.IconButton();
            this.btn_setings = new FontAwesome.Sharp.IconButton();
            this.btn_customer = new FontAwesome.Sharp.IconButton();
            this.btn_history = new FontAwesome.Sharp.IconButton();
            this.btn_product = new FontAwesome.Sharp.IconButton();
            this.btn_dash = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Home = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btn_Maximize = new FontAwesome.Sharp.IconPictureBox();
            this.btn_Minimize = new FontAwesome.Sharp.IconPictureBox();
            this.btn_Exit = new FontAwesome.Sharp.IconPictureBox();
            this.lablTitle = new System.Windows.Forms.Label();
            this.iconCurrentForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Home)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.manager_dash);
            this.panelMenu.Controls.Add(this.btn_stock);
            this.panelMenu.Controls.Add(this.btn_manageemp);
            this.panelMenu.Controls.Add(this.btn_report);
            this.panelMenu.Controls.Add(this.btn_setings);
            this.panelMenu.Controls.Add(this.btn_customer);
            this.panelMenu.Controls.Add(this.btn_history);
            this.panelMenu.Controls.Add(this.btn_product);
            this.panelMenu.Controls.Add(this.btn_dash);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 721);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // manager_dash
            // 
            this.manager_dash.Dock = System.Windows.Forms.DockStyle.Top;
            this.manager_dash.FlatAppearance.BorderSize = 0;
            this.manager_dash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manager_dash.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manager_dash.ForeColor = System.Drawing.Color.White;
            this.manager_dash.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.manager_dash.IconColor = System.Drawing.Color.White;
            this.manager_dash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.manager_dash.IconSize = 43;
            this.manager_dash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manager_dash.Location = new System.Drawing.Point(0, 452);
            this.manager_dash.Name = "manager_dash";
            this.manager_dash.Size = new System.Drawing.Size(220, 52);
            this.manager_dash.TabIndex = 9;
            this.manager_dash.Text = "DashBord";
            this.manager_dash.UseVisualStyleBackColor = true;
            this.manager_dash.Click += new System.EventHandler(this.manager_dash_Click);
            // 
            // btn_stock
            // 
            this.btn_stock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_stock.FlatAppearance.BorderSize = 0;
            this.btn_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stock.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stock.ForeColor = System.Drawing.Color.White;
            this.btn_stock.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.btn_stock.IconColor = System.Drawing.Color.White;
            this.btn_stock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_stock.IconSize = 43;
            this.btn_stock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stock.Location = new System.Drawing.Point(0, 400);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(220, 52);
            this.btn_stock.TabIndex = 8;
            this.btn_stock.Text = "view stock";
            this.btn_stock.UseVisualStyleBackColor = true;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // btn_manageemp
            // 
            this.btn_manageemp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_manageemp.FlatAppearance.BorderSize = 0;
            this.btn_manageemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manageemp.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manageemp.ForeColor = System.Drawing.Color.White;
            this.btn_manageemp.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.btn_manageemp.IconColor = System.Drawing.Color.White;
            this.btn_manageemp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_manageemp.IconSize = 43;
            this.btn_manageemp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_manageemp.Location = new System.Drawing.Point(0, 348);
            this.btn_manageemp.Name = "btn_manageemp";
            this.btn_manageemp.Size = new System.Drawing.Size(220, 52);
            this.btn_manageemp.TabIndex = 7;
            this.btn_manageemp.Text = "Manage Emp";
            this.btn_manageemp.UseVisualStyleBackColor = true;
            this.btn_manageemp.Click += new System.EventHandler(this.btn_manageemp_Click);
            // 
            // btn_report
            // 
            this.btn_report.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_report.FlatAppearance.BorderSize = 0;
            this.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_report.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.ForeColor = System.Drawing.Color.White;
            this.btn_report.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.btn_report.IconColor = System.Drawing.Color.White;
            this.btn_report.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_report.IconSize = 43;
            this.btn_report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_report.Location = new System.Drawing.Point(0, 617);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(220, 52);
            this.btn_report.TabIndex = 6;
            this.btn_report.Text = "Report";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_setings
            // 
            this.btn_setings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_setings.FlatAppearance.BorderSize = 0;
            this.btn_setings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setings.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setings.ForeColor = System.Drawing.Color.White;
            this.btn_setings.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.btn_setings.IconColor = System.Drawing.Color.White;
            this.btn_setings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_setings.IconSize = 43;
            this.btn_setings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setings.Location = new System.Drawing.Point(0, 669);
            this.btn_setings.Name = "btn_setings";
            this.btn_setings.Size = new System.Drawing.Size(220, 52);
            this.btn_setings.TabIndex = 5;
            this.btn_setings.Text = "Log Out";
            this.btn_setings.UseVisualStyleBackColor = true;
            this.btn_setings.Click += new System.EventHandler(this.btn_setings_Click);
            // 
            // btn_customer
            // 
            this.btn_customer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_customer.FlatAppearance.BorderSize = 0;
            this.btn_customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customer.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customer.ForeColor = System.Drawing.Color.White;
            this.btn_customer.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btn_customer.IconColor = System.Drawing.Color.White;
            this.btn_customer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_customer.IconSize = 43;
            this.btn_customer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customer.Location = new System.Drawing.Point(0, 296);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Size = new System.Drawing.Size(220, 52);
            this.btn_customer.TabIndex = 4;
            this.btn_customer.Text = "Customer";
            this.btn_customer.UseVisualStyleBackColor = true;
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // btn_history
            // 
            this.btn_history.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_history.FlatAppearance.BorderSize = 0;
            this.btn_history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_history.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_history.ForeColor = System.Drawing.Color.White;
            this.btn_history.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btn_history.IconColor = System.Drawing.Color.White;
            this.btn_history.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_history.IconSize = 43;
            this.btn_history.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_history.Location = new System.Drawing.Point(0, 244);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(220, 52);
            this.btn_history.TabIndex = 3;
            this.btn_history.Text = "Order History";
            this.btn_history.UseVisualStyleBackColor = true;
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // btn_product
            // 
            this.btn_product.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_product.FlatAppearance.BorderSize = 0;
            this.btn_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_product.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_product.ForeColor = System.Drawing.Color.White;
            this.btn_product.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btn_product.IconColor = System.Drawing.Color.White;
            this.btn_product.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_product.IconSize = 43;
            this.btn_product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_product.Location = new System.Drawing.Point(0, 192);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(220, 52);
            this.btn_product.TabIndex = 2;
            this.btn_product.Text = "Product";
            this.btn_product.UseVisualStyleBackColor = true;
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // btn_dash
            // 
            this.btn_dash.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dash.FlatAppearance.BorderSize = 0;
            this.btn_dash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dash.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dash.ForeColor = System.Drawing.Color.White;
            this.btn_dash.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.btn_dash.IconColor = System.Drawing.Color.White;
            this.btn_dash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_dash.IconSize = 43;
            this.btn_dash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dash.Location = new System.Drawing.Point(0, 140);
            this.btn_dash.Name = "btn_dash";
            this.btn_dash.Size = new System.Drawing.Size(220, 52);
            this.btn_dash.TabIndex = 1;
            this.btn_dash.Text = "DashBoard";
            this.btn_dash.UseVisualStyleBackColor = true;
            this.btn_dash.Click += new System.EventHandler(this.btn_dash_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 140);
            this.panel1.TabIndex = 0;
            // 
            // btn_Home
            // 
            this.btn_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Home.Image = ((System.Drawing.Image)(resources.GetObject("btn_Home.Image")));
            this.btn_Home.Location = new System.Drawing.Point(0, 0);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(220, 137);
            this.btn_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Home.TabIndex = 0;
            this.btn_Home.TabStop = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTitleBar.Controls.Add(this.btn_Maximize);
            this.panelTitleBar.Controls.Add(this.btn_Minimize);
            this.panelTitleBar.Controls.Add(this.btn_Exit);
            this.panelTitleBar.Controls.Add(this.lablTitle);
            this.panelTitleBar.Controls.Add(this.iconCurrentForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1112, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Maximize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Maximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btn_Maximize.IconColor = System.Drawing.SystemColors.ControlText;
            this.btn_Maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Maximize.IconSize = 21;
            this.btn_Maximize.Location = new System.Drawing.Point(1062, 0);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(22, 21);
            this.btn_Maximize.TabIndex = 3;
            this.btn_Maximize.TabStop = false;
            this.btn_Maximize.Click += new System.EventHandler(this.btn_Maximize_Click);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Minimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btn_Minimize.IconColor = System.Drawing.SystemColors.ControlText;
            this.btn_Minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Minimize.IconSize = 21;
            this.btn_Minimize.Location = new System.Drawing.Point(1034, 0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(22, 21);
            this.btn_Minimize.TabIndex = 2;
            this.btn_Minimize.TabStop = false;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Exit.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btn_Exit.IconColor = System.Drawing.SystemColors.ControlText;
            this.btn_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Exit.IconSize = 21;
            this.btn_Exit.Location = new System.Drawing.Point(1090, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(22, 21);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.TabStop = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lablTitle
            // 
            this.lablTitle.AutoSize = true;
            this.lablTitle.ForeColor = System.Drawing.Color.MediumPurple;
            this.lablTitle.Location = new System.Drawing.Point(65, 42);
            this.lablTitle.Name = "lablTitle";
            this.lablTitle.Size = new System.Drawing.Size(35, 13);
            this.lablTitle.TabIndex = 1;
            this.lablTitle.Text = "Home";
            // 
            // iconCurrentForm
            // 
            this.iconCurrentForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.iconCurrentForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconCurrentForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentForm.IconSize = 39;
            this.iconCurrentForm.Location = new System.Drawing.Point(20, 28);
            this.iconCurrentForm.Name = "iconCurrentForm";
            this.iconCurrentForm.Size = new System.Drawing.Size(39, 44);
            this.iconCurrentForm.TabIndex = 0;
            this.iconCurrentForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(107)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1112, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.panel2);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1112, 637);
            this.panelDesktop.TabIndex = 3;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 146);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00:00";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(74, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(520, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "sunday, september 17, 2022";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(292, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(292, 306);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 207);
            this.panel2.TabIndex = 3;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 721);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Home)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btn_dash;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_report;
        private FontAwesome.Sharp.IconButton btn_setings;
        private FontAwesome.Sharp.IconButton btn_customer;
        private FontAwesome.Sharp.IconButton btn_history;
        private FontAwesome.Sharp.IconButton btn_product;
        private System.Windows.Forms.PictureBox btn_Home;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lablTitle;
        private FontAwesome.Sharp.IconPictureBox iconCurrentForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox btn_Maximize;
        private FontAwesome.Sharp.IconPictureBox btn_Minimize;
        private FontAwesome.Sharp.IconPictureBox btn_Exit;
        private FontAwesome.Sharp.IconButton btn_manageemp;
        private FontAwesome.Sharp.IconButton btn_stock;
        private FontAwesome.Sharp.IconButton manager_dash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}