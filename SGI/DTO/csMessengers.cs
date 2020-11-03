using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTO
{
    public static class csMessengers
    {
        public static void mymsg(int num_tipo,string mensagem, string titulo)
        {
            MessageBoxIcon icon = new MessageBoxIcon();
            if (num_tipo==0)
            {
                icon = MessageBoxIcon.Information;
            }
            else if (num_tipo == 1)
            {
                icon = MessageBoxIcon.Error;
            }
            else if (num_tipo == 3)
            {
                icon = MessageBoxIcon.Warning;
            }

            MessageBox.Show(mensagem, titulo.ToUpper(), MessageBoxButtons.OK, icon);       
        }

    }
}
