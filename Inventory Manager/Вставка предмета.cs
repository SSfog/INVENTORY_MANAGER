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
using System.Diagnostics;


namespace Inventory_Manager
{
    public partial class Вставка_предмета : Form
    {   DataBase database = new DataBase();
        public Вставка_предмета()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Вставка_предмета_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            database.openConnection();
             var kateg = textBox1.Text;
             var predm = textBox2.Text;
             var artik = textBox3.Text;
             int price;
             var proizv = textBox5.Text;
             var krat_op = textBox6.Text;
             var ofis = textBox7.Text;
             var room = textBox8.Text;

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Заполните пустые поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (int.TryParse(textBox4.Text, out price))
                {
                    var AddQuery = $"INSERT INTO [Основная_таблица] (Категория, Предмет, Артикул, Цена,Производитель,[Краткое описание],Офис,Помещение) VALUES ('{kateg}','{predm}','{artik}','{price}','{proizv}','{krat_op}','{ofis}','{room}')";
                    var command = new SqlCommand(AddQuery, database.getConnection());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    Полная_таблица obr = new Полная_таблица();
                    obr.Show();
                }
                else
                {
                    MessageBox.Show("Цена должна иметь числовой формат!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            database.closeConnection();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Полная_таблица obr = new Полная_таблица();
            obr.Show();
        }
    }
}
