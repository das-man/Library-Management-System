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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace library
{
    public partial class Loan : Form
    {
        private Boolean available;
        public Loan()
        {
            InitializeComponent();
        }
        private void Loan_Load(object sender, EventArgs e)
        {
            TableLoad();
        }
        private void TableLoad()
        {
            dataGridView1.Rows.Clear();
            Setting setting = new Setting();
            string sql = "select book_id, bookName, isBorrowed, DATE_FORMAT(BorrowDate, '%Y-%m-%d'), DATE_FORMAT(ReturnDate, '%Y-%m-%d')from book";
            MySqlDataReader dr = setting.read(sql);

            while (dr.Read())
            {
                dataGridView1.Rows.Add
                    (
                    dr[0].ToString(),
                    dr[1].ToString(),
                    dr[2].ToString(),
                    dr[3].ToString(),
                    dr[4].ToString()
                    );
            }

            dr.Close();
            setting.SetClose();
        }
        // refresh
        private void button8_Click(object sender, EventArgs e)
        {
            TableLoad();
        }
        // search by id
        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Setting setting = new Setting();
            string idstr = textBox1.Text;
            textBox1.Text = "";
            string sql = $"select book_id, bookName, isBorrowed, DATE_FORMAT(BorrowDate, '%Y-%m-%d'), DATE_FORMAT(ReturnDate, '%Y-%m-%d')from book where book_id = {idstr}";
            MySqlDataReader dr = setting.read(sql);

            while (dr.Read())
            {
                dataGridView1.Rows.Add
                    (
                    dr[0].ToString(),
                    dr[1].ToString(),
                    dr[2].ToString(),
                    dr[3].ToString(),
                    dr[4].ToString()
                    );
            }

            dr.Close();
            setting.SetClose();
        }
        // search by availiability
        private void button7_Click(object sender, EventArgs e)
        {
            available = !available;
            dataGridView1.Rows.Clear();
            Setting setting = new Setting();
            button7.Text = available ? "available" : "borrowed";
            string sql = $"select book_id, bookName, isBorrowed, DATE_FORMAT(BorrowDate, '%Y-%m-%d'), DATE_FORMAT(ReturnDate, '%Y-%m-%d') from book where isBorrowed = {available}";
            MySqlDataReader dr = setting.read(sql);

            while (dr.Read())
            {
                dataGridView1.Rows.Add
                    (
                    dr[0].ToString(),
                    dr[1].ToString(),
                    dr[2].ToString(),
                    dr[3].ToString(),
                    dr[4].ToString()
                    );
            }

            dr.Close();
            setting.SetClose();
        }
        // Return
        private void button4_Click(object sender, EventArgs e)
        {
            Option option = new Option();
            this.Hide();
            option.ShowDialog();
        }
        // check out
        private void button1_Click(object sender, EventArgs e)
        {
            string isBorrowed = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            if (isBorrowed == "0")
            {
                try
                {
                    string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    Setting setting = new Setting();
                    string sql = $"Update book set isBorrowed = 1, BorrowDate = now(), ReturnDate = date_add(now(), interval 60 day) where book_id = {id}";
                    int set = setting.Execute(sql);

                    if (set == 1)
                    {
                        MessageBox.Show("Book Checked out");
                    }
                    else
                    {
                        MessageBox.Show("Failed to Check out");
                    }

                    TableLoad();
                    setting.SetClose();
                }
                catch
                {
                    MessageBox.Show("Please select a book", "Warn");
                }
            }
            else
            {
                MessageBox.Show("The Book has been borrowed", "Warn");
            }
            
        }
        // check-in
        private void button2_Click(object sender, EventArgs e)
        {
            string isBorrowed = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            if (isBorrowed == "0")
            {
                MessageBox.Show("The book is not borrowed", "Warn");
            }
            else
            {
                try
                {
                    string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    Setting setting = new Setting();
                    string sql = $"Update book set isBorrowed = 0, BorrowDate = null, ReturnDate = null where book_id = {id}";
                    int set = setting.Execute(sql);

                    if (set == 1)
                    {
                        MessageBox.Show("Book Checked in");
                    }
                    else
                    {
                        MessageBox.Show("Failed to Check in");
                    }

                    TableLoad();
                    setting.SetClose();
                }
                catch
                {
                    MessageBox.Show("Please select a book", "Warn");
                }
            }
            
        }
        // Renew
        private void button3_Click(object sender, EventArgs e)
        {
            string isBorrowed = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            if (isBorrowed == "1")
            {
                try
                {
                    string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    Setting setting = new Setting();
                    string sql = $"Update book set ReturnDate = date_add(returndate, interval 30 day) where book_id = {id}";
                    int set = setting.Execute(sql);

                    if (set == 1)
                    {
                        MessageBox.Show("Book Renewed");
                    }
                    else
                    {
                        MessageBox.Show("Failed to Renew");
                    }

                    TableLoad();
                    setting.SetClose();
                }
                catch
                {
                    MessageBox.Show("Please select a book", "Warn");
                }
            }
            else
            {
                MessageBox.Show("The book is not borrowed", "Warn");
            }
        }
    }
}
