namespace RentalService
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.pnMenu = new Guna.UI.WinForms.GunaPanel();
            this.bt_removeUser = new Guna.UI.WinForms.GunaButton();
            this.pnSubRentMenu = new Guna.UI.WinForms.GunaPanel();
            this.sbtR_addCar = new Guna.UI.WinForms.GunaButton();
            this.sbtR_Cars = new Guna.UI.WinForms.GunaButton();
            this.bt_logout = new Guna.UI.WinForms.GunaButton();
            this.bt_Rent = new Guna.UI.WinForms.GunaButton();
            this.bt_Home = new Guna.UI.WinForms.GunaButton();
            this.pnLogo = new Guna.UI.WinForms.GunaPanel();
            this.gunaPictureBoxLogo = new Guna.UI.WinForms.GunaPictureBox();
            this.pnControl = new Guna.UI.WinForms.GunaPanel();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.pnUserInfo = new Guna.UI.WinForms.GunaPanel();
            this.pnLogin = new Guna.UI.WinForms.GunaPanel();
            this.lb_login = new System.Windows.Forms.Label();
            this.pnAvaUser = new Guna.UI.WinForms.GunaPanel();
            this.gunaPictureBoxAvatar = new Guna.UI.WinForms.GunaPictureBox();
            this.pnDesktop = new Guna.UI.WinForms.GunaPanel();
            this.lb_strdate = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.gunaPictureBoxDesktopLogo = new Guna.UI.WinForms.GunaPictureBox();
            this.pnChildForm = new Guna.UI.WinForms.GunaPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DragConrolLeftPanel = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.DragControlLogo = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControlDesktop = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControlDesktopLogo = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.DragControlUserInfo = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControlPnLogin = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControlAvatar = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.pnMenu.SuspendLayout();
            this.pnSubRentMenu.SuspendLayout();
            this.pnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBoxLogo)).BeginInit();
            this.pnControl.SuspendLayout();
            this.pnUserInfo.SuspendLayout();
            this.pnLogin.SuspendLayout();
            this.pnAvaUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBoxAvatar)).BeginInit();
            this.pnDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBoxDesktopLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnMenu.Controls.Add(this.bt_removeUser);
            this.pnMenu.Controls.Add(this.pnSubRentMenu);
            this.pnMenu.Controls.Add(this.bt_logout);
            this.pnMenu.Controls.Add(this.bt_Rent);
            this.pnMenu.Controls.Add(this.bt_Home);
            this.pnMenu.Controls.Add(this.pnLogo);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(220, 630);
            this.pnMenu.TabIndex = 1;
            // 
            // bt_removeUser
            // 
            this.bt_removeUser.AnimationHoverSpeed = 0.07F;
            this.bt_removeUser.AnimationSpeed = 0.03F;
            this.bt_removeUser.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.bt_removeUser.BorderColor = System.Drawing.Color.Black;
            this.bt_removeUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bt_removeUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_removeUser.FocusedColor = System.Drawing.Color.Empty;
            this.bt_removeUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bt_removeUser.ForeColor = System.Drawing.Color.White;
            this.bt_removeUser.Image = global::RentalService.Properties.Resources.removeuser;
            this.bt_removeUser.ImageSize = new System.Drawing.Size(42, 42);
            this.bt_removeUser.Location = new System.Drawing.Point(0, 291);
            this.bt_removeUser.Name = "bt_removeUser";
            this.bt_removeUser.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(60)))));
            this.bt_removeUser.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.bt_removeUser.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_removeUser.OnHoverImage = null;
            this.bt_removeUser.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(4)))), ((int)(((byte)(52)))));
            this.bt_removeUser.Size = new System.Drawing.Size(220, 48);
            this.bt_removeUser.TabIndex = 5;
            this.bt_removeUser.Text = "Remove user";
            this.bt_removeUser.Click += new System.EventHandler(this.bt_removeUser_Click);
            // 
            // pnSubRentMenu
            // 
            this.pnSubRentMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(60)))));
            this.pnSubRentMenu.Controls.Add(this.sbtR_addCar);
            this.pnSubRentMenu.Controls.Add(this.sbtR_Cars);
            this.pnSubRentMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSubRentMenu.Location = new System.Drawing.Point(0, 195);
            this.pnSubRentMenu.Name = "pnSubRentMenu";
            this.pnSubRentMenu.Size = new System.Drawing.Size(220, 96);
            this.pnSubRentMenu.TabIndex = 4;
            this.pnSubRentMenu.Visible = false;
            // 
            // sbtR_addCar
            // 
            this.sbtR_addCar.AnimationHoverSpeed = 0.07F;
            this.sbtR_addCar.AnimationSpeed = 0.03F;
            this.sbtR_addCar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(60)))));
            this.sbtR_addCar.BorderColor = System.Drawing.Color.Black;
            this.sbtR_addCar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.sbtR_addCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtR_addCar.FocusedColor = System.Drawing.Color.Empty;
            this.sbtR_addCar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.sbtR_addCar.ForeColor = System.Drawing.Color.White;
            this.sbtR_addCar.Image = global::RentalService.Properties.Resources.addCar;
            this.sbtR_addCar.ImageOffsetX = 15;
            this.sbtR_addCar.ImageSize = new System.Drawing.Size(38, 38);
            this.sbtR_addCar.Location = new System.Drawing.Point(0, 48);
            this.sbtR_addCar.Name = "sbtR_addCar";
            this.sbtR_addCar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))));
            this.sbtR_addCar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.sbtR_addCar.OnHoverForeColor = System.Drawing.Color.White;
            this.sbtR_addCar.OnHoverImage = null;
            this.sbtR_addCar.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(60)))));
            this.sbtR_addCar.Size = new System.Drawing.Size(220, 48);
            this.sbtR_addCar.TabIndex = 4;
            this.sbtR_addCar.Text = "Add car";
            this.sbtR_addCar.Click += new System.EventHandler(this.sbtR_addCar_Click);
            // 
            // sbtR_Cars
            // 
            this.sbtR_Cars.AnimationHoverSpeed = 0.07F;
            this.sbtR_Cars.AnimationSpeed = 0.03F;
            this.sbtR_Cars.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(60)))));
            this.sbtR_Cars.BorderColor = System.Drawing.Color.Black;
            this.sbtR_Cars.DialogResult = System.Windows.Forms.DialogResult.None;
            this.sbtR_Cars.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbtR_Cars.FocusedColor = System.Drawing.Color.Empty;
            this.sbtR_Cars.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.sbtR_Cars.ForeColor = System.Drawing.Color.White;
            this.sbtR_Cars.Image = global::RentalService.Properties.Resources.listsearch;
            this.sbtR_Cars.ImageOffsetX = 15;
            this.sbtR_Cars.ImageSize = new System.Drawing.Size(38, 38);
            this.sbtR_Cars.Location = new System.Drawing.Point(0, 0);
            this.sbtR_Cars.Name = "sbtR_Cars";
            this.sbtR_Cars.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))));
            this.sbtR_Cars.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.sbtR_Cars.OnHoverForeColor = System.Drawing.Color.White;
            this.sbtR_Cars.OnHoverImage = null;
            this.sbtR_Cars.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(60)))));
            this.sbtR_Cars.Size = new System.Drawing.Size(220, 48);
            this.sbtR_Cars.TabIndex = 3;
            this.sbtR_Cars.Text = "Cars";
            this.sbtR_Cars.Click += new System.EventHandler(this.sbtR_Cars_Click);
            // 
            // bt_logout
            // 
            this.bt_logout.AnimationHoverSpeed = 0.07F;
            this.bt_logout.AnimationSpeed = 0.03F;
            this.bt_logout.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.bt_logout.BorderColor = System.Drawing.Color.Black;
            this.bt_logout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bt_logout.FocusedColor = System.Drawing.Color.Empty;
            this.bt_logout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.bt_logout.ForeColor = System.Drawing.Color.White;
            this.bt_logout.Image = global::RentalService.Properties.Resources.logout;
            this.bt_logout.ImageSize = new System.Drawing.Size(32, 32);
            this.bt_logout.Location = new System.Drawing.Point(0, 582);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(60)))));
            this.bt_logout.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.bt_logout.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_logout.OnHoverImage = null;
            this.bt_logout.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(4)))), ((int)(((byte)(52)))));
            this.bt_logout.Size = new System.Drawing.Size(220, 48);
            this.bt_logout.TabIndex = 3;
            this.bt_logout.Text = "Logout";
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // bt_Rent
            // 
            this.bt_Rent.AnimationHoverSpeed = 0.07F;
            this.bt_Rent.AnimationSpeed = 0.03F;
            this.bt_Rent.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.bt_Rent.BorderColor = System.Drawing.Color.Black;
            this.bt_Rent.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bt_Rent.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Rent.FocusedColor = System.Drawing.Color.Empty;
            this.bt_Rent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bt_Rent.ForeColor = System.Drawing.Color.White;
            this.bt_Rent.Image = global::RentalService.Properties.Resources.car;
            this.bt_Rent.ImageSize = new System.Drawing.Size(42, 42);
            this.bt_Rent.Location = new System.Drawing.Point(0, 147);
            this.bt_Rent.Name = "bt_Rent";
            this.bt_Rent.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(60)))));
            this.bt_Rent.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.bt_Rent.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_Rent.OnHoverImage = null;
            this.bt_Rent.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(4)))), ((int)(((byte)(52)))));
            this.bt_Rent.Size = new System.Drawing.Size(220, 48);
            this.bt_Rent.TabIndex = 2;
            this.bt_Rent.Text = "Rent";
            this.bt_Rent.Click += new System.EventHandler(this.bt_Rent_Click);
            // 
            // bt_Home
            // 
            this.bt_Home.AnimationHoverSpeed = 0.07F;
            this.bt_Home.AnimationSpeed = 0.03F;
            this.bt_Home.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.bt_Home.BorderColor = System.Drawing.Color.Black;
            this.bt_Home.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bt_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Home.FocusedColor = System.Drawing.Color.Empty;
            this.bt_Home.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bt_Home.ForeColor = System.Drawing.Color.White;
            this.bt_Home.Image = global::RentalService.Properties.Resources.Home;
            this.bt_Home.ImageSize = new System.Drawing.Size(42, 42);
            this.bt_Home.Location = new System.Drawing.Point(0, 99);
            this.bt_Home.Name = "bt_Home";
            this.bt_Home.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(60)))));
            this.bt_Home.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.bt_Home.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_Home.OnHoverImage = null;
            this.bt_Home.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(4)))), ((int)(((byte)(52)))));
            this.bt_Home.Size = new System.Drawing.Size(220, 48);
            this.bt_Home.TabIndex = 1;
            this.bt_Home.Text = "Home";
            this.bt_Home.Click += new System.EventHandler(this.bt_Home_Click);
            // 
            // pnLogo
            // 
            this.pnLogo.Controls.Add(this.gunaPictureBoxLogo);
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(220, 99);
            this.pnLogo.TabIndex = 0;
            // 
            // gunaPictureBoxLogo
            // 
            this.gunaPictureBoxLogo.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBoxLogo.Image = global::RentalService.Properties.Resources.menulogo;
            this.gunaPictureBoxLogo.Location = new System.Drawing.Point(12, 8);
            this.gunaPictureBoxLogo.Name = "gunaPictureBoxLogo";
            this.gunaPictureBoxLogo.Size = new System.Drawing.Size(195, 85);
            this.gunaPictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBoxLogo.TabIndex = 0;
            this.gunaPictureBoxLogo.TabStop = false;
            // 
            // pnControl
            // 
            this.pnControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(60)))));
            this.pnControl.Controls.Add(this.gunaControlBox2);
            this.pnControl.Controls.Add(this.gunaControlBox1);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnControl.Location = new System.Drawing.Point(220, 0);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(904, 29);
            this.pnControl.TabIndex = 2;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(249)))));
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(818, 0);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox2.TabIndex = 1;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(249)))));
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(859, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 0;
            // 
            // pnUserInfo
            // 
            this.pnUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(60)))));
            this.pnUserInfo.Controls.Add(this.pnLogin);
            this.pnUserInfo.Controls.Add(this.pnAvaUser);
            this.pnUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnUserInfo.Location = new System.Drawing.Point(220, 29);
            this.pnUserInfo.Name = "pnUserInfo";
            this.pnUserInfo.Size = new System.Drawing.Size(904, 70);
            this.pnUserInfo.TabIndex = 3;
            // 
            // pnLogin
            // 
            this.pnLogin.Controls.Add(this.lb_login);
            this.pnLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogin.Location = new System.Drawing.Point(0, 0);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(840, 40);
            this.pnLogin.TabIndex = 4;
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_login.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_login.ForeColor = System.Drawing.Color.White;
            this.lb_login.Location = new System.Drawing.Point(769, 0);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(71, 28);
            this.lb_login.TabIndex = 2;
            this.lb_login.Text = "alogin";
            // 
            // pnAvaUser
            // 
            this.pnAvaUser.Controls.Add(this.gunaPictureBoxAvatar);
            this.pnAvaUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnAvaUser.Location = new System.Drawing.Point(840, 0);
            this.pnAvaUser.Name = "pnAvaUser";
            this.pnAvaUser.Size = new System.Drawing.Size(64, 70);
            this.pnAvaUser.TabIndex = 3;
            // 
            // gunaPictureBoxAvatar
            // 
            this.gunaPictureBoxAvatar.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBoxAvatar.Image = global::RentalService.Properties.Resources.adminicon;
            this.gunaPictureBoxAvatar.Location = new System.Drawing.Point(3, 6);
            this.gunaPictureBoxAvatar.Name = "gunaPictureBoxAvatar";
            this.gunaPictureBoxAvatar.Size = new System.Drawing.Size(55, 55);
            this.gunaPictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBoxAvatar.TabIndex = 0;
            this.gunaPictureBoxAvatar.TabStop = false;
            // 
            // pnDesktop
            // 
            this.pnDesktop.Controls.Add(this.lb_strdate);
            this.pnDesktop.Controls.Add(this.lb_time);
            this.pnDesktop.Controls.Add(this.gunaPictureBoxDesktopLogo);
            this.pnDesktop.Location = new System.Drawing.Point(220, 99);
            this.pnDesktop.Name = "pnDesktop";
            this.pnDesktop.Size = new System.Drawing.Size(904, 531);
            this.pnDesktop.TabIndex = 4;
            // 
            // lb_strdate
            // 
            this.lb_strdate.AutoSize = true;
            this.lb_strdate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lb_strdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(249)))));
            this.lb_strdate.Location = new System.Drawing.Point(310, 357);
            this.lb_strdate.Name = "lb_strdate";
            this.lb_strdate.Size = new System.Drawing.Size(278, 30);
            this.lb_strdate.TabIndex = 3;
            this.lb_strdate.Text = "date date date date date ";
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.lb_time.ForeColor = System.Drawing.Color.White;
            this.lb_time.Location = new System.Drawing.Point(358, 298);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(199, 59);
            this.lb_time.TabIndex = 2;
            this.lb_time.Text = "00:00:00";
            // 
            // gunaPictureBoxDesktopLogo
            // 
            this.gunaPictureBoxDesktopLogo.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBoxDesktopLogo.Image = global::RentalService.Properties.Resources.logofordesktop1;
            this.gunaPictureBoxDesktopLogo.Location = new System.Drawing.Point(201, 119);
            this.gunaPictureBoxDesktopLogo.Name = "gunaPictureBoxDesktopLogo";
            this.gunaPictureBoxDesktopLogo.Size = new System.Drawing.Size(520, 179);
            this.gunaPictureBoxDesktopLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gunaPictureBoxDesktopLogo.TabIndex = 0;
            this.gunaPictureBoxDesktopLogo.TabStop = false;
            // 
            // pnChildForm
            // 
            this.pnChildForm.Location = new System.Drawing.Point(220, 99);
            this.pnChildForm.Name = "pnChildForm";
            this.pnChildForm.Size = new System.Drawing.Size(904, 531);
            this.pnChildForm.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DragConrolLeftPanel
            // 
            this.DragConrolLeftPanel.TargetControl = this.pnMenu;
            // 
            // DragControlLogo
            // 
            this.DragControlLogo.TargetControl = this.gunaPictureBoxLogo;
            // 
            // gunaDragControlDesktop
            // 
            this.gunaDragControlDesktop.TargetControl = this.pnDesktop;
            // 
            // gunaDragControlDesktopLogo
            // 
            this.gunaDragControlDesktopLogo.TargetControl = this.gunaPictureBoxDesktopLogo;
            // 
            // gunaDragControl
            // 
            this.gunaDragControl.TargetControl = this.pnControl;
            // 
            // DragControlUserInfo
            // 
            this.DragControlUserInfo.TargetControl = this.pnUserInfo;
            // 
            // gunaDragControlPnLogin
            // 
            this.gunaDragControlPnLogin.TargetControl = this.pnLogin;
            // 
            // gunaDragControlAvatar
            // 
            this.gunaDragControlAvatar.TargetControl = this.gunaPictureBoxAvatar;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(4)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1124, 630);
            this.Controls.Add(this.pnUserInfo);
            this.Controls.Add(this.pnControl);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.pnDesktop);
            this.Controls.Add(this.pnChildForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.pnMenu.ResumeLayout(false);
            this.pnSubRentMenu.ResumeLayout(false);
            this.pnLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBoxLogo)).EndInit();
            this.pnControl.ResumeLayout(false);
            this.pnUserInfo.ResumeLayout(false);
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.pnAvaUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBoxAvatar)).EndInit();
            this.pnDesktop.ResumeLayout(false);
            this.pnDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBoxDesktopLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnMenu;
        private Guna.UI.WinForms.GunaButton bt_removeUser;
        private Guna.UI.WinForms.GunaPanel pnSubRentMenu;
        private Guna.UI.WinForms.GunaButton sbtR_addCar;
        private Guna.UI.WinForms.GunaButton sbtR_Cars;
        private Guna.UI.WinForms.GunaButton bt_logout;
        private Guna.UI.WinForms.GunaButton bt_Rent;
        private Guna.UI.WinForms.GunaButton bt_Home;
        private Guna.UI.WinForms.GunaPanel pnLogo;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBoxLogo;
        private Guna.UI.WinForms.GunaPanel pnControl;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaPanel pnUserInfo;
        private Guna.UI.WinForms.GunaPanel pnLogin;
        private System.Windows.Forms.Label lb_login;
        private Guna.UI.WinForms.GunaPanel pnAvaUser;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBoxAvatar;
        private Guna.UI.WinForms.GunaPanel pnDesktop;
        private System.Windows.Forms.Label lb_strdate;
        private System.Windows.Forms.Label lb_time;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBoxDesktopLogo;
        private Guna.UI.WinForms.GunaPanel pnChildForm;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaDragControl DragConrolLeftPanel;
        private Guna.UI.WinForms.GunaDragControl DragControlLogo;
        private Guna.UI.WinForms.GunaDragControl gunaDragControlDesktop;
        private Guna.UI.WinForms.GunaDragControl gunaDragControlDesktopLogo;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl;
        private Guna.UI.WinForms.GunaDragControl DragControlUserInfo;
        private Guna.UI.WinForms.GunaDragControl gunaDragControlPnLogin;
        private Guna.UI.WinForms.GunaDragControl gunaDragControlAvatar;
    }
}