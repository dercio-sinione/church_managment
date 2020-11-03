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
    public partial class fn_saida : Form
    {
        DTO.dto_out_in c = new DTO.dto_out_in();
        public fn_saida()
        {
            InitializeComponent();
        }

        private void PegarLinha()
        {
            try
            {
                csForms.linha = dgv.CurrentRow.Index;
                csForms.id = int.Parse(dgv.Rows[dgv.CurrentRow.Index].Cells["Id"].Value.ToString());
            }
            catch (Exception)
            {
            }
        }

        private void dgv_setting()
        {
            try
            {
                
                dgv.Columns["Id"].Visible = false;
                dgv.Columns["id_user"].Visible = false;
                dgv.Columns["descricao"].Visible = false;
                dgv.Columns["descricao"].HeaderText = "Descrição";
                dgv.Columns["data_atual"].HeaderText = "Data";
                dgv.Columns["registado_por"].HeaderText = "Registado por";
                
            }
            catch (Exception)
            {
            }
        }

        private void Refresh(string pesquisa)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                dgv.DataSource = c.tb_saidas(pesquisa);
                dgv_setting();
                dgv.Rows[csForms.linha].Selected = true;
                rtxtDescricao.Text = "    " + dgv.Rows[csForms.linha].Cells["descricao"].Value.ToString();
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

        private void fn_saida_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja eliminar o cargo selecionado?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            PegarLinha();
            c.eliminarSaida(csForms.id);
            Refresh("");
            csForms.id = 0;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rtxtDescricao.Text = "    " + dgv.Rows[dgv.CurrentRow.Index].Cells["descricao"].Value.ToString();
            PegarLinha();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            Refresh("");
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                PegarLinha();
                fn_addSaidas.descricao = dgv.Rows[csForms.linha].Cells["descricao"].Value.ToString();
                fn_addSaidas.valor = decimal.Ceiling(decimal.Parse(dgv.Rows[csForms.linha].Cells["valor"].Value.ToString()));
                csForms.CallAdd(this, new fn_addSaidas("edit"));
                Refresh("");
            }
            catch (Exception ms)
            {
                DTO.csMessengers.mymsg(3, ms.Message, "Atenção");
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                PegarLinha();
                csForms.CallAdd(this, new fn_addSaidas("add"));
                Refresh("");
            }
            catch (Exception ms)
            {
                DTO.csMessengers.mymsg(3, ms.Message, "Atenção");
            }
        }
        private void fn_saida_Load(object sender, EventArgs e)
        {
            Refresh("");
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

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                csForms.tb_info = c.tb_saidas(txtPesquisar.Text);
                csForms.CallAdd(this, new fn_imprimir_saidas());
                this.Cursor = Cursors.Default;
            }
            catch (Exception)
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
