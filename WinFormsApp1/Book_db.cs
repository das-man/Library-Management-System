using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace library
{
    public partial class Book_db : Form
    {
        public Book_db()
        {
            InitializeComponent();
        }
        private void Book_db_Load(object sender, EventArgs e)
        {
            TableLoad();
        }
        // Return function
        private void button5_Click(object sender, EventArgs e)
        {
            Option opt = new Option();
            this.Hide();
            opt.ShowDialog();
        }
        private void TableLoad()
        {
            dataGridView1.Rows.Clear();
            Setting setting = new Setting();
            string sql = "select * from book";
            MySqlDataReader dr = setting.read(sql);

            while (dr.Read())
            {
                dataGridView1.Rows.Add
                    (
                    dr[0].ToString(),
                    dr[1].ToString(),
                    dr[2].ToString(),
                    dr[3].ToString()
                    );
            }

            dr.Close();
            setting.SetClose();
        }
        // Create book
        private void button1_Click(object sender, EventArgs e)
        {
            Create create = new Create();
            create.ShowDialog();

            TableLoad();
        }
        // Delete Book
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string bookName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult dr = MessageBox.Show($"Delete following book: {bookName}", "select", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    string sql = $"delete from book where book_id = {id}";
                    Setting setting = new Setting();

                    if (setting.Execute(sql) == 1)
                    {
                        MessageBox.Show("Delete sucessfully");
                        TableLoad();
                    }
                    else
                    {
                        MessageBox.Show("Delete failed");
                    }

                    setting.SetClose();
                }
            }
            catch
            {
                MessageBox.Show("Please select a book", "Warn");
            }
        }
        // update book
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string author = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string cat = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                Update update = new Update(id, name, author, cat);
                update.ShowDialog();

                TableLoad();
            }
            catch
            {
                MessageBox.Show("Please select a book", "Warn");
            }

        }
        // refresh table
        private void button8_Click(object sender, EventArgs e)
        {
            TableLoad();
        }
        // Search by id
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Setting setting = new Setting();
            string idstr = textBox1.Text;
            textBox1.Text = "";
            string sql = $"select * from book where book_id = {idstr}";
            MySqlDataReader dr = setting.read(sql);

            while (dr.Read())
            {
                dataGridView1.Rows.Add
                    (
                    dr[0].ToString(),
                    dr[1].ToString(),
                    dr[2].ToString(),
                    dr[3].ToString()
                    );
            }

            dr.Close();
            setting.SetClose();
        }
        // Search by name
        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Setting setting = new Setting();
            string nameStr = textBox2.Text;
            textBox2.Text = "";
            string sql = $"select * from book where bookName like '%{nameStr}%'";
            MySqlDataReader dr = setting.read(sql);

            while (dr.Read())
            {
                dataGridView1.Rows.Add
                    (
                    dr[0].ToString(),
                    dr[1].ToString(),
                    dr[2].ToString(),
                    dr[3].ToString()
                    );
            }

            dr.Close();
            setting.SetClose();
        }
        // Search by cat
        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Setting setting = new Setting();
            string catStr = textBox3.Text;
            textBox3.Text = "";
            string sql = $"select * from book where bookCategory = '{catStr}'";
            MySqlDataReader dr = setting.read(sql);

            while (dr.Read())
            {
                dataGridView1.Rows.Add
                    (
                    dr[0].ToString(),
                    dr[1].ToString(),
                    dr[2].ToString(),
                    dr[3].ToString()
                    );
            }

            dr.Close();
            setting.SetClose();
        }
    }
}
