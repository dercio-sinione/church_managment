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
    public partial class fn_info_membross : Form
    {
        public fn_info_membross(string tipo)
        {
            InitializeComponent();

            this.Cursor = Cursors.WaitCursor;

            if (tipo == "perfil")
            {
                csForms.tb_info = new DataTable();
                csForms.tb_info = DTO.dtoMembros.tbPerfil(csForms.id_user);
                csForms.linha = 0;
            }

            txtNome.Text = csForms.tb_info.Rows[csForms.linha]["Nome"].ToString();
            txtApelido.Text = csForms.tb_info.Rows[csForms.linha]["Apelido"].ToString();
            txtBI.Text = csForms.tb_info.Rows[csForms.linha]["BI"].ToString();
            txtPai.Text = csForms.tb_info.Rows[csForms.linha]["Pai"].ToString();
            txtMae.Text = csForms.tb_info.Rows[csForms.linha]["Mae"].ToString();
            txtIdade.Text = csForms.tb_info.Rows[csForms.linha]["Idade"].ToString();
            txtSexo.Text = (csForms.tb_info.Rows[csForms.linha]["Sexo"].ToString() == "M") ? "Masculino" : "Feminino";
            txtData.Text = DateTime.Parse(csForms.tb_info.Rows[csForms.linha]["data_n"].ToString()).ToString("yyyy-MM-dd");
            txtResidencia.Text = csForms.tb_info.Rows[csForms.linha]["Residencia"].ToString();
            txtEmail.Text = csForms.tb_info.Rows[csForms.linha]["Email"].ToString();
            txtTel1.Text = csForms.tb_info.Rows[csForms.linha]["Tel1"].ToString();
            txtTel2.Text = csForms.tb_info.Rows[csForms.linha]["Tel2"].ToString();
            txtAcesso.Text = csForms.tb_info.Rows[csForms.linha]["Acesso"].ToString();
            txtEstado_civil.Text = csForms.tb_info.Rows[csForms.linha]["estado_civil"].ToString();
            txtEstado.Text = csForms.tb_info.Rows[csForms.linha]["Estado"].ToString();
            pc_Imagem.Image = (csForms.tb_info.Rows[csForms.linha]["imagem"].ToString() != string.Empty) ? csFoto.CvByteParaImage((byte[])csForms.tb_info.Rows[csForms.linha]["imagem"]) : null;
            this.Cursor = Cursors.Default;
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fn_info_membross_FormClosing(object sender, FormClosingEventArgs e)
        {
            csForms.fnOpacidade.Hide();
        }
    }
}
