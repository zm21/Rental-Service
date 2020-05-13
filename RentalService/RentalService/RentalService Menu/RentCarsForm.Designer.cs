namespace RentalService
{
    partial class RentCarsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentCarsForm));
            this.chb_available = new Guna.UI.WinForms.GunaCheckBox();
            this.chb_sportCoupe = new Guna.UI.WinForms.GunaCheckBox();
            this.chb_suv = new Guna.UI.WinForms.GunaCheckBox();
            this.chb_stationWagon = new Guna.UI.WinForms.GunaCheckBox();
            this.chb_minivan = new Guna.UI.WinForms.GunaCheckBox();
            this.chb_electricCar = new Guna.UI.WinForms.GunaCheckBox();
            this.chb_cabriolet = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.bt_find = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaSeparator2 = new Guna.UI.WinForms.GunaSeparator();
            this.bt_rent = new Guna.UI.WinForms.GunaGradientButton();
            this.DataGrid_cars = new Guna.UI.WinForms.GunaDataGridView();
            this.Available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicensePlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chb_sedan = new Guna.UI.WinForms.GunaCheckBox();
            this.lb_numOfDayRent = new System.Windows.Forms.Label();
            this.numeric_daysCount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_cars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_daysCount)).BeginInit();
            this.SuspendLayout();
            // 
            // chb_available
            // 
            this.chb_available.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.chb_available.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.chb_available.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chb_available.FillColor = System.Drawing.Color.White;
            this.chb_available.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.chb_available.ForeColor = System.Drawing.Color.White;
            this.chb_available.Location = new System.Drawing.Point(12, 12);
            this.chb_available.Name = "chb_available";
            this.chb_available.Size = new System.Drawing.Size(96, 23);
            this.chb_available.TabIndex = 0;
            this.chb_available.Text = "Available";
            // 
            // chb_sportCoupe
            // 
            this.chb_sportCoupe.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.chb_sportCoupe.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.chb_sportCoupe.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chb_sportCoupe.FillColor = System.Drawing.Color.White;
            this.chb_sportCoupe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.chb_sportCoupe.ForeColor = System.Drawing.Color.White;
            this.chb_sportCoupe.Location = new System.Drawing.Point(12, 66);
            this.chb_sportCoupe.Name = "chb_sportCoupe";
            this.chb_sportCoupe.Size = new System.Drawing.Size(117, 23);
            this.chb_sportCoupe.TabIndex = 2;
            this.chb_sportCoupe.Text = "Sport coupe";
            // 
            // chb_suv
            // 
            this.chb_suv.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.chb_suv.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.chb_suv.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chb_suv.FillColor = System.Drawing.Color.White;
            this.chb_suv.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.chb_suv.ForeColor = System.Drawing.Color.White;
            this.chb_suv.Location = new System.Drawing.Point(12, 116);
            this.chb_suv.Name = "chb_suv";
            this.chb_suv.Size = new System.Drawing.Size(60, 23);
            this.chb_suv.TabIndex = 3;
            this.chb_suv.Text = "SUV";
            // 
            // chb_stationWagon
            // 
            this.chb_stationWagon.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.chb_stationWagon.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.chb_stationWagon.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chb_stationWagon.FillColor = System.Drawing.Color.White;
            this.chb_stationWagon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.chb_stationWagon.ForeColor = System.Drawing.Color.White;
            this.chb_stationWagon.Location = new System.Drawing.Point(12, 166);
            this.chb_stationWagon.Name = "chb_stationWagon";
            this.chb_stationWagon.Size = new System.Drawing.Size(134, 23);
            this.chb_stationWagon.TabIndex = 4;
            this.chb_stationWagon.Text = "Station wagon";
            // 
            // chb_minivan
            // 
            this.chb_minivan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.chb_minivan.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.chb_minivan.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chb_minivan.FillColor = System.Drawing.Color.White;
            this.chb_minivan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.chb_minivan.ForeColor = System.Drawing.Color.White;
            this.chb_minivan.Location = new System.Drawing.Point(12, 216);
            this.chb_minivan.Name = "chb_minivan";
            this.chb_minivan.Size = new System.Drawing.Size(89, 23);
            this.chb_minivan.TabIndex = 5;
            this.chb_minivan.Text = "Minivan";
            // 
            // chb_electricCar
            // 
            this.chb_electricCar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.chb_electricCar.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.chb_electricCar.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chb_electricCar.FillColor = System.Drawing.Color.White;
            this.chb_electricCar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.chb_electricCar.ForeColor = System.Drawing.Color.White;
            this.chb_electricCar.Location = new System.Drawing.Point(12, 266);
            this.chb_electricCar.Name = "chb_electricCar";
            this.chb_electricCar.Size = new System.Drawing.Size(108, 23);
            this.chb_electricCar.TabIndex = 6;
            this.chb_electricCar.Text = "Electric car";
            // 
            // chb_cabriolet
            // 
            this.chb_cabriolet.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.chb_cabriolet.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.chb_cabriolet.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chb_cabriolet.FillColor = System.Drawing.Color.White;
            this.chb_cabriolet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.chb_cabriolet.ForeColor = System.Drawing.Color.White;
            this.chb_cabriolet.Location = new System.Drawing.Point(12, 316);
            this.chb_cabriolet.Name = "chb_cabriolet";
            this.chb_cabriolet.Size = new System.Drawing.Size(96, 23);
            this.chb_cabriolet.TabIndex = 7;
            this.chb_cabriolet.Text = "Cabriolet";
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(249)))));
            this.gunaSeparator1.Location = new System.Drawing.Point(-1, 50);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(147, 10);
            this.gunaSeparator1.TabIndex = 9;
            // 
            // bt_find
            // 
            this.bt_find.AnimationHoverSpeed = 0.07F;
            this.bt_find.AnimationSpeed = 0.03F;
            this.bt_find.BackColor = System.Drawing.Color.Transparent;
            this.bt_find.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.bt_find.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.bt_find.BorderColor = System.Drawing.Color.Black;
            this.bt_find.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bt_find.FocusedColor = System.Drawing.Color.Empty;
            this.bt_find.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bt_find.ForeColor = System.Drawing.Color.White;
            this.bt_find.Image = null;
            this.bt_find.ImageSize = new System.Drawing.Size(20, 20);
            this.bt_find.Location = new System.Drawing.Point(12, 447);
            this.bt_find.Name = "bt_find";
            this.bt_find.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.bt_find.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.bt_find.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_find.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_find.OnHoverImage = null;
            this.bt_find.OnPressedColor = System.Drawing.Color.Black;
            this.bt_find.Radius = 2;
            this.bt_find.Size = new System.Drawing.Size(134, 37);
            this.bt_find.TabIndex = 10;
            this.bt_find.Text = "Find";
            this.bt_find.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_find.Click += new System.EventHandler(this.bt_find_Click);
            // 
            // gunaSeparator2
            // 
            this.gunaSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(249)))));
            this.gunaSeparator2.Location = new System.Drawing.Point(-1, 395);
            this.gunaSeparator2.Name = "gunaSeparator2";
            this.gunaSeparator2.Size = new System.Drawing.Size(147, 10);
            this.gunaSeparator2.TabIndex = 11;
            // 
            // bt_rent
            // 
            this.bt_rent.AnimationHoverSpeed = 0.07F;
            this.bt_rent.AnimationSpeed = 0.03F;
            this.bt_rent.BackColor = System.Drawing.Color.Transparent;
            this.bt_rent.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.bt_rent.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.bt_rent.BorderColor = System.Drawing.Color.Black;
            this.bt_rent.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bt_rent.FocusedColor = System.Drawing.Color.Empty;
            this.bt_rent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bt_rent.ForeColor = System.Drawing.Color.White;
            this.bt_rent.Image = null;
            this.bt_rent.ImageSize = new System.Drawing.Size(20, 20);
            this.bt_rent.Location = new System.Drawing.Point(689, 447);
            this.bt_rent.Name = "bt_rent";
            this.bt_rent.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.bt_rent.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.bt_rent.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_rent.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_rent.OnHoverImage = null;
            this.bt_rent.OnPressedColor = System.Drawing.Color.Black;
            this.bt_rent.Radius = 2;
            this.bt_rent.Size = new System.Drawing.Size(134, 37);
            this.bt_rent.TabIndex = 12;
            this.bt_rent.Text = "Rent";
            this.bt_rent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_rent.Click += new System.EventHandler(this.bt_rent_Click);
            // 
            // DataGrid_cars
            // 
            this.DataGrid_cars.AllowUserToAddRows = false;
            this.DataGrid_cars.AllowUserToDeleteRows = false;
            this.DataGrid_cars.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGrid_cars.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_cars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_cars.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(4)))), ((int)(((byte)(52)))));
            this.DataGrid_cars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_cars.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGrid_cars.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_cars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_cars.ColumnHeadersHeight = 32;
            this.DataGrid_cars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGrid_cars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Available,
            this.AvailableFrom,
            this.PricePerDay,
            this.Brand,
            this.Model,
            this.LicensePlate,
            this.Type});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_cars.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid_cars.EnableHeadersVisualStyles = false;
            this.DataGrid_cars.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.DataGrid_cars.Location = new System.Drawing.Point(152, 0);
            this.DataGrid_cars.MultiSelect = false;
            this.DataGrid_cars.Name = "DataGrid_cars";
            this.DataGrid_cars.ReadOnly = true;
            this.DataGrid_cars.RowHeadersVisible = false;
            this.DataGrid_cars.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(4)))), ((int)(((byte)(52)))));
            this.DataGrid_cars.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.DataGrid_cars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_cars.Size = new System.Drawing.Size(751, 405);
            this.DataGrid_cars.TabIndex = 13;
            this.DataGrid_cars.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DataGrid_cars.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid_cars.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGrid_cars.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGrid_cars.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGrid_cars.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGrid_cars.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(4)))), ((int)(((byte)(52)))));
            this.DataGrid_cars.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.DataGrid_cars.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(60)))));
            this.DataGrid_cars.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGrid_cars.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataGrid_cars.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGrid_cars.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGrid_cars.ThemeStyle.HeaderStyle.Height = 32;
            this.DataGrid_cars.ThemeStyle.ReadOnly = true;
            this.DataGrid_cars.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.DataGrid_cars.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGrid_cars.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.DataGrid_cars.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.DataGrid_cars.ThemeStyle.RowsStyle.Height = 22;
            this.DataGrid_cars.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.DataGrid_cars.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // Available
            // 
            this.Available.HeaderText = "Available";
            this.Available.Name = "Available";
            this.Available.ReadOnly = true;
            // 
            // AvailableFrom
            // 
            this.AvailableFrom.HeaderText = "Available from";
            this.AvailableFrom.Name = "AvailableFrom";
            this.AvailableFrom.ReadOnly = true;
            // 
            // PricePerDay
            // 
            this.PricePerDay.HeaderText = "Price per day";
            this.PricePerDay.Name = "PricePerDay";
            this.PricePerDay.ReadOnly = true;
            // 
            // Brand
            // 
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // LicensePlate
            // 
            this.LicensePlate.HeaderText = "License plate";
            this.LicensePlate.Name = "LicensePlate";
            this.LicensePlate.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // chb_sedan
            // 
            this.chb_sedan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.chb_sedan.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.chb_sedan.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chb_sedan.FillColor = System.Drawing.Color.White;
            this.chb_sedan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.chb_sedan.ForeColor = System.Drawing.Color.White;
            this.chb_sedan.Location = new System.Drawing.Point(12, 366);
            this.chb_sedan.Name = "chb_sedan";
            this.chb_sedan.Size = new System.Drawing.Size(74, 23);
            this.chb_sedan.TabIndex = 14;
            this.chb_sedan.Text = "Sedan";
            // 
            // lb_numOfDayRent
            // 
            this.lb_numOfDayRent.AutoSize = true;
            this.lb_numOfDayRent.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_numOfDayRent.ForeColor = System.Drawing.Color.White;
            this.lb_numOfDayRent.Location = new System.Drawing.Point(242, 447);
            this.lb_numOfDayRent.Name = "lb_numOfDayRent";
            this.lb_numOfDayRent.Size = new System.Drawing.Size(248, 28);
            this.lb_numOfDayRent.TabIndex = 15;
            this.lb_numOfDayRent.Text = "Number of days for rent:";
            // 
            // numeric_daysCount
            // 
            this.numeric_daysCount.BackColor = System.Drawing.Color.Transparent;
            this.numeric_daysCount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.numeric_daysCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numeric_daysCount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numeric_daysCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numeric_daysCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numeric_daysCount.DisabledState.Parent = this.numeric_daysCount;
            this.numeric_daysCount.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numeric_daysCount.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numeric_daysCount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.numeric_daysCount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numeric_daysCount.FocusedState.Parent = this.numeric_daysCount;
            this.numeric_daysCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.numeric_daysCount.ForeColor = System.Drawing.Color.White;
            this.numeric_daysCount.Location = new System.Drawing.Point(529, 447);
            this.numeric_daysCount.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numeric_daysCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_daysCount.Name = "numeric_daysCount";
            this.numeric_daysCount.ShadowDecoration.Parent = this.numeric_daysCount;
            this.numeric_daysCount.Size = new System.Drawing.Size(100, 37);
            this.numeric_daysCount.TabIndex = 29;
            this.numeric_daysCount.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.numeric_daysCount.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(249)))));
            this.numeric_daysCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RentCarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(4)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(904, 531);
            this.Controls.Add(this.numeric_daysCount);
            this.Controls.Add(this.lb_numOfDayRent);
            this.Controls.Add(this.chb_sedan);
            this.Controls.Add(this.DataGrid_cars);
            this.Controls.Add(this.bt_rent);
            this.Controls.Add(this.gunaSeparator2);
            this.Controls.Add(this.bt_find);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.chb_cabriolet);
            this.Controls.Add(this.chb_electricCar);
            this.Controls.Add(this.chb_minivan);
            this.Controls.Add(this.chb_stationWagon);
            this.Controls.Add(this.chb_suv);
            this.Controls.Add(this.chb_sportCoupe);
            this.Controls.Add(this.chb_available);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RentCarsForm";
            this.Text = "Cars";
            this.Load += new System.EventHandler(this.RentCarsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_cars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_daysCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaCheckBox chb_available;
        private Guna.UI.WinForms.GunaCheckBox chb_sportCoupe;
        private Guna.UI.WinForms.GunaCheckBox chb_suv;
        private Guna.UI.WinForms.GunaCheckBox chb_stationWagon;
        private Guna.UI.WinForms.GunaCheckBox chb_minivan;
        private Guna.UI.WinForms.GunaCheckBox chb_electricCar;
        private Guna.UI.WinForms.GunaCheckBox chb_cabriolet;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaGradientButton bt_find;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator2;
        private Guna.UI.WinForms.GunaGradientButton bt_rent;
        private Guna.UI.WinForms.GunaDataGridView DataGrid_cars;
        private System.Windows.Forms.DataGridViewTextBoxColumn Available;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicensePlate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private Guna.UI.WinForms.GunaCheckBox chb_sedan;
        private System.Windows.Forms.Label lb_numOfDayRent;
        private Guna.UI2.WinForms.Guna2NumericUpDown numeric_daysCount;
    }
}