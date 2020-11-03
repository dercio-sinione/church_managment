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
    public partial class fn_batizados : Form
    {
        DTO.dtoMembros c = new DTO.dtoMembros();
        string batismo = "todos";
        public fn_batizados()
        {
            InitializeComponent();
        }

        private void Refresh(string pesquisa)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                dgv.DataSource = c.tbBatizados(pesquisa, batismo);
                this.Cursor = Cursors.Default;
                dgv.Columns["Id"].Visible = false;
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
            }
        }

        private void Batizar_membro(bool x,string pergunta)
        {
            try
            {
                if (MessageBox.Show(pergunta,"Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    c.batizar((int)dgv.Rows[dgv.CurrentRow.Index].Cells["id"].Value, x);
                    Refresh("");
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
            }
        }

        private void fn_batizados_Load(object sender, EventArgs e)
        {
            Refresh("");
        }

        private void rbtSim_CheckedChanged(object sender, EventArgs e)
        {
            batismo = "sim";
            Refresh("");
        }

        private void rbtNao_CheckedChanged(object sender, EventArgs e)
        {
            batismo = "não";
            Refresh("");
        }

        private void rbtTodos_CheckedChanged(object sender, EventArgs e)
        {
            batismo = "todos";
            Refresh("");
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            Refresh(txtPesquisar.Text);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Batizar_membro(true, "Deseja marcar este membro como batizado?");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Batizar_membro(false, "Deseja desmarcar este membro como batizado?");
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            Refresh("");
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            try
            {
                csForms.fnMenu.Show();
                this.Hide();
            }
            catch (Exception)
            {
            }
        }

        private void fn_batizados_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                csForms.fnMenu.Show();
                this.Hide();
            }
            catch (Exception)
            {
            }
        }
    }
}
