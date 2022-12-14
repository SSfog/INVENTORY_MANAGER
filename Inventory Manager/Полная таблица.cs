using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.SqlClient;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory_Manager

{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Полная_таблица : Form
    {
        DataBase dataBase = new DataBase();
        public Полная_таблица()
        {
            InitializeComponent();
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Категория", "Категория");
            dataGridView1.Columns.Add("Предмет", "Предмет");
            dataGridView1.Columns.Add("Артикул", "Артикул");
            dataGridView1.Columns.Add("Цена", "Цена");
            dataGridView1.Columns.Add("Производитель", "Производитель");
            dataGridView1.Columns.Add("Краткое описание", "Краткое описание");
            dataGridView1.Columns.Add("Офис", "Офис");
            dataGridView1.Columns.Add("Помещение", "Помещение");
            //dataGridView1.Columns.Add("IsNew", String.Empty);
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetString(4), record.GetString(5), record.GetString(6), record.GetString(7));//, RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from Основная_таблица";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Полная_таблица_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Вставка_предмета add = new Вставка_предмета();
            add.Show();
        }
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"SELECT * FROM [Основная_таблица] where concat (Категория,Предмет,Артикул,Цена,Производитель,[Краткое описание],Офис,Помещение) like '%" + textBox1.Text + "%'";
            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }
        private void deleteRow()
        {
            dataBase.openConnection();
            int index = dataGridView1.CurrentCell.RowIndex;
            var artik = Convert.ToString(dataGridView1.Rows[index].Cells[2].Value);
            var deleteQuery = $"delete from [Основная_таблица] where Артикул={artik}";
            var command = new SqlCommand(deleteQuery, dataBase.getConnection());
            command.ExecuteNonQuery();
            dataGridView1.Rows[index].Visible = false;
            dataBase.closeConnection();
        }
        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите удалить запись?", "Подтверждение",
                MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                deleteRow();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Change()
        {
            var SelectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            var kat = Convert.ToString(dataGridView1.Rows[SelectedRowIndex].Cells[0].Value);
            var pred = Convert.ToString(dataGridView1.Rows[SelectedRowIndex].Cells[1].Value);
            var artik = Convert.ToString(dataGridView1.Rows[SelectedRowIndex].Cells[2].Value);
            int price;
            var proizv = Convert.ToString(dataGridView1.Rows[SelectedRowIndex].Cells[4].Value);
            var kr_op = Convert.ToString(dataGridView1.Rows[SelectedRowIndex].Cells[5].Value);
            var ofis = Convert.ToString(dataGridView1.Rows[SelectedRowIndex].Cells[6].Value);
            var room = Convert.ToString(dataGridView1.Rows[SelectedRowIndex].Cells[7].Value);
            if (dataGridView1.Rows[SelectedRowIndex].Cells[1].Value.ToString() != String.Empty)
            {
                if (int.TryParse((Convert.ToString(dataGridView1.Rows[SelectedRowIndex].Cells[3].Value)), out price))
                {
                        dataBase.openConnection();
                        var kate = dataGridView1.Rows[SelectedRowIndex].Cells[0].Value.ToString();
                        var predm = dataGridView1.Rows[SelectedRowIndex].Cells[1].Value.ToString();
                        var artiku = dataGridView1.Rows[SelectedRowIndex].Cells[2].Value.ToString();
                        var pricen = dataGridView1.Rows[SelectedRowIndex].Cells[3].Value.ToString();
                        var proizvo = dataGridView1.Rows[SelectedRowIndex].Cells[4].Value.ToString();
                        var kr_opis = dataGridView1.Rows[SelectedRowIndex].Cells[5].Value.ToString();
                        var ofisi = dataGridView1.Rows[SelectedRowIndex].Cells[6].Value.ToString();
                        var rooms = dataGridView1.Rows[SelectedRowIndex].Cells[7].Value.ToString();
                        var changeQuery = $"update Основная_таблица set Категория = '{kate}', Предмет = '{predm}', Артикул = '{artiku}',Цена = '{pricen}', Производитель = '{proizvo}', [Краткое описание] = '{kr_opis}', Офис = '{ofisi}', Помещение = '{rooms}' WHERE Артикул='{artiku}'";
                        var command = new SqlCommand(changeQuery, dataBase.getConnection());
                        command.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Цена должна иметь числовой формат!");
                }
            }
                dataBase.closeConnection();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
 