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
    public partial class fn_addTipo_actividade : Form
    {
        DTO.dtActividades a = new DTO.dtActividades();
        string tipo_form;
        public static string nome;
        
        public fn_addTipo_actividade(string tipo)
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
                if (a.inserir_tipo_atos(txtNome.Text))
                {
                    txtNome.Clear();
                }
            }
            else
            {
                if (a.editar_tipo_atos(fn_tipo_actos.id, txtNome.Text))
                {
                    txtNome.Clear();
                }
            }
        }

        private void pc_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_operar_Click(object sender, EventArgs e)
        {
            if (tipo_form == "add")
                Operacao(true);
            else
                Operacao(false);
        }

        private void fn_addTipo_actividade_Load(object sender, EventArgs e)
        {
            csRestricoes.add_Nome(txtNome);
            txtNome.Focus();
        }

        private void fn_addTipo_actividade_FormClosing(object sender, FormClosingEventArgs e)
        {
            csForms.fnOpacidade.Hide();
        }

        private void txtNome_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                if (tipo_form == "add")
                Operacao(true);
                else
                Operacao(false);
            }
        }
    }
}
