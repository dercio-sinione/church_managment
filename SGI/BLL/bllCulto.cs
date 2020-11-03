using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class bllCulto
    {
        public int Id { get; set; }
        public int IdMembro { get; set; }
        public int IdUser { get; set; }
        public string Tema { get; set; }
        public string Livro { get; set; }
        public string Capitulo { get; set; }
        
        //******** Dados do culto 
        public int Num_homens { get; set; }
        public int Num_mulheres { get; set; }
        public int Num_adolescentes { get; set; }
        public int Num_criancas { get; set; }
        public decimal Dizimos { get; set; }
        public decimal Ofertas { get; set; }

        public bool inserirCulto()
        {
            if (cnx.cmd_Execute("call sp_culto ('"+IdMembro+"','"+Tema+"','"+Livro+"','"+Capitulo+"','"+IdUser+"')"))
                return true;
            else
                return false;
        }


        public bool editarDadosCulto()
        {
            if (cnx.cmd_Execute("call sp_dados_culto ('" + 1 + "','" + Id + "','" + Num_homens + "','" + Num_mulheres + "','" + Num_adolescentes + "','" + Num_criancas + "','" + Ofertas + "','" + Dizimos + "')"))
                return true;
            else
                return false;
        }
        
        public bool eliminarCulto()
        {
            if (cnx.cmd_Execute("call delete_culto('" + Id + "')"))
                return true;
            else
                return false;
        }

        public DataTable AllCultos(string Buscar)
        {
            cnx.adp_Execute("select * from vw_cultos where Pregador like '%" + Buscar + "%' or tema like '%" + Buscar + "%' or Livro like '%" + Buscar + "%' or data like '%" + Buscar + "%' order by id desc,data desc");
            return cnx.Tabela;
        }

        public DataTable AllDadosCultos(int Buscar)
        {
            cnx.adp_Execute("select *,(num_homens+num_mulheres+num_adolescentes+num_criancas) 'Tot_almas',(oferta+dizimo) 'Total' from dados_culto where id_culto='" + Buscar + "'");
            return cnx.Tabela;
        }

        public DataTable tb_select_member(string busca)
        {

           cnx.adp_Execute("select ID,Nome,Apelido,Tel1,imagem from vw_membros where nome like concat('%','" + busca + "','%') or apelido like '%" + busca + "' limit 5");   

            return cnx.Tabela;
        }

    }
}
