using Microsoft.Data.Sqlite;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace TheZoo
{
    public partial class Form1: Form
    {
        private DataView zoosView;
        private DataView animalsView;
        private DataTable animalsTable;

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
            string dbPath = Path.Combine(Application.StartupPath, "zoo_animals.db");
            string connectionString = $"Data Source={dbPath}";

            DataSet dataSet = new DataSet();

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                DataTable zoosTable = new DataTable("Zoos");
                using (var command = new SqliteCommand("SELECT * FROM Zoos", connection))
                using (var reader = command.ExecuteReader())
                {
                    zoosTable.Load(reader);
                }
                dataSet.Tables.Add(zoosTable);

                animalsTable = new DataTable("Animals");
                using (var command = new SqliteCommand("SELECT * FROM Animals", connection))
                using (var reader = command.ExecuteReader())
                {
                    animalsTable.Load(reader);
                }
                dataSet.Tables.Add(animalsTable);
            }

            zoosView = new DataView(dataSet.Tables["Zoos"]);
            animalsView = new DataView(dataSet.Tables["Animals"]);
        }

        private void ConfigureDataGridViews()
        {
            dgvZoos.DataSource = zoosView;

            dgvZoos.Columns["zoo_id"].Visible = false;

            dgvZoos.Columns["zoo_name"].HeaderText = "Zoo";
            dgvZoos.Columns["city"].HeaderText = "City";
            dgvZoos.Columns["country"].HeaderText = "Country";
            dgvZoos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;


            dgvAnimals.DataSource = animalsView;

            dgvAnimals.Columns["animal_id"].Visible = false;
            dgvAnimals.Columns["zoo_id"].Visible = false;

            dgvAnimals.Columns["animal_name"].HeaderText = "Name";
            dgvAnimals.Columns["species"].HeaderText = "Species";
            dgvAnimals.Columns["animal_class"].HeaderText = "Class";

            dgvAnimals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void dgvZoos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvZoos.CurrentRow.DataBoundItem is DataRowView selectedRow)
            {
                long zooId = (long)selectedRow["zoo_id"];
                animalsView.RowFilter = $"zoo_id = {zooId}";
            }
        }
    }
}
