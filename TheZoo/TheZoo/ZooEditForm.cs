using System;
using System.Data;
using System.Windows.Forms;

namespace TheZoo
{
    public partial class ZooEditForm : Form
    {
        private static long nextTempId = -1;

        private DataTable zoosTable;
        private DataRow existingRow;

        public ZooEditForm(DataTable zoos)
        {
            InitializeComponent();
            zoosTable = zoos;
            existingRow = null;
        }

        public ZooEditForm(DataTable zoos, DataRow row)
        {
            InitializeComponent();
            zoosTable = zoos;
            existingRow = row;
        }

        private void ZooEditForm_Load(object sender, EventArgs e)
        {
            if (existingRow != null)
            {
                this.Text = "Edit Zoo";
                txtName.Text = existingRow["zoo_name"].ToString();
                txtCity.Text = existingRow["city"].ToString();
                txtCountry.Text = existingRow["country"].ToString();
                nudOpened.Value = Convert.ToDecimal(existingRow["opened_year"]);
                nudArea.Value = Convert.ToDecimal(existingRow["area_hectares"]);
                chkAquarium.Checked = Convert.ToInt64(existingRow["has_aquarium"]) == 1;
            }
            else
            {
                this.Text = "Add Zoo";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (existingRow != null)
            {
                existingRow["zoo_name"] = txtName.Text.Trim();
                existingRow["city"] = txtCity.Text.Trim();
                existingRow["country"] = txtCountry.Text.Trim();
                existingRow["opened_year"] = (long)nudOpened.Value;
                existingRow["area_hectares"] = (double)nudArea.Value;
                existingRow["has_aquarium"] = chkAquarium.Checked ? 1L : 0L;
            }
            else
            {
                DataRow newRow = zoosTable.NewRow();
                newRow["zoo_id"] = nextTempId--;
                newRow["zoo_name"] = txtName.Text.Trim();
                newRow["city"] = txtCity.Text.Trim();
                newRow["country"] = txtCountry.Text.Trim();
                newRow["opened_year"] = (long)nudOpened.Value;
                newRow["area_hectares"] = (double)nudArea.Value;
                newRow["has_aquarium"] = chkAquarium.Checked ? 1L : 0L;
                zoosTable.Rows.Add(newRow);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
