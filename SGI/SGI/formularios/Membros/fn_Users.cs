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
    public partial class fn_Users : Form
    {
        DTO.dtoMembros c = new DTO.dtoMembros();
        public fn_Users()
        {
            InitializeComponent();
        }

        private void dgv_setting()
        {
            try
            {
                dgv.Columns["ID"].Visible = false;
                dgv.Columns["BI"].Visible = false;
                //dgv.Columns["Email"].Visible = false;
                //dgv.Columns["Acesso"].Visible = false;
                ////dgv.Columns["nome_usuario"].Visible = false;
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
                this.Cursor = Cursors.WaitCursor;
                dgv.DataSource = c.tb(pesquisa, "");
                dgv_setting();
                this.Cursor = Cursors.Default;
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
            }
        }
        private void fn_Users_Load(object sender, EventArgs e)
        {
            Refresh("");
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            csForms.CloseThis(this);
        }

        private void fn_Users_FormClosing(object sender, FormClosingEventArgs e)
        {
            csForms.CloseThis(this);
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            Refresh(txtPesquisar.Text);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desejas eliminar a conta selecionada?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                c.Eliminar_Conta((int)dgv.Rows[dgv.CurrentRow.Index].Cells["Id"].Value);
                Refresh("");
            }
        }
    }
}
