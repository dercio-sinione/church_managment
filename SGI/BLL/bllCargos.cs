using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class bllCargos
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public int Id_membro { get; set; }

        public int Id_cargo { get; set; }
        //public DataTable tabelaS;

        public bool inserirCargo()
        {
            if (cnx.cmd_Execute("insert into cargos values (default,'" + Nome + "')"))
                return true;
            else
                return false;
        }

        public bool inserirCargo_Membro()
        {
            if (cnx.cmd_Execute("insert into cargos_membros values (default,'" + Id_membro + "','" + Id_cargo + "',now())"))
                return true;
            else
                return false;
        }

        public bool editarCargo()
        {
            if (cnx.cmd_Execute("update cargos set nome='"+Nome+"' where id='" + Id + "'"))
                return true;
            else
                return false;
        }

        public bool eliminarCargo()
        {
            if (cnx.cmd_Execute("delete from cargos where id='" + Id + "'"))
                return true;
            else
                return false;
        }

        public DataTable AllCargos(string Buscar)
        {
            cnx.adp_Execute("select ID,NOME from cargos where nome like '" + Buscar + "%' order by id");
            return cnx.Tabela;
        }
        //tb_cargosMembros
        public DataTable AllCargosMembros(int Buscar)
        {
            cnx.adp_Execute("select * from cargos where id not in (select id_cargo from cargos_membros where id_membro='"+Buscar+"')");
            return cnx.Tabela;
        }
    }
}
