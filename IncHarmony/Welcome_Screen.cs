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
    public partial class Welcome_Screen : Form
    {
        public Welcome_Screen()
        {
            InitializeComponent();
            showHome();
        }


        private void button1_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Quit IncHarmony?","Exit program",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
           {
                Application.Exit();
           }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else this.WindowState = FormWindowState.Maximized;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            showHome();
        }

        private void showHome()
        {
            panel_home.Show();
            pan_play.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel_home.Hide();
            showPlay("");
        }

        private void showPlay(string name)
        {
            pan_play.Show();
            loadVideos();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            wmp_alt.Ctlcontrols.play();
            wmp_sopran.Ctlcontrols.play();
            wmp_bass.Ctlcontrols.play();
            wmp_tenor.Ctlcontrols.play();
        }

        private void loadVideos()
        {
            string url = "https://i1.jbzd.com.pl/contents/2021/04/v7stJcXNsCI9hZ9DxeuKfZlFjrQluUhy.mp4";

            wmp_bass.URL = url;
            wmp_sopran.URL = url;
            wmp_tenor.URL = url;
            wmp_alt.URL = url;

            
        }
    }
}

