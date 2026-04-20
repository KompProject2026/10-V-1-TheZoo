namespace TheZoo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dgvAnimals = new System.Windows.Forms.DataGridView();
            this.cmsAnimals = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddAnimal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditAnimal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteAnimal = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvZoos = new System.Windows.Forms.DataGridView();
            this.cmsZoos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddZoo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditZoo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteZoo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupFilter = new System.Windows.Forms.GroupBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.cmbZoo = new System.Windows.Forms.ComboBox();
            this.lblZoo = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.groupSort = new System.Windows.Forms.GroupBox();
            this.groupBoxFirst = new System.Windows.Forms.GroupBox();
            this.rbDesc1 = new System.Windows.Forms.RadioButton();
            this.rbAsc1 = new System.Windows.Forms.RadioButton();
            this.cmbSort1 = new System.Windows.Forms.ComboBox();
            this.groupBoxSecond = new System.Windows.Forms.GroupBox();
            this.rbDesc2 = new System.Windows.Forms.RadioButton();
            this.rbAsc2 = new System.Windows.Forms.RadioButton();
            this.cmbSort2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).BeginInit();
            this.cmsAnimals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZoos)).BeginInit();
            this.cmsZoos.SuspendLayout();
            this.groupFilter.SuspendLayout();
            this.groupSort.SuspendLayout();
            this.groupBoxFirst.SuspendLayout();
            this.groupBoxSecond.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAnimals
            // 
            this.dgvAnimals.AllowUserToAddRows = false;
            this.dgvAnimals.AllowUserToDeleteRows = false;
            this.dgvAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimals.ContextMenuStrip = this.cmsAnimals;
            this.dgvAnimals.Location = new System.Drawing.Point(12, 12);
            this.dgvAnimals.Name = "dgvAnimals";
            this.dgvAnimals.ReadOnly = true;
            this.dgvAnimals.Size = new System.Drawing.Size(874, 193);
            this.dgvAnimals.TabIndex = 0;
            // 
            // cmsAnimals
            // 
            this.cmsAnimals.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddAnimal,
            this.tsmiEditAnimal,
            this.tsmiDeleteAnimal});
            this.cmsAnimals.Name = "cmsAnimals";
            this.cmsAnimals.Size = new System.Drawing.Size(149, 70);
            // 
            // tsmiAddAnimal
            // 
            this.tsmiAddAnimal.Name = "tsmiAddAnimal";
            this.tsmiAddAnimal.Size = new System.Drawing.Size(148, 22);
            this.tsmiAddAnimal.Text = "Add Animal";
            this.tsmiAddAnimal.Click += new System.EventHandler(this.tsmiAddAnimal_Click);
            // 
            // tsmiEditAnimal
            // 
            this.tsmiEditAnimal.Name = "tsmiEditAnimal";
            this.tsmiEditAnimal.Size = new System.Drawing.Size(148, 22);
            this.tsmiEditAnimal.Text = "Edit Animal";
            this.tsmiEditAnimal.Click += new System.EventHandler(this.tsmiEditAnimal_Click);
            // 
            // tsmiDeleteAnimal
            // 
            this.tsmiDeleteAnimal.Name = "tsmiDeleteAnimal";
            this.tsmiDeleteAnimal.Size = new System.Drawing.Size(148, 22);
            this.tsmiDeleteAnimal.Text = "Delete Animal";
            this.tsmiDeleteAnimal.Click += new System.EventHandler(this.tsmiDeleteAnimal_Click);
            // 
            // dgvZoos
            // 
            this.dgvZoos.AllowUserToAddRows = false;
            this.dgvZoos.AllowUserToDeleteRows = false;
            this.dgvZoos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZoos.ContextMenuStrip = this.cmsZoos;
            this.dgvZoos.Location = new System.Drawing.Point(12, 260);
            this.dgvZoos.Name = "dgvZoos";
            this.dgvZoos.ReadOnly = true;
            this.dgvZoos.Size = new System.Drawing.Size(545, 190);
            this.dgvZoos.TabIndex = 1;
            // 
            // cmsZoos
            // 
            this.cmsZoos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddZoo,
            this.tsmiEditZoo,
            this.tsmiDeleteZoo});
            this.cmsZoos.Name = "cmsZoos";
            this.cmsZoos.Size = new System.Drawing.Size(132, 70);
            // 
            // tsmiAddZoo
            // 
            this.tsmiAddZoo.Name = "tsmiAddZoo";
            this.tsmiAddZoo.Size = new System.Drawing.Size(131, 22);
            this.tsmiAddZoo.Text = "Add Zoo";
            this.tsmiAddZoo.Click += new System.EventHandler(this.tsmiAddZoo_Click);
            // 
            // tsmiEditZoo
            // 
            this.tsmiEditZoo.Name = "tsmiEditZoo";
            this.tsmiEditZoo.Size = new System.Drawing.Size(131, 22);
            this.tsmiEditZoo.Text = "Edit Zoo";
            this.tsmiEditZoo.Click += new System.EventHandler(this.tsmiEditZoo_Click);
            // 
            // tsmiDeleteZoo
            // 
            this.tsmiDeleteZoo.Name = "tsmiDeleteZoo";
            this.tsmiDeleteZoo.Size = new System.Drawing.Size(131, 22);
            this.tsmiDeleteZoo.Text = "Delete Zoo";
            this.tsmiDeleteZoo.Click += new System.EventHandler(this.tsmiDeleteZoo_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(38, 221);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupFilter
            // 
            this.groupFilter.Controls.Add(this.btnShowAll);
            this.groupFilter.Controls.Add(this.btnApply);
            this.groupFilter.Controls.Add(this.cmbZoo);
            this.groupFilter.Controls.Add(this.lblZoo);
            this.groupFilter.Controls.Add(this.txtTo);
            this.groupFilter.Controls.Add(this.lblTo);
            this.groupFilter.Controls.Add(this.txtFrom);
            this.groupFilter.Controls.Add(this.lblFrom);
            this.groupFilter.Controls.Add(this.lblYear);
            this.groupFilter.Controls.Add(this.lblName);
            this.groupFilter.Controls.Add(this.tbxName);
            this.groupFilter.Location = new System.Drawing.Point(560, 250);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Size = new System.Drawing.Size(332, 130);
            this.groupFilter.TabIndex = 3;
            this.groupFilter.TabStop = false;
            this.groupFilter.Text = "Filter";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(87, 96);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 23);
            this.btnShowAll.TabIndex = 10;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(6, 96);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 9;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // cmbZoo
            // 
            this.cmbZoo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZoo.FormattingEnabled = true;
            this.cmbZoo.Location = new System.Drawing.Point(49, 71);
            this.cmbZoo.Name = "cmbZoo";
            this.cmbZoo.Size = new System.Drawing.Size(180, 21);
            this.cmbZoo.TabIndex = 8;
            // 
            // lblZoo
            // 
            this.lblZoo.AutoSize = true;
            this.lblZoo.Location = new System.Drawing.Point(12, 74);
            this.lblZoo.Name = "lblZoo";
            this.lblZoo.Size = new System.Drawing.Size(29, 13);
            this.lblZoo.TabIndex = 7;
            this.lblZoo.Text = "Zoo:";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(141, 46);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(50, 20);
            this.txtTo.TabIndex = 5;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(119, 49);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(16, 13);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "to";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(63, 46);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(50, 20);
            this.txtFrom.TabIndex = 3;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(3, 49);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(54, 13);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "Birth year:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(216, 45);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(0, 13);
            this.lblYear.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(50, 22);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(180, 20);
            this.tbxName.TabIndex = 1;
            // 
            // groupSort
            // 
            this.groupSort.Controls.Add(this.groupBoxFirst);
            this.groupSort.Controls.Add(this.groupBoxSecond);
            this.groupSort.Location = new System.Drawing.Point(560, 12);
            this.groupSort.Name = "groupSort";
            this.groupSort.Size = new System.Drawing.Size(332, 113);
            this.groupSort.TabIndex = 4;
            this.groupSort.TabStop = false;
            this.groupSort.Text = "Sort";
            // 
            // groupBoxFirst
            // 
            this.groupBoxFirst.Controls.Add(this.rbDesc1);
            this.groupBoxFirst.Controls.Add(this.rbAsc1);
            this.groupBoxFirst.Controls.Add(this.cmbSort1);
            this.groupBoxFirst.Location = new System.Drawing.Point(6, 12);
            this.groupBoxFirst.Name = "groupBoxFirst";
            this.groupBoxFirst.Size = new System.Drawing.Size(155, 95);
            this.groupBoxFirst.TabIndex = 0;
            this.groupBoxFirst.TabStop = false;
            this.groupBoxFirst.Text = "First by";
            // 
            // rbDesc1
            // 
            this.rbDesc1.AutoSize = true;
            this.rbDesc1.Location = new System.Drawing.Point(81, 46);
            this.rbDesc1.Name = "rbDesc1";
            this.rbDesc1.Size = new System.Drawing.Size(82, 17);
            this.rbDesc1.TabIndex = 2;
            this.rbDesc1.Text = "Descending";
            this.rbDesc1.UseVisualStyleBackColor = true;
            this.rbDesc1.CheckedChanged += new System.EventHandler(this.rbDesc1_CheckedChanged);
            // 
            // rbAsc1
            // 
            this.rbAsc1.AutoSize = true;
            this.rbAsc1.Checked = true;
            this.rbAsc1.Location = new System.Drawing.Point(9, 46);
            this.rbAsc1.Name = "rbAsc1";
            this.rbAsc1.Size = new System.Drawing.Size(75, 17);
            this.rbAsc1.TabIndex = 1;
            this.rbAsc1.TabStop = true;
            this.rbAsc1.Text = "Ascending";
            this.rbAsc1.UseVisualStyleBackColor = true;
            // 
            // cmbSort1
            // 
            this.cmbSort1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort1.FormattingEnabled = true;
            this.cmbSort1.Items.AddRange(new object[] {
            "Name",
            "Species",
            "Class",
            "Birth Year",
            "Daily Food (kg)"});
            this.cmbSort1.Location = new System.Drawing.Point(9, 19);
            this.cmbSort1.Name = "cmbSort1";
            this.cmbSort1.Size = new System.Drawing.Size(140, 21);
            this.cmbSort1.TabIndex = 0;
            this.cmbSort1.SelectedIndexChanged += new System.EventHandler(this.cmbSort1_SelectedIndexChanged);
            // 
            // groupBoxSecond
            // 
            this.groupBoxSecond.Controls.Add(this.rbDesc2);
            this.groupBoxSecond.Controls.Add(this.rbAsc2);
            this.groupBoxSecond.Controls.Add(this.cmbSort2);
            this.groupBoxSecond.Enabled = false;
            this.groupBoxSecond.Location = new System.Drawing.Point(167, 12);
            this.groupBoxSecond.Name = "groupBoxSecond";
            this.groupBoxSecond.Size = new System.Drawing.Size(155, 95);
            this.groupBoxSecond.TabIndex = 1;
            this.groupBoxSecond.TabStop = false;
            this.groupBoxSecond.Text = "Then by";
            // 
            // rbDesc2
            // 
            this.rbDesc2.AutoSize = true;
            this.rbDesc2.Location = new System.Drawing.Point(77, 46);
            this.rbDesc2.Name = "rbDesc2";
            this.rbDesc2.Size = new System.Drawing.Size(82, 17);
            this.rbDesc2.TabIndex = 2;
            this.rbDesc2.Text = "Descending";
            this.rbDesc2.UseVisualStyleBackColor = true;
            this.rbDesc2.CheckedChanged += new System.EventHandler(this.rbDesc2_CheckedChanged);
            // 
            // rbAsc2
            // 
            this.rbAsc2.AutoSize = true;
            this.rbAsc2.Checked = true;
            this.rbAsc2.Location = new System.Drawing.Point(8, 46);
            this.rbAsc2.Name = "rbAsc2";
            this.rbAsc2.Size = new System.Drawing.Size(75, 17);
            this.rbAsc2.TabIndex = 1;
            this.rbAsc2.TabStop = true;
            this.rbAsc2.Text = "Ascending";
            this.rbAsc2.UseVisualStyleBackColor = true;
            // 
            // cmbSort2
            // 
            this.cmbSort2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort2.FormattingEnabled = true;
            this.cmbSort2.Items.AddRange(new object[] {
            "Name",
            "Species",
            "Class",
            "Birth Year",
            "Daily Food (kg)"});
            this.cmbSort2.Location = new System.Drawing.Point(6, 19);
            this.cmbSort2.Name = "cmbSort2";
            this.cmbSort2.Size = new System.Drawing.Size(140, 21);
            this.cmbSort2.TabIndex = 0;
            this.cmbSort2.SelectedIndexChanged += new System.EventHandler(this.cmbSort2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 461);
            this.Controls.Add(this.groupSort);
            this.Controls.Add(this.groupFilter);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvZoos);
            this.Controls.Add(this.dgvAnimals);
            this.Name = "Form1";
            this.Text = "TheZoo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).EndInit();
            this.cmsAnimals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZoos)).EndInit();
            this.cmsZoos.ResumeLayout(false);
            this.groupFilter.ResumeLayout(false);
            this.groupFilter.PerformLayout();
            this.groupSort.ResumeLayout(false);
            this.groupBoxFirst.ResumeLayout(false);
            this.groupBoxFirst.PerformLayout();
            this.groupBoxSecond.ResumeLayout(false);
            this.groupBoxSecond.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAnimals;
        private System.Windows.Forms.DataGridView dgvZoos;
        private System.Windows.Forms.ContextMenuStrip cmsAnimals;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddAnimal;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditAnimal;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteAnimal;
        private System.Windows.Forms.ContextMenuStrip cmsZoos;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddZoo;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditZoo;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteZoo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupFilter;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ComboBox cmbZoo;
        private System.Windows.Forms.Label lblZoo;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.GroupBox groupSort;
        private System.Windows.Forms.GroupBox groupBoxFirst;
        private System.Windows.Forms.RadioButton rbDesc1;
        private System.Windows.Forms.RadioButton rbAsc1;
        private System.Windows.Forms.ComboBox cmbSort1;
        private System.Windows.Forms.GroupBox groupBoxSecond;
        private System.Windows.Forms.RadioButton rbDesc2;
        private System.Windows.Forms.RadioButton rbAsc2;
        private System.Windows.Forms.ComboBox cmbSort2;
    }
}
