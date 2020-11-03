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
    public partial class fn_tipo_actos : Form
    {
        DTO.dtActividades a = new DTO.dtActividades();
        public static int id = 0;
        public fn_tipo_actos()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            csForms.CallAdd(this, new fn_addTipo_actividade("add"));
            dgv.DataSource = a.tb_tipo_atos("");
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                fn_addTipo_actividade.nome = dgv.Rows[dgv.CurrentRow.Index].Cells[1].Value.ToString();
                csForms.CallAdd(this, new fn_addTipo_actividade("edit"));
                dgv.DataSource = a.tb_tipo_atos("");
            }
            catch (Exception)
            {
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = (int)dgv.Rows[dgv.CurrentRow.Index].Cells[0].Value;
            }
            catch (Exception)
            {
            }
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            csForms.CloseThis(this);
        }

        private void fn_tipo_actos_Load(object sender, EventArgs e)
        {
            try
            {
                dgv.DataSource = a.tb_tipo_atos("");
            }
            catch (Exception ms)
            {
                DTO.csMessengers.mymsg(3, ms.Message, "atenção");
            }

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgv.DataSource = a.tb_tipo_atos(txtPesquisar.Text);
            }
            catch (Exception)
            {
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja eliminar o tipo de actividade selecionado?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            a.eliminar_tipo_atos(id);
            dgv.DataSource = a.tb_tipo_atos("");
            id = 0;
        }

        private void fn_tipo_actos_FormClosing(object sender, FormClosingEventArgs e)
        {
            csForms.CloseThis(this);
        }
    }
}
