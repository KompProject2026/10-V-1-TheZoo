namespace TheZoo
{
    partial class AnimalEditForm
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
            this.lblSpecies = new System.Windows.Forms.Label();
            this.txtSpecies = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblBirthYear = new System.Windows.Forms.Label();
            this.nudBirthYear = new System.Windows.Forms.NumericUpDown();
            this.lblDailyFood = new System.Windows.Forms.Label();
            this.nudDailyFood = new System.Windows.Forms.NumericUpDown();
            this.lblFoodPrice = new System.Windows.Forms.Label();
            this.nudFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.lblZoo = new System.Windows.Forms.Label();
            this.cmbZoo = new System.Windows.Forms.ComboBox();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.picAnimal = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirthYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDailyFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFoodPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Location = new System.Drawing.Point(17, 54);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(48, 13);
            this.lblSpecies.TabIndex = 2;
            this.lblSpecies.Text = "Species:";
            // 
            // txtSpecies
            // 
            this.txtSpecies.Location = new System.Drawing.Point(130, 51);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.Size = new System.Drawing.Size(200, 20);
            this.txtSpecies.TabIndex = 3;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(23, 85);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(35, 13);
            this.lblClass.TabIndex = 4;
            this.lblClass.Text = "Class:";
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Items.AddRange(new object[] {
            "Mammal",
            "Bird",
            "Reptile",
            "Fish",
            "Amphibian"});
            this.cmbClass.Location = new System.Drawing.Point(131, 77);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(200, 21);
            this.cmbClass.TabIndex = 5;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(20, 115);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender:";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(131, 104);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(200, 21);
            this.cmbGender.TabIndex = 7;
            // 
            // lblBirthYear
            // 
            this.lblBirthYear.AutoSize = true;
            this.lblBirthYear.Location = new System.Drawing.Point(23, 145);
            this.lblBirthYear.Name = "lblBirthYear";
            this.lblBirthYear.Size = new System.Drawing.Size(54, 13);
            this.lblBirthYear.TabIndex = 8;
            this.lblBirthYear.Text = "Birth year:";
            // 
            // nudBirthYear
            // 
            this.nudBirthYear.Location = new System.Drawing.Point(130, 134);
            this.nudBirthYear.Maximum = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.nudBirthYear.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.nudBirthYear.Name = "nudBirthYear";
            this.nudBirthYear.Size = new System.Drawing.Size(100, 20);
            this.nudBirthYear.TabIndex = 9;
            this.nudBirthYear.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // lblDailyFood
            // 
            this.lblDailyFood.AutoSize = true;
            this.lblDailyFood.Location = new System.Drawing.Point(17, 175);
            this.lblDailyFood.Name = "lblDailyFood";
            this.lblDailyFood.Size = new System.Drawing.Size(78, 13);
            this.lblDailyFood.TabIndex = 10;
            this.lblDailyFood.Text = "Daily food (kg):";
            // 
            // nudDailyFood
            // 
            this.nudDailyFood.DecimalPlaces = 2;
            this.nudDailyFood.Location = new System.Drawing.Point(130, 164);
            this.nudDailyFood.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudDailyFood.Name = "nudDailyFood";
            this.nudDailyFood.Size = new System.Drawing.Size(100, 20);
            this.nudDailyFood.TabIndex = 11;
            this.nudDailyFood.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblFoodPrice
            // 
            this.lblFoodPrice.AutoSize = true;
            this.lblFoodPrice.Location = new System.Drawing.Point(12, 205);
            this.lblFoodPrice.Name = "lblFoodPrice";
            this.lblFoodPrice.Size = new System.Drawing.Size(99, 13);
            this.lblFoodPrice.TabIndex = 12;
            this.lblFoodPrice.Text = "Food price (per kg):";
            // 
            // nudFoodPrice
            // 
            this.nudFoodPrice.DecimalPlaces = 2;
            this.nudFoodPrice.Location = new System.Drawing.Point(130, 206);
            this.nudFoodPrice.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudFoodPrice.Name = "nudFoodPrice";
            this.nudFoodPrice.Size = new System.Drawing.Size(100, 20);
            this.nudFoodPrice.TabIndex = 13;
            // 
            // lblZoo
            // 
            this.lblZoo.AutoSize = true;
            this.lblZoo.Location = new System.Drawing.Point(17, 235);
            this.lblZoo.Name = "lblZoo";
            this.lblZoo.Size = new System.Drawing.Size(29, 13);
            this.lblZoo.TabIndex = 14;
            this.lblZoo.Text = "Zoo:";
            // 
            // cmbZoo
            // 
            this.cmbZoo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZoo.FormattingEnabled = true;
            this.cmbZoo.Location = new System.Drawing.Point(130, 232);
            this.cmbZoo.Name = "cmbZoo";
            this.cmbZoo.Size = new System.Drawing.Size(200, 21);
            this.cmbZoo.TabIndex = 15;
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Location = new System.Drawing.Point(12, 269);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(38, 13);
            this.lblPhoto.TabIndex = 16;
            this.lblPhoto.Text = "Photo:";
            // 
            // picAnimal
            // 
            this.picAnimal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnimal.Location = new System.Drawing.Point(15, 285);
            this.picAnimal.Name = "picAnimal";
            this.picAnimal.Size = new System.Drawing.Size(130, 90);
            this.picAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnimal.TabIndex = 17;
            this.picAnimal.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(12, 381);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(80, 23);
            this.btnBrowse.TabIndex = 18;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(151, 372);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(101, 41);
            this.btnOK.TabIndex = 19;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(255, 372);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 41);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AnimalEditForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(354, 425);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picAnimal);
            this.Controls.Add(this.lblPhoto);
            this.Controls.Add(this.cmbZoo);
            this.Controls.Add(this.lblZoo);
            this.Controls.Add(this.nudFoodPrice);
            this.Controls.Add(this.lblFoodPrice);
            this.Controls.Add(this.nudDailyFood);
            this.Controls.Add(this.lblDailyFood);
            this.Controls.Add(this.nudBirthYear);
            this.Controls.Add(this.lblBirthYear);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.txtSpecies);
            this.Controls.Add(this.lblSpecies);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnimalEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Animal";
            this.Load += new System.EventHandler(this.AnimalEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBirthYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDailyFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFoodPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblBirthYear;
        private System.Windows.Forms.NumericUpDown nudBirthYear;
        private System.Windows.Forms.Label lblDailyFood;
        private System.Windows.Forms.NumericUpDown nudDailyFood;
        private System.Windows.Forms.Label lblFoodPrice;
        private System.Windows.Forms.NumericUpDown nudFoodPrice;
        private System.Windows.Forms.Label lblZoo;
        private System.Windows.Forms.ComboBox cmbZoo;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.PictureBox picAnimal;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}
