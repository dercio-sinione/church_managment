using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BLL;

namespace DTO
{
    public class dtoRelatorios
    {
        
        public static DataTable tb_entradas(string buscar)
        {
            return bllRelatorios.tbEntradas(buscar);
        }

        public static DataTable tb_entradas_saidas(string buscar)
        {
            return bllRelatorios.tbEntradas_saidas(buscar);
        }

        public static DataTable tb_saidas(string buscar)
        {
            return bllRelatorios.tbSaidas(buscar);
        }
        public static DataTable tb_Caixa()
        {
            return bllRelatorios.tbCaixa();
        }

        public static DataTable tb_membros()
        {
            return bllRelatorios.tb_membros();
        }
    }

}
