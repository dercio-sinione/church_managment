using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;


namespace BLL
{
    public class bllMembros
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string BI { get; set; }
        public string Apelido { get; set; }
        public string Pai { get; set; }
        public string Mae { get; set; }
        public string Sexo { get; set; }
        public string Data_n { get; set; }
        public string Estado_civil { get; set; }
        public string Residencia { get; set; }
        public string Email { get; set; }
        public byte[] Imagem { get; set; }
        public string Acesso { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Senha { get; set; }
        string Comando;
 
        public bool inserirMembro()
        {

            Comando = "call sp_membros ('" + 0 + "','" + BI + "','" + Nome + "','" + Apelido + "','" + Pai
                    + "','" + Mae + "','" + Sexo + "','" + Data_n + "','" + Estado_civil + "','" + Residencia +
                    "','" + Email + "',@imagem1,'" + Tel1 + "','" + Tel2 + "')";
            
            if (cnx.cmd_Execute_with_img(Comando,Imagem))
                return true;
            else
                return false;
        }

        public bool SalvarConta()
        {

            Comando = "call sp_update_conta('" + Id + "','" + Acesso + "','" + Nome + "','" + Senha + "')";

            if (cnx.cmd_Execute_with_img(Comando, Imagem))
                return true;
            else
                return false;
        }

        public bool editarMembros()
        {
            Comando = "call sp_membros ('" + Id + "','" + BI + "','" + Nome + "','" + Apelido + "','" + Pai
                + "','" + Mae + "','" + Sexo + "','" + Data_n + "','" + Estado_civil + "','" + Residencia +
                "','" + Email + "',@imagem1,'" + Tel1 + "','" + Tel2 + "')";

            if (cnx.cmd_Execute_with_img(Comando, Imagem))
                return true;
            else
                return false;
        
        }

        //update membros set estado='associado' where id=
        public bool eliminarMembros()
        {
            if (cnx.cmd_Execute("call delete_members ('" + Id + "')"))
                return true;
            else
                return false;
        }

        public bool Estado(bool X)
        {
            if (cnx.cmd_Execute("call sp_estado('"+Id+"',"+X+")"))
                return true;
            else
                return false;
        }

        public bool Batizar(bool X)
        {
            if (cnx.cmd_Execute("call sp_batizar('" + Id + "'," + X + ")"))
                return true;
            else
                return false;
        }

        public bool eliminarCargoMembro()
        {
            if (cnx.cmd_Execute("delete from cargos_membros where id='" + Id + "'"))
                return true;
            else
                return false;
        }

        public bool eliminar_conta()
        {
            if (cnx.cmd_Execute("call sp_deleteConta ('" + Id + "')"))
                 return true;
            else
                return false;
        }

        public DataTable AllMembros(string Buscar)
        {
            if (Buscar == "ref")
            {
                cnx.adp_Execute("select * from vw_membros;");
            }
            else
            {
                cnx.adp_Execute("select * from vw_membros where Id like '" + Buscar + "%' or nome like '%" + Buscar + "%' or BI like '" + Buscar + "%' or apelido like '%" + Buscar + "%' or estado_civil like '" + Buscar + "%' or residencia like '%" + Buscar + "%' or pai like '%" + Buscar + "%' or mae like '%" + Buscar + "%' or estado like '" + Buscar + "%'  or email like '" + Buscar + "%' or idade like '" + Buscar + "%'");                    
            }
            return cnx.Tabela;
        }

        public static DataTable tb_Perfil(int Buscar)
        {
            cnx.adp_Execute("select * from vw_membros where id='"+Buscar+"'");
            return cnx.Tabela;
        }

        public DataTable AllMembros_Users(string Buscar)
        {
            cnx.adp_Execute("select Id,BI,Nome,Apelido,Nome_usuario,Email,Acesso,Estado from vw_membros where acesso!='nenhum' and (Id like '" + Buscar + "%' or nome like '%" + Buscar + "%' or BI like '" + Buscar + "%' or apelido like '%" + Buscar + "%' or email like '" + Buscar + "%')");
            return cnx.Tabela;
        }
        public DataTable AllMembrosBatismo(string Buscar,string batismo)
        {

            if (batismo=="todos")
            {
                Comando = "select id,BI,nome,apelido,idade,data_n,estado_civil,estado,Tel1,Tel2,estado,batizado from vw_membros where Id like '" + Buscar + "%' or nome like '%" + Buscar + "%' or BI like '" + Buscar + "%' or apelido like '%" + Buscar + "%' or estado_civil like '" + Buscar + "%' or estado like '" + Buscar + "%'";
            }
            else
	        {
                Comando = "select id,BI,nome,apelido,idade,data_n,estado_civil,estado,Tel1,Tel2,estado,batizado from vw_membros where batizado='" + batismo + "' and ( Id like '" + Buscar + "%' or nome like '%" + Buscar + "%' or BI like '" + Buscar + "%' or apelido like '%" + Buscar + "%' or estado_civil like '" + Buscar + "%' or estado like '" + Buscar + "%')";
	        }
            cnx.adp_Execute(Comando);
            return cnx.Tabela;
        }

        public DataTable AllCargosMembros(int id_membro)
        {
            cnx.adp_Execute("select cm.Id,c.nome 'Cargo', cm.Data_inicio from cargos_membros cm join cargos c on c.id=cm.id_cargo where cm.id_membro='"+id_membro+"'");
            return cnx.Tabela;
        }

        public static DataTable tbLogin(string nome,string senha)
        {
            cnx.adp_Execute("call sp_login('" + nome + "','"+senha+"')");
            return cnx.Tabela;
        }
    }
}
