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
    public partial class fnCaixa : Form
    {
        public fnCaixa()
        {
            InitializeComponent();
        }

        private void fnCaixa_Load(object sender, EventArgs e)
        {
            try
            {
                txtValor.Text = DTO.dtoRelatorios.tb_Caixa().Rows[0][0].ToString();
            }
            catch (Exception)
            {
            }
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fnCaixa_FormClosing(object sender, FormClosingEventArgs e)
        {
            csForms.fnOpacidade.Hide();
        }
    }
}
