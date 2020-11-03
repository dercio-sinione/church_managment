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
    public partial class fn_imprimir_Caixa : Form
    {
        public fn_imprimir_Caixa(string ano)
        {
            InitializeComponent();
            try
            {
                csForms.tb_info = DTO.dtoRelatorios.tb_entradas(ano);
                for (int i = 0; i < csForms.tb_info.Rows.Count; i++)
                {
                    DataSet_Igreja.entradas.Rows.Add(csForms.tb_info.Rows[i][0], csForms.tb_info.Rows[i]["Ofertas"], csForms.tb_info.Rows[i]["Dizimo"], csForms.tb_info.Rows[i]["Total"], csForms.tb_info.Rows[i]["mes"], DateTime.Now.ToLongDateString(), csForms.tb_info.Rows[i]["tot_ofertas"], csForms.tb_info.Rows[i]["tot_dizimo"], csForms.tb_info.Rows[i]["Tot_geral"]);
                }
                rp_entradas.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
                this.rp_entradas.RefreshReport();

                this.Cursor = Cursors.Default;
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
                this.Cursor = Cursors.Default;
            }
        }

        
        private void fn_imprimir_Caixa_Load(object sender, EventArgs e)
        {
         }

        private void fn_imprimir_Caixa_FormClosing(object sender, FormClosingEventArgs e)
        {
            csForms.fnOpacidade.Hide();
        }
    }
}
