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
    public partial class fn_membros : Form
    {
        DTO.dtoMembros c = new DTO.dtoMembros();
        
        public static Form form_membro;
        
        public fn_membros()
        {
            InitializeComponent();
        }

        private void dgv_setting()
        {
            try
            {
                dgv.Columns["ID"].Visible = false;
                dgv.Columns["BI"].Visible = false;
                dgv.Columns["Aniversario"].Visible = false;
                dgv.Columns["Email"].Visible = false;
                dgv.Columns["Tel1"].Visible = false;
                dgv.Columns["Tel2"].Visible = false;
                dgv.Columns["Acesso"].Visible = false;
                dgv.Columns["imagem"].Visible = false;
                dgv.Columns["nome_usuario"].Visible = false;
                dgv.Columns["Sexo"].Visible = false;
                dgv.Columns["batizado"].Visible = false;
                dgv.Columns["data_n"].HeaderText = "Data";
                dgv.Columns["estado_civil"].HeaderText = "Estado Civíl";
            }
            catch (Exception)
            {
                //DTO.csMessengers.mymsg(3, ms.Message, "Atenção");
            }
        }

        private void Refresh(string pesquisa)
        {
            try
            {
                csForms.tb_info = new DataTable();
                this.Cursor = Cursors.WaitCursor;
                csForms.tb_info = c.tb(pesquisa, "All");
                dgv.DataSource = c.tb(pesquisa,"All");
                dgv_setting();
                dgv.Rows[csForms.linha].Selected = true;
                this.Cursor = Cursors.Default;
            }
            catch (Exception)
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void fn_membros_Load(object sender, EventArgs e)
        {
            try
            {
                csForms.tb_info = new DataTable();
                this.Cursor = Cursors.WaitCursor;
                csForms.tb_info = c.tb("ref", "All");
                dgv.DataSource = c.tb("ref", "All");
                dgv_setting();
                this.Cursor = Cursors.Default;
            }
            catch (Exception)
            {
                this.Cursor = Cursors.Default;
            }
        }


        private void fn_membros_FormClosing(object sender, FormClosingEventArgs e)
        {
            csForms.CloseThis(this);
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            csForms.CloseThis(this);
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            Refresh(txtPesquisar.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja eliminar o membro selecionado?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            csForms.PegarLinha(dgv);
            c.eliminarMembro(csForms.id);
            Refresh("");
            csForms.id = 0;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            csForms.PegarLinha(dgv);
        }
        
        
        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                csForms.PegarLinha(dgv);
                csForms.id = (int)dgv.Rows[dgv.CurrentRow.Index].Cells["Id"].Value;
                csForms.linha = dgv.CurrentRow.Index;
                csForms.CallAdd(this, new fn_addMembro("Edit"));
                Refresh("ref");
            }
            catch (Exception ms)
            {
                DTO.csMessengers.mymsg(3, ms.Message, "Atenção");
            }
        }
        private void btn_informacoes_Click(object sender, EventArgs e)
        {
            try
            {
                csForms.PegarLinha(dgv);
                csForms.id = (int)dgv.Rows[dgv.CurrentRow.Index].Cells["Id"].Value;
                csForms.linha = dgv.CurrentRow.Index;
                csForms.CallAdd(this, new fn_info_membross(""));
            }
            catch (Exception ms)
            {
                DTO.csMessengers.mymsg(3, ms.Message, "Atenção");
            }
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            Refresh("ref");
        }

        private void adicionarCargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            csForms.PegarLinha(dgv);
            csForms.CallAdd(this, new fn_addCargo_Membro(dgv.Rows[csForms.linha].Cells["Nome"].Value.ToString()));
        }

        private void verCargosAssociadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            csForms.PegarLinha(dgv);
            csForms.CallAdd(this, new fn_Cargos_Membro((byte[])dgv.Rows[csForms.linha].Cells["imagem"].Value, (string)dgv.Rows[csForms.linha].Cells["Nome"].Value, (string)dgv.Rows[csForms.linha].Cells["Apelido"].Value));
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            csForms.PegarLinha(dgv);
            csForms.CallAdd(this, new fn_Criar_conta((string)dgv.Rows[csForms.linha].Cells["Nome"].Value, (string)dgv.Rows[csForms.linha].Cells["Acesso"].Value, (string)dgv.Rows[csForms.linha].Cells["nome_usuario"].Value));
            Refresh("ref");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            c.estado(csForms.id, true);
            Refresh("ref");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            c.estado(csForms.id, false);
            Refresh("ref");
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Refresh("ref");
        }

    }
}
