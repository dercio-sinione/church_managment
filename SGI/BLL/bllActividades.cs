using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class bllActividades
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdTipo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string dataMarcada { get; set; }

        //public DataTable tabelaS;

        public bool inserir_Tipo_actividade()
        {
            if (cnx.cmd_Execute("insert into tipo_atos values (default,'" + Nome + "')"))
                return true;
            else
                return false;
        }

        public bool inserir_actividade()
        {
            if (cnx.cmd_Execute("call sp_actividades(0,'"+IdTipo+"','"+Descricao+"','"+IdUser+"','"+dataMarcada+"')"))
                return true;
            else
                return false;
        }

        public bool editar_actividade()
        {
            if (cnx.cmd_Execute("call sp_actividades('"+Id+"','" + IdTipo + "','" + Descricao + "','" + IdUser + "','" + dataMarcada + "')"))
                return true;
            else
                return false;
        }

        public bool editar_Tipo_actividade()
        {
            if (cnx.cmd_Execute("update tipo_atos set nome='" + Nome + "' where id='" + Id + "'"))
                return true;
            else
                return false;
        }

        public bool Concluir(bool X)
        {
            if (cnx.cmd_Execute("call sp_estado_atos('" + Id + "'," + X + ")"))
                return true;
            else
                return false;
        }

        public bool eliminar_Tipo_actividade()
        {
            if (cnx.cmd_Execute("call delete_tipo_atos ('" + Id + "')"))
                return true;
            else
                return false;
        }

        public bool eliminar_actividade()
        {
            if (cnx.cmd_Execute("delete from atos where id='" + Id + "'"))
                return true;
            else
                return false;
        }

        public DataTable AllTipo_actividade(string Buscar)
        {
            cnx.adp_Execute("select ID,Nome from tipo_atos where nome like '" + Buscar + "%' order by id");
            return cnx.Tabela;
        }

        public DataTable tb_atividades(string Buscar)
        {
            cnx.adp_Execute("select * from vw_actividades where tipo like '" + Buscar + "%' or descricao like '" + Buscar + "%' or estado like '" + Buscar + "%' order by id desc");
            return cnx.Tabela;
        }


        
    }
}
