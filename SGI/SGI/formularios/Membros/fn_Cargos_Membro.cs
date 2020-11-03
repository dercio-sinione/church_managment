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
    public partial class fn_Cargos_Membro : Form
    {
        DTO.dtoMembros c = new DTO.dtoMembros();
        public fn_Cargos_Membro(byte[] img,string nome,string apelido)
        {
            InitializeComponent();
            pc_Imagem.Image =(img.ToString()!=string.Empty) ? csFoto.CvByteParaImage((byte[])img) : null;
            lbNome.Text ="Nome: "+ nome;
            lbApelido.Text = "Apelido: " + apelido;
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fn_Cargos_Membro_FormClosing(object sender, FormClosingEventArgs e)
        {
            csForms.fnOpacidade.Hide();
        }

        private void TakeDados() {
            try
            {
                dgv.DataSource = c.tbCargos(csForms.id);
                lbTot.Text = "Total de Cargos: " + dgv.Rows.Count;
            }
            catch (Exception)
            {
            }
        }
        private void fn_Cargos_Membro_Load(object sender, EventArgs e)
        {
            TakeDados();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show("Deseja eliminar este cargo do membro selecionado","Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    c.eliminarCargoMembro((int)dgv.Rows[dgv.CurrentRow.Index].Cells[0].Value);
                    TakeDados();
                }
        }
    }
}
