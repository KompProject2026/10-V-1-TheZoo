namespace TheZoo
{
    partial class ZooEditForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblOpened = new System.Windows.Forms.Label();
            this.nudOpened = new System.Windows.Forms.NumericUpDown();
            this.lblArea = new System.Windows.Forms.Label();
            this.nudArea = new System.Windows.Forms.NumericUpDown();
            this.chkAquarium = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudOpened)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArea)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(28, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(28, 50);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(130, 43);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(200, 20);
            this.txtCity.TabIndex = 3;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(28, 76);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(46, 13);
            this.lblCountry.TabIndex = 4;
            this.lblCountry.Text = "Country:";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(130, 69);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(200, 20);
            this.txtCountry.TabIndex = 5;
            this.txtCountry.Text = "Ukraine";
            // 
            // lblOpened
            // 
            this.lblOpened.AutoSize = true;
            this.lblOpened.Location = new System.Drawing.Point(28, 105);
            this.lblOpened.Name = "lblOpened";
            this.lblOpened.Size = new System.Drawing.Size(71, 13);
            this.lblOpened.TabIndex = 6;
            this.lblOpened.Text = "Opened year:";
            // 
            // nudOpened
            // 
            this.nudOpened.Location = new System.Drawing.Point(130, 103);
            this.nudOpened.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudOpened.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.nudOpened.Name = "nudOpened";
            this.nudOpened.Size = new System.Drawing.Size(100, 20);
            this.nudOpened.TabIndex = 7;
            this.nudOpened.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(28, 135);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(53, 13);
            this.lblArea.TabIndex = 8;
            this.lblArea.Text = "Area (ha):";
            // 
            // nudArea
            // 
            this.nudArea.DecimalPlaces = 2;
            this.nudArea.Location = new System.Drawing.Point(130, 133);
            this.nudArea.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudArea.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudArea.Name = "nudArea";
            this.nudArea.Size = new System.Drawing.Size(100, 20);
            this.nudArea.TabIndex = 9;
            this.nudArea.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkAquarium
            // 
            this.chkAquarium.AutoSize = true;
            this.chkAquarium.Location = new System.Drawing.Point(130, 159);
            this.chkAquarium.Name = "chkAquarium";
            this.chkAquarium.Size = new System.Drawing.Size(91, 17);
            this.chkAquarium.TabIndex = 10;
            this.chkAquarium.Text = "Has aquarium";
            this.chkAquarium.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(165, 201);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(246, 201);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ZooEditForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(354, 245);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkAquarium);
            this.Controls.Add(this.nudArea);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.nudOpened);
            this.Controls.Add(this.lblOpened);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ZooEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zoo";
            this.Load += new System.EventHandler(this.ZooEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudOpened)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblOpened;
        private System.Windows.Forms.NumericUpDown nudOpened;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.NumericUpDown nudArea;
        private System.Windows.Forms.CheckBox chkAquarium;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}
