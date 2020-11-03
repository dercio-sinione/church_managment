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
    public partial class fn_addCargo_Membro : Form
    {
        DTO.dtoCargos c = new DTO.dtoCargos();
        
        public fn_addCargo_Membro(string nome)
        {
            InitializeComponent();
            txtNome.Text = nome;
        }

        private void FullCombol()
        {
            try
            {
                csForms.id = 0;
                csForms.tb_info = new DataTable();
                cbxCargo.Items.Clear();
                csForms.tb_info = c.tb_cargosMembros(csForms.id);
                for (int i = 0; i < csForms.tb_info.Rows.Count; i++)
                {
                    cbxCargo.Items.Add(csForms.tb_info.Rows[i]["nome"].ToString());
                }
                cbxCargo.SelectedIndex = 0;
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
            }
        }
        private void fn_addCargo_Membro_Load(object sender, EventArgs e)
        {
            FullCombol();
        }

        private void pc_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fn_addCargo_Membro_FormClosing(object sender, FormClosingEventArgs e)
        {
            csForms.fnOpacidade.Hide();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                //csForms.id ::::::::::: indica o id do cargo
                 this.Cursor = Cursors.WaitCursor;
                 csForms.id = int.Parse(csForms.tb_info.Rows[cbxCargo.SelectedIndex][0].ToString());
                 c.inserirCargo_Membro(csForms.id, csForms.id);            
                 FullCombol();
                 this.Cursor = Cursors.Default;
            }
            catch (Exception)
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void cbxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                csForms.id = int.Parse(csForms.tb_info.Rows[cbxCargo.SelectedIndex][0].ToString());
            }
            catch (Exception)
            {
                
                throw;
            }
            //this.Cursor=Cursors.WaitCursor;
            //FullCombol();
            //this.Cursor=Cursors.Default;
        }



    }
}
