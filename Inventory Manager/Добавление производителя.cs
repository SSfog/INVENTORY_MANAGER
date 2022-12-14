using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


/*namespace Inventory_Manager
{

    public partial class Добавление_производителя : Form
    {

        public Добавление_производителя()
        {
            InitializeComponent();
            LoadData();

        }
        private void LoadData()
        {
            string connectString = "Data Source=LAPTOP-ORDAGPA9\\SQLEXPRESS;Initial Catalog=DfLessonDb;Integrated Security=True";
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            string query = "SELECT * FROM Производители";
            SqlCommand command = new SqlCommand(query, myConnection);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[2]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
            }
            reader.Close();
            myConnection.Close();
            foreach (string[] s in data)
                dataGridView3.Rows.Add(s); 
        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}*/


namespace Inventory_Manager
{
    public partial class Добавление_производителя : Form
    {
        DataBase dataBase = new DataBase();
        public Добавление_производителя()
        {
            InitializeComponent();
        }
        private void CreateColumns()
        {
            dataGridView3.Columns.Add("ID_Производителя", "ID_Производителя");
            dataGridView3.Columns.Add("Название производителя", "Название производителя");
            //dataGridView3.Columns.Add("IsNew", String.Empty);
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1));//, RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from Производители";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     
        }

        private void Добавление_производителя_Load1(object sender, EventArgs e)
        {

        }
        private void Добавление_производителя_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView3);
        }
    }
}