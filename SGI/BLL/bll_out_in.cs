using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class out_in
    {
        public int Id { get; set; }
        public string data { get; set; }
        public int Id_user { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        

        public bool registarSaida()
        {
            if (cnx.cmd_Execute("call sp_saidas(0,'"+Descricao+"','"+Valor+"','"+Id_user+"')"))
                return true;
            else
                return false;
        }

        public bool editarSaida()
        {
            if (cnx.cmd_Execute("call sp_saidas('"+Id+"','" + Descricao + "','" + Valor + "','" + Id_user + "')"))
                return true;
            else
                return false;
        }

        public bool eliminarSaida()
        {
            if (cnx.cmd_Execute("delete from saidas where id='"+Id+"'"))
                return true;
            else
                return false;
        }

        public DataTable AllEntradas(string Buscar)
        {
            cnx.adp_Execute("select * from vw_entradas where data_c like '%" + Buscar + "%' or Registado_por like '%" + Buscar + "%' order by id desc");
            return cnx.Tabela;
        }

        public DataTable AllSaidas(string Buscar)
        {
            cnx.adp_Execute("select * from vw_saidas where data_atual like '%" + Buscar + "%' or registado_por like '%" + Buscar + "%' or descricao like '%" + Buscar + "%' or descricao like '%" + Buscar + "%'  order by id desc");
            return cnx.Tabela;
        }
    }
}
