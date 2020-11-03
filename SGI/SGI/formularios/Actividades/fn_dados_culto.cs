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
    public partial class fn_dados_culto : Form
    {
        DTO.dtoCulto c = new DTO.dtoCulto();
        public fn_dados_culto()
        {
            InitializeComponent();
            try
            {
                //***************Restrições
                csRestricoes.add_Number(txtHomens);
                csRestricoes.add_Number(txtMulheres);
                csRestricoes.add_Number(txtAdolescentes);
                csRestricoes.add_Number(txtCriancas);
                csRestricoes.add_Number(txtDizimos);
                csRestricoes.add_Number(txtOfertas);
                csRestricoes.add_Number(txtAlmas);
                csRestricoes.add_Number(txtTotal);
                csForms.tb_info= c.tb_dados_culto(csForms.id);
                //*****************Pegar dados
                txtHomens.Text = csForms.tb_info.Rows[0]["num_homens"].ToString();
                txtMulheres.Text = csForms.tb_info.Rows[0]["num_mulheres"].ToString();
                txtAdolescentes.Text = csForms.tb_info.Rows[0]["num_adolescentes"].ToString();
                txtCriancas.Text = csForms.tb_info.Rows[0]["num_criancas"].ToString();
                txtAlmas.Text = csForms.tb_info.Rows[0]["Tot_almas"].ToString();
                txtDizimos.Text = decimal.Ceiling(decimal.Parse(csForms.tb_info.Rows[0]["dizimo"].ToString())).ToString();
                txtOfertas.Text = decimal.Ceiling(decimal.Parse(csForms.tb_info.Rows[0]["oferta"].ToString())).ToString();
                txtTotal.Text = csForms.tb_info.Rows[0]["Total"].ToString();
            }
            catch (Exception)
            {
            }
        }

        private void VF()
        {
            if (txtHomens.Text == string.Empty)
            {
                txtHomens.Text = "0";
            }
            if (txtMulheres.Text == string.Empty)
            {
                txtMulheres.Text = "0";
            }
            if (txtCriancas.Text == string.Empty)
            {
                txtCriancas.Text = "0";
            }
            if (txtAdolescentes.Text == string.Empty)
            {
                txtAdolescentes.Text = "0";
            }
            if (txtDizimos.Text == string.Empty)
            {
                txtDizimos.Text = "0";
            }
            if (txtOfertas.Text == string.Empty)
            {
                txtOfertas.Text = "0";
            }
        }
        private void CalcularValor()
        {
            try
            {
                txtTotal.Text = (decimal.Parse(txtDizimos.Text) + decimal.Parse(txtOfertas.Text)).ToString();
            }
            catch (Exception)
            {
            }
        }
        private void CalcularAlmas()
        {
            try
            {
                txtAlmas.Text= (int.Parse(txtHomens.Text) +int.Parse(txtMulheres.Text)+ int.Parse(txtAdolescentes.Text) + int.Parse(txtCriancas.Text)).ToString();
            }
            catch (Exception)
            {
            }
        }
        private void pcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fn_dados_culto_FormClosing(object sender, FormClosingEventArgs e)
        {
            csForms.tb_info = new DataTable();
            csForms.fnOpacidade.Hide();
        }

       
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            VF();
            CalcularAlmas();
            CalcularValor();
            c.editarDadosCulto(csForms.id,int.Parse(txtHomens.Text),int.Parse(txtMulheres.Text),int.Parse(txtAdolescentes.Text),int.Parse(txtCriancas.Text),decimal.Parse(txtOfertas.Text),decimal.Parse(txtDizimos.Text));
        }

        private void txtDizimos_TextChanged(object sender, EventArgs e)
        {
            CalcularValor();
        }

        private void txtOfertas_TextChanged(object sender, EventArgs e)
        {
            CalcularValor();
        }

        private void txtCriancas_TextChanged(object sender, EventArgs e)
        {
            CalcularAlmas();
        }

        private void txtAdolescentes_TextChanged(object sender, EventArgs e)
        {
            CalcularAlmas();
        }

        private void txtMulheres_TextChanged(object sender, EventArgs e)
        {
            CalcularAlmas();
        }

        private void txtHomens_TextChanged(object sender, EventArgs e)
        {
            CalcularAlmas();
        }
    }
}
