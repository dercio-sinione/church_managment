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
    public partial class fn_Culto : Form
    {
        DTO.dtoCulto c = new DTO.dtoCulto();
        public fn_Culto()
        {
            InitializeComponent();
        }

        private void dgv_setting()
        {
            try
            {
                dgv.Columns["Id"].Visible = false;
                dgv.Columns["capitulo"].HeaderText = "Capítulo";
                dgv.Columns["usuario"].HeaderText = "Registado Por";
                dgv.Columns["capitulo"].MinimumWidth = 100;
                dgv.Columns["Membros"].MinimumWidth = 100;
                dgv.Columns["Livro"].MinimumWidth = 120;
                dgv.Columns["Data"].MinimumWidth = 100;
                dgv.Columns["Tema"].MinimumWidth = 230;
                dgv.Columns["usuario"].MinimumWidth = 200;
                dgv.Columns["pregador"].MinimumWidth = 200;

            }
            catch (Exception)
            {
            }
        }
        private void Actualizar()
        {
            try
            {
                dgv.DataSource = c.tb("");
                dgv_setting();
                dgv.Rows[csForms.linha].Selected = true;
            }
            catch (Exception)
            {
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            csForms.CallAdd(this, new fn_addCulto());
            Actualizar();
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            csForms.CloseThis(this);
        }

        private void fn_Culto_Load(object sender, EventArgs e)
        {
            try
            {
              dgv.DataSource = c.tb("");
              dgv_setting();
            }
            catch (Exception)
            {
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgv.DataSource = c.tb(txtPesquisar.Text);
            }
            catch (Exception)
            {
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            csForms.id = (int)dgv.Rows[dgv.CurrentRow.Index].Cells[0].Value;
            if (MessageBox.Show("Deseja eliminar o Culto selecionado?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            c.eliminarCulto(csForms.id);
            dgv.DataSource = c.tb("");
            csForms.id = 0;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           csForms.PegarLinha(dgv);
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                csForms.PegarLinha(dgv);
                csForms.CallAdd(this,new fn_dados_culto());
                Actualizar();
            }
            catch (Exception)
            {
            }
        }

        private void fn_Culto_FormClosing(object sender, FormClosingEventArgs e)
        {
            csForms.CloseThis(this);
        }
    }
}
