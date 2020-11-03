using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGI
{
    public partial class user_estatistica_membros : UserControl
    {
        int total_membros = 0;
        public user_estatistica_membros()
        {
            InitializeComponent();
        }


        private void FUll()
        {
            try
            {

                csForms.tb_info = DTO.dtoRelatorios.tb_membros();
                if (csForms.tb_info.Rows.Count<=0)
                    return;

                this.Cursor = Cursors.WaitCursor;
                lbTot_membros.Text = csForms.tb_info.Rows[0]["Tot_mebros"].ToString() + " membros registados";
                total_membros = int.Parse(csForms.tb_info.Rows[0]["Tot_mebros"].ToString());

                prb_feminino.MaximumValue = total_membros;
                prb_masculino.MaximumValue = total_membros;
                prb_adulto.MaximumValue = total_membros;
                prb_crianca.MaximumValue = total_membros;
                prb_adolescente.MaximumValue = total_membros;

                // Adicionar valores
                prb_masculino.Value = int.Parse(csForms.tb_info.Rows[0]["Tot_masculinos"].ToString());
                prb_feminino.Value = int.Parse(csForms.tb_info.Rows[0]["Tot_femininos"].ToString());
                prb_adulto.Value = int.Parse(csForms.tb_info.Rows[0]["Tot_adultos"].ToString());
                prb_crianca.Value = int.Parse(csForms.tb_info.Rows[0]["Tot_criancas"].ToString());
                prb_adolescente.Value = int.Parse(csForms.tb_info.Rows[0]["Tot_adolscentes"].ToString());

                lb_masc.Text = csForms.tb_info.Rows[0]["Tot_masculinos"].ToString();
                lb_fem.Text = csForms.tb_info.Rows[0]["Tot_femininos"].ToString();
                lb_adulto.Text = csForms.tb_info.Rows[0]["Tot_adultos"].ToString();
                lbCriancas.Text = csForms.tb_info.Rows[0]["Tot_criancas"].ToString();
                lb_adoles.Text = csForms.tb_info.Rows[0]["Tot_adolscentes"].ToString();

                taskAssociados.MaximumValue = total_membros;
                taskdesassociados.MaximumValue = total_membros;

                taskAssociados.Value = int.Parse(csForms.tb_info.Rows[0]["Tot_associado"].ToString());
                taskdesassociados.Value = int.Parse(csForms.tb_info.Rows[0]["Tot_desassociado"].ToString());
                lbassociados.Text = csForms.tb_info.Rows[0]["Tot_associado"].ToString();
                lbdesacossiados.Text = csForms.tb_info.Rows[0]["Tot_desassociado"].ToString();

                prbAcesso.MaximumValue = total_membros;
                prbSemAcesso.MaximumValue = total_membros;
                prbBatizados.MaximumValue = total_membros;
                prbNhBatizados.MaximumValue = total_membros;
                prbCasados.MaximumValue = total_membros;
                prbSolteiros.MaximumValue = total_membros;
                PrbViuvos.MaximumValue = total_membros;

                prbAcesso.Value = int.Parse(csForms.tb_info.Rows[0]["Tot_usuarios"].ToString());
                prbSemAcesso.Value = total_membros - int.Parse(csForms.tb_info.Rows[0]["Tot_usuarios"].ToString());

                lbAcesso.Text = csForms.tb_info.Rows[0]["Tot_usuarios"].ToString();
                lbSemAcesso.Text = (total_membros - int.Parse(csForms.tb_info.Rows[0]["Tot_usuarios"].ToString())).ToString();

                prbBatizados.Value = int.Parse(csForms.tb_info.Rows[0]["Tot_batizados"].ToString());
                prbNhBatizados.Value = int.Parse(csForms.tb_info.Rows[0]["Tot_nh_batizados"].ToString());
                prbCasados.Value = int.Parse(csForms.tb_info.Rows[0]["Tot_casados"].ToString());
                prbSolteiros.Value = int.Parse(csForms.tb_info.Rows[0]["Tot_solteiros"].ToString());
                PrbViuvos.Value = int.Parse(csForms.tb_info.Rows[0]["Tot_viuvos"].ToString());

                lbBatizados.Text = csForms.tb_info.Rows[0]["Tot_batizados"].ToString();
                lbNhBatizados.Text = csForms.tb_info.Rows[0]["Tot_nh_batizados"].ToString();
                lbCasados.Text = csForms.tb_info.Rows[0]["Tot_casados"].ToString();
                lbSolteiros.Text = csForms.tb_info.Rows[0]["Tot_solteiros"].ToString();
                lbViuvos.Text = csForms.tb_info.Rows[0]["Tot_viuvos"].ToString();
                
                this.Cursor = Cursors.Default;
            }
            catch (Exception)
            {
                this.Cursor = Cursors.Default;
                //MessageBox.Show(ms.Message);
            }
        }
        private void user_estatistica_membros_Load(object sender, EventArgs e)
        {
            FUll();
        }

        private void pcRefresh_Click(object sender, EventArgs e)
        {
            FUll();
        }

    }
}
