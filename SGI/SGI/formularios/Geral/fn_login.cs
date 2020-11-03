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
    public partial class fn_login : Form
    {
        public static DataTable tb = new DataTable();
        fn_menu form_menu = new fn_menu();
        public fn_login()
        {
            InitializeComponent();
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void Logar()
        {
            this.Cursor = Cursors.WaitCursor;
            if (DTO.dtoMembros.Login(txtUser.Text, txtSenha.Text))
            {
                tb = DTO.dtoMembros.tbLogin(txtUser.Text, txtSenha.Text);
                form_menu.Show();
                csForms.id_user = int.Parse(tb.Rows[0][0].ToString());
                this.Hide();
            }
            this.Cursor = Cursors.Default;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Logar();
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                Logar();                
            }
        }

    }
}
