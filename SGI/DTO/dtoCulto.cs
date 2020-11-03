using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BLL;

namespace DTO
{
    public class dtoCulto
    {
        bllCulto c = new bllCulto(); 
        public bool inserirCulto(int idMembro,string tema,string livro,string capitulo,int idUser)
        {
            if (idMembro<=0)
            {
                csMessengers.mymsg(3,"Selecione o membro destinado a pregar", "atenção");
                return false;
            }
            if (tema == string.Empty)
            {
                csMessengers.mymsg(3, "Insira o tema do culto", "atenção");
                return false;
            }
            if (livro == string.Empty)
            {
                csMessengers.mymsg(3, "Insira o livro a ser pregado no culto", "atenção");
                return false;
            }
            if (capitulo == string.Empty)
            {
                csMessengers.mymsg(3, "Insira o capitolo a ser pregado no culto", "atenção");
                return false;
            }
            if (idUser <= 0)
            {
                csMessengers.mymsg(3, "Insira o Id do usuário", "atenção");
                return false;
            }

            c.IdMembro = idMembro;
            c.IdUser = idUser;
            c.Livro = livro;
            c.Tema = tema;
            c.Capitulo = capitulo;
           
            if (!c.inserirCulto())
                return false;

            csMessengers.mymsg(0,"Culto adicionado com sucesso", "Culto");
            return true;
            }

        public bool editarDadosCulto(int idCulto, int num_homens, int num_mulheres, int num_adolescentes,int num_criancas, decimal ofertas, decimal dizimos)
        {

            c.Id = idCulto;
            c.Num_homens = num_homens;
            c.Num_mulheres = num_mulheres;
            c.Num_adolescentes = num_adolescentes;
            c.Num_criancas = num_criancas;
            c.Ofertas = ofertas;
            c.Dizimos = dizimos;

            if (!c.editarDadosCulto())
                return false;

            csMessengers.mymsg(0, "Informações editadas com sucesso", "Culto");
            return true;
        }

        public bool eliminarCulto(int id)
        {
            if (id <= 0)
            {
                csMessengers.mymsg(3, "Insira  o Id do Cargo a ser eliminado", "atenção");
                return false;
            }
            
            c.Id = id;

            if (!c.eliminarCulto())
                return false;

            csMessengers.mymsg(0, "Culto eliminado com sucesso", "Culto");
            return true;
        }

        public DataTable tb(string buscar)
        {
            return c.AllCultos(buscar);
        }

        public DataTable tb_dados_culto(int buscar)
        {
            return c.AllDadosCultos(buscar);
        }

        public DataTable tb_membros(string buscar)
        {
            return c.tb_select_member(buscar);
        }
    }

}
