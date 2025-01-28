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
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
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
                string sql = $"insert into book values (null, '{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}', 0, null, null)";
                int set = setting.Execute(sql);

                if (set == 1)
                {
                    MessageBox.Show("A New book has been created");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to Create New Book");
                }

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }
    }
}
