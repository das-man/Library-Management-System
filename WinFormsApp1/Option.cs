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
    public partial class Option : Form
    {

        public Option()
        {
            InitializeComponent();
            Greetings.Text = $"Good Day, {Data.Username}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book_db db = new Book_db();
            this.Hide();
            db.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Loan loan = new Loan();
            this.Hide();
            loan.ShowDialog();
        }

    }
}
