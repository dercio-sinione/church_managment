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
    public partial class fn_imprimir_saidas : Form
    {
        public fn_imprimir_saidas()
        {
            InitializeComponent();
        }

        private void Full()
        {
            try
            {
                for (int i = 0; i < csForms.tb_info.Rows.Count; i++)
                {
                    DataSet_Igreja.saidas.Rows.Add(csForms.tb_info.Rows[i][0],csForms.tb_info.Rows[i][2],csForms.tb_info.Rows[i][3],csForms.tb_info.Rows[i][4],csForms.tb_info.Rows[i][5],DateTime.Now.ToLongDateString());
                }
            }
            catch (Exception)
            {
            }
        }
        private void fn_imprimir_saidas_FormClosing(object sender, FormClosingEventArgs e)
        {
            csForms.fnOpacidade.Hide();
        }

        private void fn_imprimir_saidas_Load(object sender, EventArgs e)
        {
            Full();
            this.reportViewer1.RefreshReport();
        }
    }
}
