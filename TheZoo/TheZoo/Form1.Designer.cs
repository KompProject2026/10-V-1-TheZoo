namespace TheZoo
{
    partial class Form1
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
            this.dgvZoos = new System.Windows.Forms.DataGridView();
            this.dgvAnimals = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZoos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZoos
            // 
            this.dgvZoos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZoos.Location = new System.Drawing.Point(0, 0);
            this.dgvZoos.Name = "dgvZoos";
            this.dgvZoos.Size = new System.Drawing.Size(797, 222);
            this.dgvZoos.TabIndex = 0;
            this.dgvZoos.SelectionChanged += new System.EventHandler(this.dgvZoos_SelectionChanged);
            // 
            // dgvAnimals
            // 
            this.dgvAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimals.Location = new System.Drawing.Point(0, 228);
            this.dgvAnimals.Name = "dgvAnimals";
            this.dgvAnimals.Size = new System.Drawing.Size(797, 222);
            this.dgvAnimals.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAnimals);
            this.Controls.Add(this.dgvZoos);
            this.Name = "Form1";
            this.Text = "TheZoo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZoos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZoos;
        private System.Windows.Forms.DataGridView dgvAnimals;
    }
}

