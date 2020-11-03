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
    public partial class fn_addCulto : Form
    {
        int idMembro;
        DTO.dtoCulto c = new DTO.dtoCulto();
        public fn_addCulto()
        {
            InitializeComponent();
        }


        private void dgv_settinf()
        {
            try
            {
                dgv.Columns["imagem"].Visible = false;
                dgv.Columns["ID"].Visible = false;
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
            }
        }
        private void TakeDados()
        {
            try
            {
                dgv_settinf();
                idMembro = (int)dgv.Rows[dgv.CurrentRow.Index].Cells["ID"].Value;
                txtCod.Text = dgv.Rows[dgv.CurrentRow.Index].Cells["ID"].Value.ToString();
                txtPregador.Text = dgv.Rows[dgv.CurrentRow.Index].Cells["Nome"].Value.ToString();
                pc_Imagem.Image = (dgv.Rows[dgv.CurrentRow.Index].Cells["imagem"].Value != null) ? csFoto.CvByteParaImage((byte[])dgv.Rows[dgv.CurrentRow.Index].Cells["imagem"].Value) : null;
            }
            catch (Exception)
            {
            }
        }

        private void fn_addCulto_FormClosing(object sender, FormClosingEventArgs e)
        {
            csForms.fnOpacidade.Hide();
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            dgv.DataSource = c.tb_membros(txtPesquisar.Text);
            TakeDados();
        }

        private void fn_addCulto_Load(object sender, EventArgs e)
        {
            dgv.DataSource = c.tb_membros("");
            TakeDados();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                TakeDados();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (c.inserirCulto(idMembro, txtTema.Text, txtLivro.Text, txtCapitulo.Text,csForms.id_user))
            {
                txtCod.Clear();
                txtPregador.Clear();
                txtTema.Clear();
                txtCapitulo.Clear();
                txtLivro.Clear();
                idMembro = 0;
            }
        }
    }
}
