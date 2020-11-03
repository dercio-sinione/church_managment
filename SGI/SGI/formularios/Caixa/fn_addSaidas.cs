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
    public partial class fn_addSaidas : Form
    {
        DTO.dto_out_in c = new DTO.dto_out_in();
        public static decimal valor=0;
        public static string descricao;
        public fn_addSaidas(string tipo)
        {
            InitializeComponent();
            if (tipo!="add")
            {
                btn_Salvar.Text = "Editar         ";
                txtValor.Text = valor.ToString();
                rtxtDescricao.Text = descricao;
            }
            csRestricoes.add_Number(txtValor);
            csRestricoes.add_Number(txt_valor_caixa);
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fn_addSaidas_FormClosing(object sender, FormClosingEventArgs e)
        {
            csForms.fnOpacidade.Hide();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {

            if (decimal.Parse(txtValor.Text)>decimal.Parse(DTO.dtoRelatorios.tb_Caixa().Rows[0][0].ToString()))
            {
                DTO.csMessengers.mymsg(3,"Não é possivel efectuar esta operação porque não há valor suficiente na caixa","Atenção");
                return;
            }

            if (btn_Salvar.Text.Trim()=="Registar")
            {
                if (c.registarSaida(rtxtDescricao.Text, decimal.Parse(txtValor.Text), csForms.id_user))
                {
                    txtValor.Text = "0";
                    rtxtDescricao.Clear();
                }
            }
            else
            {
                if (c.editarSaida(csForms.id,rtxtDescricao.Text, decimal.Parse(txtValor.Text), csForms.id_user))
                {
                    txtValor.Text = "0";
                    rtxtDescricao.Clear();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fn_addSaidas_Load(object sender, EventArgs e)
        {
            try
            {
                txt_valor_caixa.Text = DTO.dtoRelatorios.tb_Caixa().Rows[0][0].ToString();
            }
            catch (Exception)
            {
            }
        }

    }
}
