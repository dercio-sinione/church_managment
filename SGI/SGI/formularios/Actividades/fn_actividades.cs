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
    public partial class fn_actividades : Form
    {
        DTO.dtActividades c = new DTO.dtActividades();
        public fn_actividades()
        {
            InitializeComponent();
        }

        private void concluir(bool x, string pergunta)
        {
            try
            {
                if (MessageBox.Show(pergunta, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    c.Concluir((int)dgv.Rows[dgv.CurrentRow.Index].Cells["Id"].Value, x);
                    Actualizar();
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
            }
        }

        private void dgv_setting()
        {
            try
            {
                dgv.Columns["Id"].Visible = false;
                dgv.Columns["descricao"].Visible = false;
                dgv.Columns["descricao"].HeaderText = "Descrição";
                dgv.Columns["data_atual"].HeaderText = "Data Registada";
                dgv.Columns["data_marcada"].HeaderText = "Data Marcada";
                dgv.Columns["usuario"].HeaderText = "Registado Por";
            }
            catch (Exception)
            {
            }
        }
        private void Actualizar()
        {
            try
            {
                csForms.id = 0;
                dgv.DataSource = c.tb_atividades("");
                rtxtDescricao.Text ="    "+ dgv.Rows[dgv.CurrentRow.Index].Cells["descricao"].Value.ToString();
                dgv_setting();
                dgv.Rows[csForms.linha].Selected = true;
                this.Cursor = Cursors.Default;
            }
            catch (Exception)
            {
                this.Cursor = Cursors.Default;
            }
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

        private void fn_actividades_FormClosing(object sender, FormClosingEventArgs e)
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

        private void fn_actividades_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            PegarLinha();
            if (MessageBox.Show("Deseja eliminar a actividade selecionada?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            c.eliminar_atos(csForms.id);
            Actualizar(); 
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            Actualizar();            
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            dgv.DataSource = c.tb_atividades(txtPesquisar.Text);
            dgv_setting();
        }

        private void PegarLinha()
        {
            try
            {
                 csForms.id = (int)dgv.Rows[dgv.CurrentRow.Index].Cells[0].Value;
                csForms.linha = dgv.CurrentRow.Index;
                rtxtDescricao.Text = "    " + dgv.Rows[dgv.CurrentRow.Index].Cells["descricao"].Value.ToString();
            }
            catch (Exception)
            {
            }
        }
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PegarLinha();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            csForms.CallAdd(this,new fn_addActividades("add"));
            Actualizar();
        }

        private void dgv_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void dgv_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                rtxtDescricao.Text = "    " + dgv.Rows[dgv.CurrentRow.Index].Cells["descricao"].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                csForms.id = (int)dgv.Rows[dgv.CurrentRow.Index].Cells[0].Value;
                fn_addActividades.data = dgv.Rows[dgv.CurrentRow.Index].Cells["data_marcada"].Value.ToString();
                fn_addActividades.tipo = dgv.Rows[dgv.CurrentRow.Index].Cells["Tipo"].Value.ToString();
                fn_addActividades.descricao = dgv.Rows[dgv.CurrentRow.Index].Cells["descricao"].Value.ToString();
                csForms.CallAdd(this, new fn_addActividades("edit"));
                Actualizar();
            }
            catch (Exception)
            {
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            concluir(true, "Deseja  marcar esta actividade como concluida ?");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            concluir(false, "Deseja  marcar esta actividade como Pendente ?");
        }
    }
}
