using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace TheZoo
{
    public partial class AnimalEditForm : Form
    {
        private static long nextTempId = -1;

        private DataTable animalsTable;
        private DataTable zoosTable;
        private DataRow existingRow;
        private string imagePath;

        public AnimalEditForm(DataTable animals, DataTable zoos)
        {
            InitializeComponent();
            animalsTable = animals;
            zoosTable = zoos;
            existingRow = null;
        }

        public AnimalEditForm(DataTable animals, DataTable zoos, DataRow row)
        {
            InitializeComponent();
            animalsTable = animals;
            zoosTable = zoos;
            existingRow = row;
        }

        private void AnimalEditForm_Load(object sender, EventArgs e)
        {
            cmbZoo.DataSource = zoosTable;
            cmbZoo.DisplayMember = "zoo_name";
            cmbZoo.ValueMember = "zoo_id";

            if (existingRow != null)
            {
                this.Text = "Edit Animal";
                txtName.Text = existingRow["animal_name"].ToString();
                txtSpecies.Text = existingRow["species"].ToString();
                cmbClass.Text = existingRow["animal_class"].ToString();
                cmbGender.Text = existingRow["gender"].ToString();
                nudBirthYear.Value = Convert.ToDecimal(existingRow["birth_year"]);
                nudDailyFood.Value = Convert.ToDecimal(existingRow["daily_food_kg"]);
                nudFoodPrice.Value = Convert.ToDecimal(existingRow["food_price_per_kg"]);
                cmbZoo.SelectedValue = existingRow["zoo_id"];

                if (existingRow["animal_photo_path"] != DBNull.Value)
                {
                    LoadImage(existingRow["animal_photo_path"].ToString());
                }
            }
            else
            {
                this.Text = "Add Animal";
                cmbClass.SelectedIndex = 0;
                cmbGender.SelectedIndex = 0;
                if (zoosTable.Rows.Count > 0)
                    cmbZoo.SelectedIndex = 0;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select Image";
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                string imagesDir = Path.Combine(Application.StartupPath, "assets", "images", "animals");
                Directory.CreateDirectory(imagesDir);

                string uniqueName = Guid.NewGuid().ToString() + Path.GetExtension(dialog.FileName);
                string destPath = Path.Combine(imagesDir, uniqueName);
                File.Copy(dialog.FileName, destPath);

                LoadImage("assets/images/animals/" + uniqueName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to copy image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadImage(string path)
        {
            imagePath = path;
            if (string.IsNullOrEmpty(path))
            {
                picAnimal.Image = null;
                return;
            }

            string fullPath = Path.IsPathRooted(path) ? path : Path.Combine(Application.StartupPath, path);
            if (File.Exists(fullPath))
                picAnimal.Load(fullPath);
            else
                picAnimal.Image = null;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            long zooId = Convert.ToInt64(cmbZoo.SelectedValue);

            if (existingRow != null)
            {
                existingRow["animal_name"] = txtName.Text.Trim();
                existingRow["species"] = txtSpecies.Text.Trim();
                existingRow["animal_class"] = cmbClass.Text;
                existingRow["gender"] = cmbGender.Text;
                existingRow["birth_year"] = (long)nudBirthYear.Value;
                existingRow["daily_food_kg"] = (double)nudDailyFood.Value;
                existingRow["food_price_per_kg"] = (double)nudFoodPrice.Value;
                existingRow["zoo_id"] = zooId;
                existingRow["animal_photo_path"] = imagePath;
            }
            else
            {
                DataRow newRow = animalsTable.NewRow();
                newRow["animal_id"] = nextTempId--;
                newRow["zoo_id"] = zooId;
                newRow["animal_name"] = txtName.Text.Trim();
                newRow["species"] = txtSpecies.Text.Trim();
                newRow["animal_class"] = cmbClass.Text;
                newRow["gender"] = cmbGender.Text;
                newRow["birth_year"] = (long)nudBirthYear.Value;
                newRow["daily_food_kg"] = (double)nudDailyFood.Value;
                newRow["food_price_per_kg"] = (double)nudFoodPrice.Value;
                newRow["animal_photo_path"] = imagePath;
                animalsTable.Rows.Add(newRow);
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
