using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncHarmony
{

    public partial class Login_Screen : Form
    {

        Welcome_Screen ws = new Welcome_Screen();

        public Login_Screen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginUser(textBox1.Text, textBox2.Text);
        }

        private void loginUser(string user, string password)
        {
            this.Hide();
            ws.Show();
        }
    }
}
