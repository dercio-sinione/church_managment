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
    public partial class fn_addActividades : Form
    {
        DTO.dtActividades c = new DTO.dtActividades();
        int id_tipo = 0;
        public static string descricao, tipo, data;
        public fn_addActividades(string tipo)
        {
            InitializeComponent();
            csRestricoes.add_Cmb_HANDELDE(cbxTipo);
            if (tipo!="add")
            {
                btn_Salvar.Text = "Editar          ";
                cbxTipo.SelectedItem = tipo;
                rtxtDescricao.Text = descricao;
                txtData.Text = DateTime.Parse(data.ToString()).ToString("yyyy-MM-dd");
                lbTitulo.Text = "Editar actividade";
            }
        }


        private void FullCombol()
        {
            try
            {
                csForms.tb_info = new DataTable();
                cbxTipo.Items.Clear();
                csForms.tb_info = c.tb_tipo_atos("");
                for (int i = 0; i < csForms.tb_info.Rows.Count; i++)
                {
                    cbxTipo.Items.Add(csForms.tb_info.Rows[i]["Nome"].ToString());
                }
                cbxTipo.SelectedIndex = 0;
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (btn_Salvar.Text.Trim()=="Registar")
            {
                if (c.inserir_actividade(id_tipo, rtxtDescricao.Text, csForms.id_user, txtData.Text))
                {
                    txtData.Clear();
                    rtxtDescricao.Clear();
                    csForms.id = 0;
                }
            }
            else
            {
                if (c.editar_actividade(csForms.id,id_tipo, rtxtDescricao.Text, csForms.id_user, txtData.Text))
                {
                    txtData.Clear();
                    rtxtDescricao.Clear();
                    csForms.id = 0;
                }
            }
        }

        private void fn_addActividades_Load(object sender, EventArgs e)
        {
            FullCombol();
        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                id_tipo = int.Parse(csForms.tb_info.Rows[cbxTipo.SelectedIndex][0].ToString());
            }
            catch (Exception)
            {
            }
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fn_addActividades_FormClosing(object sender, FormClosingEventArgs e)
        {
            csForms.fnOpacidade.Hide();
        }
    }
}
