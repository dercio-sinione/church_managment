using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data;

namespace SGI
{
    public class csForms
    {
        public static DataGridViewImageColumn ColumnEliminar, ColumnEditar, ColumnSelecionar;
        public int limite = 13, minLimite = 13, total = 0; //13 
        public static Form fnOpacidade = new fn_Opacity();
        public static Form fnMenu;
        public static DataTable tb_info = new DataTable();
        public static int id = 0, id_user=1,linha=0;
        public static void CallAdd(Form oldForm, Form new_form)
        {
            oldForm.Cursor = Cursors.WaitCursor;
            csForms.fnOpacidade.Show();
            new_form.ShowDialog();
            oldForm.Cursor = Cursors.Default;
        }

        public static void CloseThis(Form oldForm)
        {
            try
            {
                csForms.fnMenu.Show();
                oldForm.Hide();
            }
            catch (Exception)
            {
            }
        }

        public static void PegarLinha(DataGridView dgv)
        {
            try
            {
                csForms.id = (int)dgv.Rows[dgv.CurrentRow.Index].Cells["Id"].Value;
                csForms.linha = dgv.CurrentRow.Index;
            }
            catch (Exception)
            {
            }
        }

        //private void Full()
        //{
        //    try
        //    {
        //        gr_grafico1.DataSource = DTO.dtoRelatorios.tb_entradas("");
        //        gr_grafico1.Series["Series1"].LegendText = "Ofertas";
        //        gr_grafico1.Series["Series1"].XValueMember = "data_c";
        //        gr_grafico1.Series["Series1"].YValueMembers = "Oferta";

        //        gr_grafico1.Series["Series2"].LegendText = "Dízimos";
        //        gr_grafico1.Series["Series2"].XValueMember = "data_c";
        //        gr_grafico1.Series["Series2"].YValueMembers = "Dizimo";

        //        gr_grafico1.Series["Series3"].LegendText = "Total";
        //        gr_grafico1.Series["Series3"].XValueMember = "data_c";
        //        gr_grafico1.Series["Series3"].YValueMembers = "Total";
        //    }
        //    catch (Exception ms)
        //    {
        //        MessageBox.Show(ms.Message);
        //    }
        //}

    }
}
