namespace RentalService
{
    partial class AdminCarsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCarsMenu));
            this.chb_sedan = new Guna.UI.WinForms.GunaCheckBox();
            this.DataGrid_cars = new Guna.UI.WinForms.GunaDataGridView();
            this.Available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicensePlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaSeparator2 = new Guna.UI.WinForms.GunaSeparator();
            this.bt_find = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.chb_cabriolet = new Guna.UI.WinForms.GunaCheckBox();
            this.chb_electricCar = new Guna.UI.WinForms.GunaCheckBox();
            this.chb_minivan = new Guna.UI.WinForms.GunaCheckBox();
            this.chb_stationWagon = new Guna.UI.WinForms.GunaCheckBox();
            this.chb_suv = new Guna.UI.WinForms.GunaCheckBox();
            this.chb_sportCoupe = new Guna.UI.WinForms.GunaCheckBox();
            this.chb_available = new Guna.UI.WinForms.GunaCheckBox();
            this.bt_remove = new Guna.UI.WinForms.GunaGradientButton();
            this.bt_edit = new Guna.UI.WinForms.GunaGradientButton();
            this.pnChildForm = new Guna.UI.WinForms.GunaPanel();
            this.pnCarsMenu = new Guna.UI.WinForms.GunaPanel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_cars)).BeginInit();
            this.pnCarsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // chb_sedan
            // 
            this.chb_sedan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.chb_sedan.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.chb_sedan.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chb_sedan.FillColor = System.Drawing.Color.White;
            this.chb_sedan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.chb_sedan.ForeColor = System.Drawing.Color.White;
            this.chb_sedan.Location = new System.Drawing.Point(12, 370);
            this.chb_sedan.Name = "chb_sedan";
            this.chb_sedan.Size = new System.Drawing.Size(74, 23);
            this.chb_sedan.TabIndex = 42;
            this.chb_sedan.Text = "Sedan";
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
            this.DataGrid_cars.Location = new System.Drawing.Point(150, 0);
            this.DataGrid_cars.MultiSelect = false;
            this.DataGrid_cars.Name = "DataGrid_cars";
            this.DataGrid_cars.ReadOnly = true;
            this.DataGrid_cars.RowHeadersVisible = false;
            this.DataGrid_cars.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(4)))), ((int)(((byte)(52)))));
            this.DataGrid_cars.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.DataGrid_cars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_cars.Size = new System.Drawing.Size(751, 405);
            this.DataGrid_cars.TabIndex = 41;
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
            // gunaSeparator2
            // 
            this.gunaSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(249)))));
            this.gunaSeparator2.Location = new System.Drawing.Point(-1, 399);
            this.gunaSeparator2.Name = "gunaSeparator2";
            this.gunaSeparator2.Size = new System.Drawing.Size(147, 10);
            this.gunaSeparator2.TabIndex = 39;
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
            this.bt_find.Location = new System.Drawing.Point(12, 454);
            this.bt_find.Name = "bt_find";
            this.bt_find.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.bt_find.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.bt_find.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_find.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_find.OnHoverImage = null;
            this.bt_find.OnPressedColor = System.Drawing.Color.Black;
            this.bt_find.Radius = 2;
            this.bt_find.Size = new System.Drawing.Size(134, 37);
            this.bt_find.TabIndex = 38;
            this.bt_find.Text = "Find";
            this.bt_find.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_find.Click += new System.EventHandler(this.bt_find_Click);
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(249)))));
            this.gunaSeparator1.Location = new System.Drawing.Point(-1, 54);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(147, 10);
            this.gunaSeparator1.TabIndex = 37;
            // 
            // chb_cabriolet
            // 
            this.chb_cabriolet.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.chb_cabriolet.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.chb_cabriolet.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chb_cabriolet.FillColor = System.Drawing.Color.White;
            this.chb_cabriolet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.chb_cabriolet.ForeColor = System.Drawing.Color.White;
            this.chb_cabriolet.Location = new System.Drawing.Point(12, 317);
            this.chb_cabriolet.Name = "chb_cabriolet";
            this.chb_cabriolet.Size = new System.Drawing.Size(96, 23);
            this.chb_cabriolet.TabIndex = 36;
            this.chb_cabriolet.Text = "Cabriolet";
            // 
            // chb_electricCar
            // 
            this.chb_electricCar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.chb_electricCar.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.chb_electricCar.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chb_electricCar.FillColor = System.Drawing.Color.White;
            this.chb_electricCar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.chb_electricCar.ForeColor = System.Drawing.Color.White;
            this.chb_electricCar.Location = new System.Drawing.Point(12, 268);
            this.chb_electricCar.Name = "chb_electricCar";
            this.chb_electricCar.Size = new System.Drawing.Size(108, 23);
            this.chb_electricCar.TabIndex = 35;
            this.chb_electricCar.Text = "Electric car";
            // 
            // chb_minivan
            // 
            this.chb_minivan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.chb_minivan.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.chb_minivan.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chb_minivan.FillColor = System.Drawing.Color.White;
            this.chb_minivan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.chb_minivan.ForeColor = System.Drawing.Color.White;
            this.chb_minivan.Location = new System.Drawing.Point(12, 220);
            this.chb_minivan.Name = "chb_minivan";
            this.chb_minivan.Size = new System.Drawing.Size(89, 23);
            this.chb_minivan.TabIndex = 34;
            this.chb_minivan.Text = "Minivan";
            // 
            // chb_stationWagon
            // 
            this.chb_stationWagon.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.chb_stationWagon.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.chb_stationWagon.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chb_stationWagon.FillColor = System.Drawing.Color.White;
            this.chb_stationWagon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.chb_stationWagon.ForeColor = System.Drawing.Color.White;
            this.chb_stationWagon.Location = new System.Drawing.Point(12, 168);
            this.chb_stationWagon.Name = "chb_stationWagon";
            this.chb_stationWagon.Size = new System.Drawing.Size(134, 23);
            this.chb_stationWagon.TabIndex = 33;
            this.chb_stationWagon.Text = "Station wagon";
            // 
            // chb_suv
            // 
            this.chb_suv.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.chb_suv.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.chb_suv.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chb_suv.FillColor = System.Drawing.Color.White;
            this.chb_suv.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.chb_suv.ForeColor = System.Drawing.Color.White;
            this.chb_suv.Location = new System.Drawing.Point(12, 118);
            this.chb_suv.Name = "chb_suv";
            this.chb_suv.Size = new System.Drawing.Size(60, 23);
            this.chb_suv.TabIndex = 32;
            this.chb_suv.Text = "SUV";
            // 
            // chb_sportCoupe
            // 
            this.chb_sportCoupe.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.chb_sportCoupe.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.chb_sportCoupe.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chb_sportCoupe.FillColor = System.Drawing.Color.White;
            this.chb_sportCoupe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.chb_sportCoupe.ForeColor = System.Drawing.Color.White;
            this.chb_sportCoupe.Location = new System.Drawing.Point(12, 70);
            this.chb_sportCoupe.Name = "chb_sportCoupe";
            this.chb_sportCoupe.Size = new System.Drawing.Size(117, 23);
            this.chb_sportCoupe.TabIndex = 31;
            this.chb_sportCoupe.Text = "Sport coupe";
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
            this.chb_available.TabIndex = 30;
            this.chb_available.Text = "Available";
            // 
            // bt_remove
            // 
            this.bt_remove.AnimationHoverSpeed = 0.07F;
            this.bt_remove.AnimationSpeed = 0.03F;
            this.bt_remove.BackColor = System.Drawing.Color.Transparent;
            this.bt_remove.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.bt_remove.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.bt_remove.BorderColor = System.Drawing.Color.Black;
            this.bt_remove.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bt_remove.FocusedColor = System.Drawing.Color.Empty;
            this.bt_remove.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bt_remove.ForeColor = System.Drawing.Color.White;
            this.bt_remove.Image = null;
            this.bt_remove.ImageSize = new System.Drawing.Size(20, 20);
            this.bt_remove.Location = new System.Drawing.Point(286, 454);
            this.bt_remove.Name = "bt_remove";
            this.bt_remove.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.bt_remove.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.bt_remove.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_remove.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_remove.OnHoverImage = null;
            this.bt_remove.OnPressedColor = System.Drawing.Color.Black;
            this.bt_remove.Radius = 2;
            this.bt_remove.Size = new System.Drawing.Size(134, 37);
            this.bt_remove.TabIndex = 43;
            this.bt_remove.Text = "Remove";
            this.bt_remove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_remove.Click += new System.EventHandler(this.bt_remove_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.AnimationHoverSpeed = 0.07F;
            this.bt_edit.AnimationSpeed = 0.03F;
            this.bt_edit.BackColor = System.Drawing.Color.Transparent;
            this.bt_edit.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.bt_edit.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.bt_edit.BorderColor = System.Drawing.Color.Black;
            this.bt_edit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bt_edit.FocusedColor = System.Drawing.Color.Empty;
            this.bt_edit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bt_edit.ForeColor = System.Drawing.Color.White;
            this.bt_edit.Image = null;
            this.bt_edit.ImageSize = new System.Drawing.Size(20, 20);
            this.bt_edit.Location = new System.Drawing.Point(572, 454);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.bt_edit.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.bt_edit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_edit.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_edit.OnHoverImage = null;
            this.bt_edit.OnPressedColor = System.Drawing.Color.Black;
            this.bt_edit.Radius = 2;
            this.bt_edit.Size = new System.Drawing.Size(134, 37);
            this.bt_edit.TabIndex = 44;
            this.bt_edit.Text = "Edit";
            this.bt_edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // pnChildForm
            // 
            this.pnChildForm.Location = new System.Drawing.Point(0, 0);
            this.pnChildForm.Name = "pnChildForm";
            this.pnChildForm.Size = new System.Drawing.Size(904, 531);
            this.pnChildForm.TabIndex = 45;
            // 
            // pnCarsMenu
            // 
            this.pnCarsMenu.Controls.Add(this.chb_suv);
            this.pnCarsMenu.Controls.Add(this.chb_stationWagon);
            this.pnCarsMenu.Controls.Add(this.chb_minivan);
            this.pnCarsMenu.Controls.Add(this.chb_electricCar);
            this.pnCarsMenu.Controls.Add(this.chb_cabriolet);
            this.pnCarsMenu.Controls.Add(this.chb_sedan);
            this.pnCarsMenu.Controls.Add(this.bt_edit);
            this.pnCarsMenu.Controls.Add(this.gunaSeparator2);
            this.pnCarsMenu.Controls.Add(this.chb_available);
            this.pnCarsMenu.Controls.Add(this.bt_remove);
            this.pnCarsMenu.Controls.Add(this.chb_sportCoupe);
            this.pnCarsMenu.Controls.Add(this.gunaSeparator1);
            this.pnCarsMenu.Controls.Add(this.DataGrid_cars);
            this.pnCarsMenu.Controls.Add(this.bt_find);
            this.pnCarsMenu.Location = new System.Drawing.Point(0, 0);
            this.pnCarsMenu.Name = "pnCarsMenu";
            this.pnCarsMenu.Size = new System.Drawing.Size(904, 531);
            this.pnCarsMenu.TabIndex = 46;
            // 
            // AdminCarsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(4)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(904, 531);
            this.Controls.Add(this.pnCarsMenu);
            this.Controls.Add(this.pnChildForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminCarsMenu";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_cars)).EndInit();
            this.pnCarsMenu.ResumeLayout(false);
            this.pnCarsMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaCheckBox chb_sedan;
        private Guna.UI.WinForms.GunaDataGridView DataGrid_cars;
        private System.Windows.Forms.DataGridViewTextBoxColumn Available;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicensePlate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator2;
        private Guna.UI.WinForms.GunaGradientButton bt_find;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaCheckBox chb_cabriolet;
        private Guna.UI.WinForms.GunaCheckBox chb_electricCar;
        private Guna.UI.WinForms.GunaCheckBox chb_minivan;
        private Guna.UI.WinForms.GunaCheckBox chb_stationWagon;
        private Guna.UI.WinForms.GunaCheckBox chb_suv;
        private Guna.UI.WinForms.GunaCheckBox chb_sportCoupe;
        private Guna.UI.WinForms.GunaCheckBox chb_available;
        private Guna.UI.WinForms.GunaGradientButton bt_remove;
        private Guna.UI.WinForms.GunaGradientButton bt_edit;
        private Guna.UI.WinForms.GunaPanel pnChildForm;
        private Guna.UI.WinForms.GunaPanel pnCarsMenu;
    }
}