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
    public partial class fn_addMembro : Form
    {
        string sexo = null;
        DTO.dtoMembros m = new DTO.dtoMembros();
        public fn_addMembro(string tipo)
        {
            InitializeComponent();
            if (tipo == "Edit")
            {
                btn_add.Text = "EDITAR        ";
                txtNome.Text = csForms.tb_info.Rows[csForms.linha]["Nome"].ToString();
                txtApelido.Text = csForms.tb_info.Rows[csForms.linha]["Apelido"].ToString();
                txtBI.Text = csForms.tb_info.Rows[csForms.linha]["BI"].ToString();
                txtPai.Text = csForms.tb_info.Rows[csForms.linha]["Pai"].ToString();
                txtMae.Text = csForms.tb_info.Rows[csForms.linha]["Mae"].ToString();
                rbtM.Checked = (csForms.tb_info.Rows[csForms.linha]["Sexo"].ToString() == "M") ? true : false;
                txtData.Text = DateTime.Parse(csForms.tb_info.Rows[csForms.linha]["data_n"].ToString()).ToString("yyyy-MM-dd");
                txtResidencia.Text = csForms.tb_info.Rows[csForms.linha]["Residencia"].ToString();
                txtEmail.Text = csForms.tb_info.Rows[csForms.linha]["Email"].ToString();
                txtTel1.Text = csForms.tb_info.Rows[csForms.linha]["Tel1"].ToString();
                txtTel2.Text = csForms.tb_info.Rows[csForms.linha]["Tel2"].ToString();
                cbxEstado.SelectedItem = csForms.tb_info.Rows[csForms.linha]["estado_civil"].ToString();
                pc_Imagem.Image = (csForms.tb_info.Rows[csForms.linha]["imagem"].ToString() != string.Empty) ? csFoto.CvByteParaImage((byte[])csForms.tb_info.Rows[csForms.linha]["imagem"]) : null;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
            csRestricoes.add_Nome(txtNome);
            csRestricoes.add_Nome(txtApelido);
            csRestricoes.add_Nome(txtPai);
            csRestricoes.add_Nome(txtMae);
            csRestricoes.add_Nome(txtResidencia);
            csRestricoes.add_Email(txtEmail);
            csRestricoes.add_Number(txtTel1);
            csRestricoes.add_Number(txtTel2);
            csRestricoes.add_MaskedText(txtData);
            csRestricoes.add_Cmb_HANDELDE(cbxEstado);
            csRestricoes.add_txtUpper(txtBI);


        }

        private void LIMPAR()
        {
            txtApelido.Clear();
            txtNome.Clear();
            txtMae.Clear();
            txtPai.Clear();
            txtEmail.Clear();
            txtResidencia.Clear();
            txtTel1.Clear();
            txtTel2.Clear();
            txtBI.Clear();
            txtData.Clear();
            pc_Imagem.Image = null;
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            if (btn_add.Text.Trim() == "EDITAR")
            {
                this.Close();
            }
            else
            {
                csForms.fnMenu.Show();
                this.Hide();
            }
        }

        private void fn_addMembro_FormClosing(object sender, FormClosingEventArgs e)
        {
            csForms.fnOpacidade.Hide();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            sexo = (rbtM.Checked) ? "M" : "F";

            if (btn_add.Text.Trim() == "EDITAR")
            {
                if (m.Editar_Membro(csForms.id, txtBI.Text, txtNome.Text, txtApelido.Text, txtPai.Text, txtMae.Text, sexo, txtData.Text, cbxEstado.SelectedItem.ToString(), txtResidencia.Text, txtEmail.Text, csFoto.CvFotoToByte(pc_Imagem.Image), txtTel1.Text, txtTel2.Text))
                {
                    LIMPAR();
                }
            }
            else
            {
                if (m.Cadastrar_Membro(txtBI.Text, txtNome.Text, txtApelido.Text, txtPai.Text, txtMae.Text, sexo, txtData.Text, cbxEstado.SelectedItem.ToString(), txtResidencia.Text, txtEmail.Text, csFoto.CvFotoToByte(pc_Imagem.Image), txtTel1.Text, txtTel2.Text))
                {
                    LIMPAR();
                }
            }

        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            csFoto.TakeFoto(pc_Imagem);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pc_Imagem_DoubleClick(object sender, EventArgs e)
        {
            pc_Imagem.Image = null;
        }

    }
}
