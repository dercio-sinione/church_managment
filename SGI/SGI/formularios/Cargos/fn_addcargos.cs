using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace SGI
{
    public partial class fn_addcargos : Form
    {
        dtoCargos c = new dtoCargos();
        string tipo_form;
        public static string nome;
        public fn_addcargos(string tipo)
        {
            InitializeComponent();
            btn_operar.Text = (tipo == "add") ? "ADICIONAR     " : "EDITAR          ";
            tipo_form = tipo;
            txtNome.Text = (tipo != "add") ? nome : string.Empty;
        }


        private void Operacao(bool x)
        {
            if (x)
            {
                if (c.inserirCargo(txtNome.Text))
                {
                    txtNome.Clear();
                }
            }
            else
            {
                if (c.editarCargo(csForms.id, txtNome.Text))
                {
                    txtNome.Clear();
                }
            }
        }
        private void pc_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fn_addcargos_FormClosing(object sender, FormClosingEventArgs e)
        {
            csForms.fnOpacidade.Hide();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tipo_form=="add")
                Operacao(true);
            else
                Operacao(false);
        }

        private void fn_addcargos_Load(object sender, EventArgs e)
        {
            csRestricoes.add_Nome(txtNome);
            txtNome.Focus();
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                if (tipo_form=="add")
                    Operacao(true);
                else
                    Operacao(false);
            }
        }
    }
}
