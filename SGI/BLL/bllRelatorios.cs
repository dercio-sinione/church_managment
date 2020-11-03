using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class bllRelatorios
    {
        public int Id { get; set; }
        

        //public bool registarSaida()
        //{
        //    if (cnx.cmd_Execute("call sp_saidas(0,'"+Descricao+"','"+Valor+"','"+Id_user+"')"))
        //        return true;
        //    else
        //        return false;
        //}

        public static DataTable tbSaidas(string Buscar)
        {
            cnx.adp_Execute("select * from vw_saidas where data_atual like '%" + Buscar + "%' or registado_por like '%" + Buscar + "%' or descricao like '%" + Buscar + "%'  order by id desc");
            return cnx.Tabela;
        }

        public static DataTable tbCaixa()
        {
            //cnx.adp_Execute("select sum(Valor) from caixa");
            cnx.adp_Execute("call select_tot_caixa()");
            return cnx.Tabela;
        }

        public static DataTable tbEntradas(string Buscar)
        {
            cnx.adp_Execute("select * from vw_estatistica_entradas_mes where Ano like '%" + Buscar + "%'");
            return cnx.Tabela;
        }

        public static DataTable tbEntradas_saidas(string Buscar)
        {
            cnx.adp_Execute("select * from vw_estatistica_entradas_saidas where Ano like '%" + Buscar + "%'");
            return cnx.Tabela;
        }

        public static DataTable tb_membros()
        {
            cnx.adp_Execute("select * from vw_estatistica_membros");
            return cnx.Tabela;
        }

    }
}
