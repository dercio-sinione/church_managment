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
    public partial class fn_Criar_conta : Form
    {
        DTO.dtoMembros c = new DTO.dtoMembros();
        public fn_Criar_conta(string nome,string acesso,string username)
        {
            InitializeComponent();
            txtNome.Text = nome;
            cbxAcesso.SelectedItem = acesso;
            txtUser.Text = username;
            lbAcesso.Text = "Nível de Acesso: " + acesso;
            csRestricoes.add_Cmb_HANDELDE(cbxAcesso);
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            c.SalvarConta(csForms.id,txtUser.Text,cbxAcesso.SelectedItem.ToString(),txtSenha.Text,txtConfSenha.Text);
        }

        private void fn_Criar_conta_FormClosing(object sender, FormClosingEventArgs e)
        {
            csForms.fnOpacidade.Hide();
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
