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
    public partial class fn_entradas : Form
    {
        DTO.dto_out_in c = new DTO.dto_out_in();
        public fn_entradas()
        {
            InitializeComponent();
        }


        private void dgv_setting()
        {
            try
            {
                dgv.Columns["Id"].Visible = false;
                dgv.Columns["Dizimo"].HeaderText = "Dízimos";
                dgv.Columns["data_c"].HeaderText = "Data Registada";
                dgv.Columns["Registado_por"].HeaderText = "Registado Por";
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
                dgv.DataSource = c.tb_entradas(pesquisa);
                dgv_setting();
                this.Cursor = Cursors.Default;
            }
            catch (Exception)
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void fn_entradas_Load(object sender, EventArgs e)
        {
            Refresh("");
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            Refresh(txtPesquisar.Text);
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            Refresh("");
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            csForms.CloseThis(this);
        }

        private void fn_entradas_FormClosing(object sender, FormClosingEventArgs e)
        {
            csForms.CloseThis(this);
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                csForms.tb_info = c.tb_entradas(txtPesquisar.Text);
                csForms.CallAdd(this, new fn_imprimir_vw_entradas());
                this.Cursor = Cursors.Default;
            }
            catch (Exception)
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
