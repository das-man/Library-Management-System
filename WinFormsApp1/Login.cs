using System.Data;
using library;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text == "" ||  pwdBox.Text == "")
            {
                MessageBox.Show("username or password cannot be empty!", "Warning");
            }
            else
            {
                login();
            }
        }

        public void login()
        {
            Setting setting = new Setting();
            string cs = $"select * from admin where username='{usernameBox.Text}' and pwd='{pwdBox.Text}'";
            MySqlDataReader dr = setting.read(cs);

            if (dr.Read())
            {
                Data.Username = usernameBox.Text;

                MessageBox.Show("Login Success");
                Option opt = new Option();
                this.Hide();
                opt.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }

            setting.SetClose();
           
        }
    }
}
