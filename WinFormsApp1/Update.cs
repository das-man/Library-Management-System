using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class Update : Form
    {
        private string id;
        public Update(string id, string name, string author, string cat)
        {
            InitializeComponent();
            this.id = id;
            textBox1.Text = name;
            textBox2.Text = author;
            textBox3.Text = cat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("values cannot be empty");
            }
            else
            {
                Setting setting = new Setting();
                string sql = $"Update book set bookName = '{textBox1.Text}', bookAuthor = '{textBox2.Text}', bookCategory = '{textBox3.Text}' where book_id = {this.id}";
                int set = setting.Execute(sql);

                if (set == 1)
                {
                    MessageBox.Show("Book details has been updated");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update book details");
                }

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }
    }
}
