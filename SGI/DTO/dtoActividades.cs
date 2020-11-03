using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BLL;

namespace DTO
{
    public class dtActividades
    {
        bllActividades a = new bllActividades();

        public bool inserir_actividade(int id_tipo,string descricao,int idUser,string dataMarcada)
        {
            if (id_tipo <= 0)
            {
                csMessengers.mymsg(3, "selecione o tipo de actividade a ser adicionada", "atenção");
                return false;
            }
            if (idUser <= 0)
            {
                csMessengers.mymsg(3, "Insira o Id do usuário.", "atenção");
                return false;
            }
            if (descricao == string.Empty)
            {
                csMessengers.mymsg(3, "Insira a descrição da actividade a ser adicionada", "atenção");
                return false;
            }
            if (dataMarcada == string.Empty)
            {
                csMessengers.mymsg(3, "Insira a a data marcada da actividade a ser adicionada", "atenção");
                return false;
            }

            a.dataMarcada = dataMarcada;
            a.Descricao = descricao;
            a.IdTipo = id_tipo;
            a.IdUser = idUser;

            if (!a.inserir_actividade())
                return false;

            csMessengers.mymsg(0, "Actividade adicionada com sucesso", "Actividades");
            return true;
        }

        public bool editar_actividade(int id,int id_tipo, string descricao, int idUser, string dataMarcada)
        {
            try
            {
            if (id <= 0)
            {
                csMessengers.mymsg(3, "selecione o id da actividade a ser editada", "atenção");
                return false;
            }
            if (id_tipo <= 0)
            {
                csMessengers.mymsg(3, "selecione o tipo de actividade a ser editada", "atenção");
                return false;
            }
            if (idUser <= 0)
            {
                csMessengers.mymsg(3, "Insira o Id do usuário.", "atenção");
                return false;
            }
            if (descricao == string.Empty)
            {
                csMessengers.mymsg(3, "Insira a descrição da actividade a ser editada", "atenção");
                return false;
            }
            if (dataMarcada == string.Empty)
            {
                csMessengers.mymsg(3, "Insira a a data marcada da actividade a ser editada", "atenção");
                return false;
            }

            a.Id = id;
            a.dataMarcada = dataMarcada;
            a.Descricao = descricao;
            a.IdTipo = id_tipo;
            a.IdUser = idUser;

            if (!a.editar_actividade())
                return false;

            csMessengers.mymsg(0, "Actividade editada com sucesso", "Actividades");
            return true;
            }
            catch (Exception ms)
            {
                csMessengers.mymsg(3, ms.Message, "Atenção");
                return false;
            }
        }

        public bool inserir_tipo_atos(string nome)
        {
            if (nome==string.Empty)
            {
                csMessengers.mymsg(3,"Insira o nome do tipo de actividade a ser adicionado", "atenção");
                return false;
            }
            
            a.Nome = nome;

            if (!a.inserir_Tipo_actividade())
                return false;

            csMessengers.mymsg(0,"Tipo de actividade adicionado com sucesso", "Actividades");
            return true;
            }

        public bool editar_tipo_atos(int id, string nome)
        {
            if (id <= 0)
            {
                csMessengers.mymsg(3,"Insira  o Id do tipo de actividade a ser editado", "atenção");
                return false;
            }
            if (nome == string.Empty)
            {
                csMessengers.mymsg(3,"Insira o nome do tipo de actividade a ser editado", "atenção");
                return false;
            }

            a.Id = id;
            a.Nome = nome;

            if (!a.editar_Tipo_actividade())
                return false;

            csMessengers.mymsg(0,"Tipo de actividade editado com sucesso", "Actividades");
            return true;
        }

        public bool eliminar_tipo_atos(int id)
        {
            if (id <= 0)
            {
                csMessengers.mymsg(3, "Insira  o Id do elemento a ser eliminado", "atenção");
                return false;
            }
            
            a.Id = id;

            if (!a.eliminar_Tipo_actividade())
                return false;

            csMessengers.mymsg(0, "Registo eliminado com sucesso", "Actividades");
            return true;
        }
        public bool eliminar_atos(int id)
        {
            if (id <= 0)
            {
                csMessengers.mymsg(3, "Insira  o Id do elemento a ser eliminado", "atenção");
                return false;
            }

            a.Id = id;

            if (!a.eliminar_actividade())
                return false;

            csMessengers.mymsg(0, "Registo eliminado com sucesso", "Actividades");
            return true;
        }

        public bool Concluir(int id, bool x)
        {
            if (id <= 0)
            {
                csMessengers.mymsg(3, "Insira  o Id da actividade", "atenção");
                return false;
            }


            a.Id = id;
            if (!a.Concluir(x))
                return false;

            csMessengers.mymsg(0, "Operação concluida com sucesso", "Actividades");
            return true;
        }
        public DataTable tb_tipo_atos(string buscar)
        {
            return a.AllTipo_actividade(buscar);
        }

        public DataTable tb_atividades(string buscar)
        {
            return a.tb_atividades(buscar);
        }
    }

}
