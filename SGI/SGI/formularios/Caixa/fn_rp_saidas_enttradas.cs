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
    public partial class fn_rp_saidas_enttradas : Form
    {
        public fn_rp_saidas_enttradas(string ano)
        {
            InitializeComponent();

            csForms.tb_info = DTO.dtoRelatorios.tb_entradas_saidas(ano);
            for (int i = 0; i < csForms.tb_info.Rows.Count; i++)
            {
                DataSet_Igreja.Entradas_saidas.Rows.Add(csForms.tb_info.Rows[i][0], csForms.tb_info.Rows[i]["Tot_Entradas"], csForms.tb_info.Rows[i]["Tot_Saidas"], csForms.tb_info.Rows[i]["Total"], csForms.tb_info.Rows[i]["mes"], DateTime.Now.ToLongDateString(), csForms.tb_info.Rows[i]["total_entrada"], csForms.tb_info.Rows[i]["total_saida"], csForms.tb_info.Rows[i]["caixa"]);
            }
            rp_saidas.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;

            this.rp_saidas.RefreshReport();
        
        }

        private void fn_rp_saidas_enttradas_Load(object sender, EventArgs e)
        {
            }

        private void fn_rp_saidas_enttradas_FormClosing(object sender, FormClosingEventArgs e)
        {
            csForms.fnOpacidade.Hide();
        }
    }
}
