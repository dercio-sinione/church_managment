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
    public partial class fn_cargos : Form
    {
        DTO.dtoCargos c = new DTO.dtoCargos();
        public fn_cargos()
        {
            InitializeComponent();
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            csForms.CloseThis(this);
        }

        private void fn_cargos_Load(object sender, EventArgs e)
        {
            try
            {
                csForms.id = 0;
                dgv.DataSource = c.tb("");
                csForms.PegarLinha(dgv);
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
                dgv.DataSource = c.tb(txtPesquisar.Text);
            }
            catch (Exception)
            {
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja eliminar o cargo selecionado?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            c.eliminarCargo(csForms.id);
            dgv.DataSource = c.tb("");
            csForms.id = 0;
        }

        private void dgvCargos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                csForms.PegarLinha(dgv);
            }
            catch (Exception)
            {
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                csForms.PegarLinha(dgv);
                fn_addcargos.nome = dgv.Rows[dgv.CurrentRow.Index].Cells[1].Value.ToString();
                csForms.CallAdd(this, new fn_addcargos("edit"));
                dgv.DataSource = c.tb("");
                dgv.Rows[csForms.linha].Selected = true;
            }
            catch (Exception)
            {
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            csForms.CallAdd(this, new fn_addcargos("add"));
            dgv.DataSource = c.tb("");
            dgv.Rows[csForms.linha].Selected=true;
        }

        
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void fn_cargos_FormClosing(object sender, FormClosingEventArgs e)
        {
            csForms.CloseThis(this);            
        }
    }
}
