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
    public partial class fn_menu : Form
    {
        public static Form form_selected;
        
        public fn_menu()
        {
            InitializeComponent();
        }

        private void Select_form(Form formulario){
            this.Cursor = Cursors.WaitCursor;
            form_selected =formulario;
            form_selected.Show();
            this.Hide();
            csForms.fnMenu = this;
            form_selected = null;
            this.Cursor = Cursors.Default;
        }
        private void Show_panel(Panel pn, string titulo)
        {
            pn.BringToFront();
            lbl_titulo.Text = titulo.ToUpper();
        }
        private void fn_menu_Load(object sender, EventArgs e)
        {
            userGrafico_Entradas1.BringToFront();
            Show_panel(pn_inicio, "Início");
            user_estatistica_membros1.Hide();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            Show_panel(pn_inicio, "Início");
            userGrafico_Entradas1.Show();
            user_estatistica_membros1.Hide();
            userGrafico_Entradas1.BringToFront();
        }

        private void btn_actividades_Click(object sender, EventArgs e)
        {
            userGrafico_Entradas1.Hide();
            user_estatistica_membros1.Hide();
            Show_panel(pn_actividades, "Menu de Actividades");
        }

        private void btn_caixa_Click(object sender, EventArgs e)
        {
            Show_panel(pn_caixa, "Menu de Caixa");
            userGrafico_Entradas1.Show();
            userGrafico_Entradas1.BringToFront();
            user_estatistica_membros1.Hide();
        }

        private void btn_cargos_Click(object sender, EventArgs e)
        {
            Show_panel(pn_cargos, "Menu de Cargos");
            user_estatistica_membros1.Hide();
        }

        private void btn_membros_Click(object sender, EventArgs e)
        {
            userGrafico_Entradas1.Hide();
            user_estatistica_membros1.Show();
            user_estatistica_membros1.BringToFront();
            Show_panel(pn_membros, "Menu de Membros");
        }

        private void btn_addCargos_Click(object sender, EventArgs e)
        {
            csForms.CallAdd(this,new fn_addcargos("add"));
        }

        private void btn_ls_cargos_Click(object sender, EventArgs e)
        {
            Select_form(new fn_cargos());
        }

        private void pc_close_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btn_tipo_actividade_Click(object sender, EventArgs e)
        {
            Select_form(new fn_tipo_actos());
        }

        private void pn_membros_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_addMembro_Click(object sender, EventArgs e)
        {
            Select_form(new fn_addMembro(""));
        }

        private void btn_listarMembros_Click(object sender, EventArgs e)
        {
            Select_form(new fn_membros());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Select_form(new fn_Users());
        }

        private void btnCulto_Click(object sender, EventArgs e)
        {
            Select_form(new fn_Culto());
        }

        private void fn_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void btnBatizados_Click(object sender, EventArgs e)
        {
            Select_form(new fn_batizados());
        }

        private void btnActividades_Click(object sender, EventArgs e)
        {
            Select_form(new fn_actividades());
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            Select_form(new fn_entradas());
        }

        private void btnSaidas_Click(object sender, EventArgs e)
        {
            Select_form(new fn_saida());
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            csForms.CallAdd(this, new fn_info_membross("perfil"));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbData.Text = DateTime.Now.ToShortDateString();
            lbHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnCaixaGeral_Click(object sender, EventArgs e)
        {
            csForms.CallAdd(this, new fnCaixa());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
