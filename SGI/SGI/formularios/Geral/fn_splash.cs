using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGI
{
    public partial class fn_splash : Form
    {
        public fn_splash()
        {
            InitializeComponent();
        }

        private void fn_splash_Load(object sender, EventArgs e)
        {
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            lbProgres.Text = progressBar1.Value + "%";

            if (progressBar1.Value >= 100)
            {
                timer1.Stop();
                fn_login login = new fn_login();
                login.Show();
                this.Hide();
            }
        }
    }
}
