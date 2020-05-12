namespace RentalService
{
    partial class ReplishBalanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplishBalanceForm));
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_cacneclChanges = new Guna.UI.WinForms.GunaGradientButton();
            this.bt_chngEmail = new Guna.UI.WinForms.GunaGradientButton();
            this.numeric_ammount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbox_cardNumber = new Guna.UI.WinForms.GunaTextBox();
            this.txtbox_cardMM = new Guna.UI.WinForms.GunaTextBox();
            this.txtbox_cardYY = new Guna.UI.WinForms.GunaTextBox();
            this.txtbox_cardCVV2_CVC2 = new Guna.UI.WinForms.GunaTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_ammount)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::RentalService.Properties.Resources.creditcardtopayment1;
            this.gunaPictureBox1.Location = new System.Drawing.Point(44, 180);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(510, 242);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(313, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Replenishment of the balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(80, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Card number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(80, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Expiration date MM/YY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(421, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "CVV2/CVC2";
            // 
            // bt_cacneclChanges
            // 
            this.bt_cacneclChanges.AnimationHoverSpeed = 0.07F;
            this.bt_cacneclChanges.AnimationSpeed = 0.03F;
            this.bt_cacneclChanges.BackColor = System.Drawing.Color.Transparent;
            this.bt_cacneclChanges.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.bt_cacneclChanges.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.bt_cacneclChanges.BorderColor = System.Drawing.Color.Black;
            this.bt_cacneclChanges.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bt_cacneclChanges.FocusedColor = System.Drawing.Color.Empty;
            this.bt_cacneclChanges.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bt_cacneclChanges.ForeColor = System.Drawing.Color.White;
            this.bt_cacneclChanges.Image = null;
            this.bt_cacneclChanges.ImageSize = new System.Drawing.Size(20, 20);
            this.bt_cacneclChanges.Location = new System.Drawing.Point(617, 457);
            this.bt_cacneclChanges.Name = "bt_cacneclChanges";
            this.bt_cacneclChanges.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.bt_cacneclChanges.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.bt_cacneclChanges.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_cacneclChanges.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_cacneclChanges.OnHoverImage = null;
            this.bt_cacneclChanges.OnPressedColor = System.Drawing.Color.Black;
            this.bt_cacneclChanges.Radius = 2;
            this.bt_cacneclChanges.Size = new System.Drawing.Size(248, 37);
            this.bt_cacneclChanges.TabIndex = 25;
            this.bt_cacneclChanges.Text = "Cancel";
            this.bt_cacneclChanges.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_cacneclChanges.Click += new System.EventHandler(this.bt_cacneclChanges_Click);
            // 
            // bt_chngEmail
            // 
            this.bt_chngEmail.AnimationHoverSpeed = 0.07F;
            this.bt_chngEmail.AnimationSpeed = 0.03F;
            this.bt_chngEmail.BackColor = System.Drawing.Color.Transparent;
            this.bt_chngEmail.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.bt_chngEmail.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.bt_chngEmail.BorderColor = System.Drawing.Color.Black;
            this.bt_chngEmail.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bt_chngEmail.FocusedColor = System.Drawing.Color.Empty;
            this.bt_chngEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bt_chngEmail.ForeColor = System.Drawing.Color.White;
            this.bt_chngEmail.Image = null;
            this.bt_chngEmail.ImageSize = new System.Drawing.Size(20, 20);
            this.bt_chngEmail.Location = new System.Drawing.Point(617, 300);
            this.bt_chngEmail.Name = "bt_chngEmail";
            this.bt_chngEmail.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.bt_chngEmail.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.bt_chngEmail.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_chngEmail.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_chngEmail.OnHoverImage = null;
            this.bt_chngEmail.OnPressedColor = System.Drawing.Color.Black;
            this.bt_chngEmail.Radius = 2;
            this.bt_chngEmail.Size = new System.Drawing.Size(248, 37);
            this.bt_chngEmail.TabIndex = 24;
            this.bt_chngEmail.Text = "Replish balance";
            this.bt_chngEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_chngEmail.Click += new System.EventHandler(this.bt_chngEmail_Click);
            // 
            // numeric_ammount
            // 
            this.numeric_ammount.BackColor = System.Drawing.Color.Transparent;
            this.numeric_ammount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.numeric_ammount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numeric_ammount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numeric_ammount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numeric_ammount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numeric_ammount.DisabledState.Parent = this.numeric_ammount;
            this.numeric_ammount.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numeric_ammount.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numeric_ammount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.numeric_ammount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numeric_ammount.FocusedState.Parent = this.numeric_ammount;
            this.numeric_ammount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.numeric_ammount.ForeColor = System.Drawing.Color.White;
            this.numeric_ammount.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numeric_ammount.Location = new System.Drawing.Point(617, 139);
            this.numeric_ammount.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numeric_ammount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_ammount.Name = "numeric_ammount";
            this.numeric_ammount.ShadowDecoration.Parent = this.numeric_ammount;
            this.numeric_ammount.Size = new System.Drawing.Size(248, 47);
            this.numeric_ammount.TabIndex = 28;
            this.numeric_ammount.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.numeric_ammount.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(249)))));
            this.numeric_ammount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(178)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(613, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Amount to be paid";
            // 
            // txtbox_cardNumber
            // 
            this.txtbox_cardNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtbox_cardNumber.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.txtbox_cardNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.txtbox_cardNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_cardNumber.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.txtbox_cardNumber.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.txtbox_cardNumber.FocusedForeColor = System.Drawing.Color.White;
            this.txtbox_cardNumber.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtbox_cardNumber.ForeColor = System.Drawing.Color.White;
            this.txtbox_cardNumber.Location = new System.Drawing.Point(84, 226);
            this.txtbox_cardNumber.MaxLength = 19;
            this.txtbox_cardNumber.Name = "txtbox_cardNumber";
            this.txtbox_cardNumber.PasswordChar = '\0';
            this.txtbox_cardNumber.Radius = 2;
            this.txtbox_cardNumber.SelectedText = "";
            this.txtbox_cardNumber.Size = new System.Drawing.Size(307, 31);
            this.txtbox_cardNumber.TabIndex = 30;
            this.txtbox_cardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_carBrand_KeyPress);
            // 
            // txtbox_cardMM
            // 
            this.txtbox_cardMM.BackColor = System.Drawing.Color.Transparent;
            this.txtbox_cardMM.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.txtbox_cardMM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.txtbox_cardMM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_cardMM.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.txtbox_cardMM.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.txtbox_cardMM.FocusedForeColor = System.Drawing.Color.White;
            this.txtbox_cardMM.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtbox_cardMM.ForeColor = System.Drawing.Color.White;
            this.txtbox_cardMM.Location = new System.Drawing.Point(84, 294);
            this.txtbox_cardMM.MaxLength = 2;
            this.txtbox_cardMM.Name = "txtbox_cardMM";
            this.txtbox_cardMM.PasswordChar = '\0';
            this.txtbox_cardMM.Radius = 2;
            this.txtbox_cardMM.SelectedText = "";
            this.txtbox_cardMM.Size = new System.Drawing.Size(42, 31);
            this.txtbox_cardMM.TabIndex = 31;
            this.txtbox_cardMM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_cardMM_KeyPress);
            // 
            // txtbox_cardYY
            // 
            this.txtbox_cardYY.BackColor = System.Drawing.Color.Transparent;
            this.txtbox_cardYY.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.txtbox_cardYY.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.txtbox_cardYY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_cardYY.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.txtbox_cardYY.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.txtbox_cardYY.FocusedForeColor = System.Drawing.Color.White;
            this.txtbox_cardYY.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtbox_cardYY.ForeColor = System.Drawing.Color.White;
            this.txtbox_cardYY.Location = new System.Drawing.Point(131, 294);
            this.txtbox_cardYY.MaxLength = 2;
            this.txtbox_cardYY.Name = "txtbox_cardYY";
            this.txtbox_cardYY.PasswordChar = '\0';
            this.txtbox_cardYY.Radius = 2;
            this.txtbox_cardYY.SelectedText = "";
            this.txtbox_cardYY.Size = new System.Drawing.Size(42, 31);
            this.txtbox_cardYY.TabIndex = 32;
            this.txtbox_cardYY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_cardYY_KeyPress);
            // 
            // txtbox_cardCVV2_CVC2
            // 
            this.txtbox_cardCVV2_CVC2.BackColor = System.Drawing.Color.Transparent;
            this.txtbox_cardCVV2_CVC2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.txtbox_cardCVV2_CVC2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.txtbox_cardCVV2_CVC2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_cardCVV2_CVC2.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.txtbox_cardCVV2_CVC2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.txtbox_cardCVV2_CVC2.FocusedForeColor = System.Drawing.Color.White;
            this.txtbox_cardCVV2_CVC2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtbox_cardCVV2_CVC2.ForeColor = System.Drawing.Color.White;
            this.txtbox_cardCVV2_CVC2.Location = new System.Drawing.Point(423, 323);
            this.txtbox_cardCVV2_CVC2.MaxLength = 3;
            this.txtbox_cardCVV2_CVC2.Name = "txtbox_cardCVV2_CVC2";
            this.txtbox_cardCVV2_CVC2.PasswordChar = '\0';
            this.txtbox_cardCVV2_CVC2.Radius = 2;
            this.txtbox_cardCVV2_CVC2.SelectedText = "";
            this.txtbox_cardCVV2_CVC2.Size = new System.Drawing.Size(81, 31);
            this.txtbox_cardCVV2_CVC2.TabIndex = 33;
            this.txtbox_cardCVV2_CVC2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_cardCVV2_CVC2_KeyPress);
            // 
            // ReplishBalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(4)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(904, 531);
            this.Controls.Add(this.txtbox_cardCVV2_CVC2);
            this.Controls.Add(this.txtbox_cardYY);
            this.Controls.Add(this.txtbox_cardMM);
            this.Controls.Add(this.txtbox_cardNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numeric_ammount);
            this.Controls.Add(this.bt_cacneclChanges);
            this.Controls.Add(this.bt_chngEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReplishBalanceForm";
            this.Text = "ReplishBalanceForm";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_ammount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaGradientButton bt_cacneclChanges;
        private Guna.UI.WinForms.GunaGradientButton bt_chngEmail;
        private Guna.UI2.WinForms.Guna2NumericUpDown numeric_ammount;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtbox_cardNumber;
        private Guna.UI.WinForms.GunaTextBox txtbox_cardMM;
        private Guna.UI.WinForms.GunaTextBox txtbox_cardYY;
        private Guna.UI.WinForms.GunaTextBox txtbox_cardCVV2_CVC2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}