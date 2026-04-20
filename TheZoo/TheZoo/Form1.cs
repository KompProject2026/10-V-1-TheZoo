using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TheZoo
{
    public partial class Form1 : Form
    {
        private const string ConnectionString = "Data Source=zoo_animals.db";
        private DataSet dataSet = new DataSet();
        private DataView animalsView;
        private DataView zoosView;
        private string[] sortFields = new string[] { "animal_name", "species", "animal_class", "birth_year", "daily_food_kg" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            ConfigureDataGridViews();
        }

        private void LoadData()
        {
            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                DataTable animalsTable = new DataTable("Animals");
                using (SqliteCommand command = new SqliteCommand("SELECT animal_id, zoo_id, animal_name, species, animal_class, gender, birth_year, daily_food_kg, food_price_per_kg, animal_photo_path FROM Animals", connection))
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    animalsTable.Load(reader);
                }
                dataSet.Tables.Add(animalsTable);

                DataTable zoosTable = new DataTable("Zoos");
                using (SqliteCommand command = new SqliteCommand("SELECT zoo_id, zoo_name, city, country, opened_year, area_hectares, has_aquarium FROM Zoos", connection))
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    zoosTable.Load(reader);
                }
                dataSet.Tables.Add(zoosTable);
            }

            animalsView = new DataView(dataSet.Tables["Animals"]);
            zoosView = new DataView(dataSet.Tables["Zoos"]);
        }

        private void ConfigureDataGridViews()
        {
            dgvAnimals.DataSource = animalsView;
            dgvAnimals.Columns["animal_id"].Visible = false;
            dgvAnimals.Columns["zoo_id"].Visible = false;
            dgvAnimals.Columns["animal_photo_path"].Visible = false;
            dgvAnimals.Columns["animal_name"].HeaderText = "Name";
            dgvAnimals.Columns["species"].HeaderText = "Species";
            dgvAnimals.Columns["animal_class"].HeaderText = "Class";
            dgvAnimals.Columns["gender"].HeaderText = "Gender";
            dgvAnimals.Columns["birth_year"].HeaderText = "Birth Year";
            dgvAnimals.Columns["daily_food_kg"].HeaderText = "Daily Food (kg)";
            dgvAnimals.Columns["food_price_per_kg"].HeaderText = "Food Price (per kg)";
            dgvAnimals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            dgvZoos.DataSource = zoosView;
            dgvZoos.Columns["zoo_id"].Visible = false;
            dgvZoos.Columns["zoo_name"].HeaderText = "Zoo";
            dgvZoos.Columns["city"].HeaderText = "City";
            dgvZoos.Columns["country"].HeaderText = "Country";
            dgvZoos.Columns["opened_year"].HeaderText = "Opened";
            dgvZoos.Columns["area_hectares"].HeaderText = "Area (ha)";
            dgvZoos.Columns["has_aquarium"].HeaderText = "Aquarium";
            dgvZoos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            cmbZoo.DataSource = dataSet.Tables["Zoos"];
            cmbZoo.DisplayMember = "zoo_name";
            cmbZoo.ValueMember = "zoo_id";
            cmbZoo.SelectedIndex = -1;
        }

        private void tsmiAddAnimal_Click(object sender, EventArgs e)
        {
            using (AnimalEditForm form = new AnimalEditForm(dataSet.Tables["Animals"], dataSet.Tables["Zoos"]))
            {
                if (form.ShowDialog() == DialogResult.OK)
                    dgvAnimals.Refresh();
            }
        }

        private void tsmiEditAnimal_Click(object sender, EventArgs e)
        {
            if (dgvAnimals.CurrentRow == null) return;
            DataRowView rowView = dgvAnimals.CurrentRow.DataBoundItem as DataRowView;
            if (rowView == null) return;

            using (AnimalEditForm form = new AnimalEditForm(dataSet.Tables["Animals"], dataSet.Tables["Zoos"], rowView.Row))
            {
                if (form.ShowDialog() == DialogResult.OK)
                    dgvAnimals.Refresh();
            }
        }

        private void tsmiDeleteAnimal_Click(object sender, EventArgs e)
        {
            if (dgvAnimals.CurrentRow == null) return;
            DataRowView rowView = dgvAnimals.CurrentRow.DataBoundItem as DataRowView;
            if (rowView == null) return;
            rowView.Row.Delete();
        }

        private void tsmiAddZoo_Click(object sender, EventArgs e)
        {
            using (ZooEditForm form = new ZooEditForm(dataSet.Tables["Zoos"]))
            {
                if (form.ShowDialog() == DialogResult.OK)
                    dgvZoos.Refresh();
            }
        }

        private void tsmiEditZoo_Click(object sender, EventArgs e)
        {
            if (dgvZoos.CurrentRow == null) return;
            DataRowView rowView = dgvZoos.CurrentRow.DataBoundItem as DataRowView;
            if (rowView == null) return;

            using (ZooEditForm form = new ZooEditForm(dataSet.Tables["Zoos"], rowView.Row))
            {
                if (form.ShowDialog() == DialogResult.OK)
                    dgvZoos.Refresh();
            }
        }

        private void tsmiDeleteZoo_Click(object sender, EventArgs e)
        {
            if (dgvZoos.CurrentRow == null) return;
            DataRowView rowView = dgvZoos.CurrentRow.DataBoundItem as DataRowView;
            if (rowView == null) return;
            rowView.Row.Delete();
        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection(ConnectionString))
                {
                    connection.Open();

                    Dictionary<long, long> zooIdMap = SaveTableChanges(connection, dataSet.Tables["Zoos"], "Zoos", "zoo_id",
                        new string[] { "zoo_name", "city", "country", "opened_year", "area_hectares", "has_aquarium" });

                    RemapForeignKeys(dataSet.Tables["Animals"], "zoo_id", zooIdMap);

                    SaveTableChanges(connection, dataSet.Tables["Animals"], "Animals", "animal_id",
                        new string[] { "zoo_id", "animal_name", "species", "animal_class", "gender", "birth_year", "daily_food_kg", "food_price_per_kg", "animal_photo_path" });
                }

                dataSet.AcceptChanges();
                MessageBox.Show("Changes saved successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving changes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Dictionary<long, long> SaveTableChanges(SqliteConnection connection, DataTable table, string tableName, string idColumn, string[] dataColumns)
        {
            Dictionary<long, long> idMap = new Dictionary<long, long>();
            string cols = string.Join(", ", dataColumns);
            string paramNames = string.Join(", ", dataColumns.Select(c => "@" + c));
            string sets = string.Join(", ", dataColumns.Select(c => c + " = @" + c));

            List<DataRow> rows = new List<DataRow>();
            foreach (DataRow r in table.Rows)
                rows.Add(r);

            foreach (DataRow row in rows)
            {
                if (row.RowState == DataRowState.Deleted)
                {
                    using (SqliteCommand cmd = new SqliteCommand("DELETE FROM " + tableName + " WHERE " + idColumn + " = @id", connection))
                    {
                        cmd.Parameters.AddWithValue("@id", row[idColumn, DataRowVersion.Original]);
                        cmd.ExecuteNonQuery();
                    }
                }
                else if (row.RowState == DataRowState.Added)
                {
                    using (SqliteCommand cmd = new SqliteCommand("INSERT INTO " + tableName + " (" + cols + ") VALUES (" + paramNames + "); SELECT last_insert_rowid();", connection))
                    {
                        AddDataParams(cmd, dataColumns, row);
                        long newId = (long)cmd.ExecuteScalar();
                        if (row[idColumn] is long oldId)
                            idMap[oldId] = newId;
                        row[idColumn] = newId;
                    }
                }
                else if (row.RowState == DataRowState.Modified)
                {
                    if (!HasRealChanges(row, dataColumns)) continue;
                    using (SqliteCommand cmd = new SqliteCommand("UPDATE " + tableName + " SET " + sets + " WHERE " + idColumn + " = @id", connection))
                    {
                        cmd.Parameters.AddWithValue("@id", row[idColumn, DataRowVersion.Original]);
                        AddDataParams(cmd, dataColumns, row);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            return idMap;
        }

        private void RemapForeignKeys(DataTable table, string column, Dictionary<long, long> idMap)
        {
            if (idMap.Count == 0) return;
            foreach (DataRow row in table.Rows)
            {
                if (row.RowState != DataRowState.Added) continue;
                if (row[column] is long oldId && idMap.ContainsKey(oldId))
                    row[column] = idMap[oldId];
            }
        }

        private bool HasRealChanges(DataRow row, string[] columns)
        {
            foreach (string col in columns)
            {
                if (!Equals(row[col], row[col, DataRowVersion.Original]))
                    return true;
            }
            return false;
        }

        private void AddDataParams(SqliteCommand cmd, string[] columns, DataRow row)
        {
            foreach (string col in columns)
            {
                object val = row[col];
                cmd.Parameters.AddWithValue("@" + col, val == null ? DBNull.Value : val);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            List<string> filters = new List<string>();

            if (!string.IsNullOrEmpty(tbxName.Text))
                filters.Add("animal_name LIKE '%" + tbxName.Text.Replace("'", "''") + "%'");

            int from;
            if (!string.IsNullOrEmpty(txtFrom.Text) && int.TryParse(txtFrom.Text, out from))
                filters.Add("birth_year >= " + from);

            int to;
            if (!string.IsNullOrEmpty(txtTo.Text) && int.TryParse(txtTo.Text, out to))
                filters.Add("birth_year <= " + to);

            if (cmbZoo.SelectedIndex >= 0 && cmbZoo.SelectedValue is long)
            {
                long zooId = (long)cmbZoo.SelectedValue;
                filters.Add("zoo_id = " + zooId);
            }

            animalsView.RowFilter = string.Join(" AND ", filters);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            tbxName.Text = "";
            txtFrom.Text = "";
            txtTo.Text = "";
            cmbZoo.SelectedIndex = -1;
            animalsView.RowFilter = "";
        }

        private void cmbSort1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplySort();
        }

        private void cmbSort2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplySort();
        }

        private void rbDesc1_CheckedChanged(object sender, EventArgs e)
        {
            ApplySort();
        }

        private void rbDesc2_CheckedChanged(object sender, EventArgs e)
        {
            ApplySort();
        }

        private void ApplySort()
        {
            if (cmbSort1.SelectedIndex >= 0)
            {
                string sort = sortFields[cmbSort1.SelectedIndex];
                if (rbDesc1.Checked) sort += " DESC";

                if (groupBoxSecond.Enabled && cmbSort2.SelectedIndex >= 0)
                {
                    sort += ", " + sortFields[cmbSort2.SelectedIndex];
                    if (rbDesc2.Checked) sort += " DESC";
                }

                animalsView.Sort = sort;
                groupBoxSecond.Enabled = true;
            }
            else
            {
                animalsView.Sort = "";
                groupBoxSecond.Enabled = false;
            }
        }
    }
}
