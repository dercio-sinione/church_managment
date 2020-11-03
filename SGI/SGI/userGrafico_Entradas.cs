using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGI
{
    public partial class userGrafico_Entradas : UserControl
    {
        public userGrafico_Entradas()
        {
            InitializeComponent();
            csRestricoes.add_Number(txtAno);
        }

        private void Full()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (txtAno.Text==string.Empty)
                {
                    txtAno.Text = DateTime.Now.Year.ToString();
                }

                if (cbxTipo.SelectedIndex == 0)
                {
                    lbTitulo.Text = "Estatística de entradas de valores";
                    gr_grafico1.DataSource = DTO.dtoRelatorios.tb_entradas(txtAno.Text);
                    gr_grafico1.Series["Series1"].LegendText = "Ofertas";
                    gr_grafico1.Series["Series1"].XValueMember = "mes";
                    gr_grafico1.Series["Series1"].YValueMembers = "Ofertas";

                    gr_grafico1.Series["Series2"].LegendText = "Dízimos";
                    gr_grafico1.Series["Series2"].XValueMember = "mes";
                    gr_grafico1.Series["Series2"].YValueMembers = "Dizimo";

                    gr_grafico1.Series["Series3"].LegendText = "Total";
                    gr_grafico1.Series["Series3"].XValueMember = "mes";
                    gr_grafico1.Series["Series3"].YValueMembers = "Total";
                }
                if (cbxTipo.SelectedIndex == 1)
                {
                    lbTitulo.Text = "Estatística de entradas e saídas de valores";
                    gr_grafico1.DataSource = DTO.dtoRelatorios.tb_entradas_saidas(txtAno.Text);
                    gr_grafico1.Series["Series1"].LegendText = "Total de entradas";
                    gr_grafico1.Series["Series1"].XValueMember = "mes";
                    gr_grafico1.Series["Series1"].YValueMembers = "Tot_Entradas";

                    gr_grafico1.Series["Series2"].LegendText = "Total de Saídas";
                    gr_grafico1.Series["Series2"].XValueMember = "mes";
                    gr_grafico1.Series["Series2"].YValueMembers = "Tot_Saidas";

                    gr_grafico1.Series["Series3"].LegendText = "Total";
                    gr_grafico1.Series["Series3"].XValueMember = "mes";
                    gr_grafico1.Series["Series3"].YValueMembers = "Total";
                }

                this.Cursor = Cursors.Default;
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
                this.Cursor = Cursors.Default;
            }
        }

        
        private void userGrafico_Entradas_Load(object sender, EventArgs e)
        {
            cbxTipo.SelectedIndex = 0;
            txtAno.Text = DateTime.Now.Year.ToString();
            Full();
        }

        private void pcRefresh_Click(object sender, EventArgs e)
        {
            Full();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAno_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                Full();
            }
        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Full();
        }

        private void pc_imprimir_Click(object sender, EventArgs e)
        {
            if (txtAno.Text==string.Empty)
            {
                txtAno.Text = DateTime.Now.Year.ToString();
            }

            if (cbxTipo.SelectedIndex==0)
            {
                this.Cursor = Cursors.WaitCursor;
                Form fn_im = new fn_imprimir_Caixa(txtAno.Text);
                csForms.fnOpacidade.Show();
                fn_im.ShowDialog();
                this.Cursor = Cursors.Default;
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;
                Form fn_im = new fn_rp_saidas_enttradas(txtAno.Text);
                csForms.fnOpacidade.Show();
                fn_im.ShowDialog();
                this.Cursor = Cursors.Default;
            }
        }
    }
}
