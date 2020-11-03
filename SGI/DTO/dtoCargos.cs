using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BLL;

namespace DTO
{
    public class dtoCargos
    {
        bllCargos c = new bllCargos();
        public bool inserirCargo(string nome)
        {
            if (nome==string.Empty)
            {
                csMessengers.mymsg(3,"Insira o nome do Cargo a ser adicionado", "atenção");
                return false;
            }
            
            c.Nome = nome;

            if (!c.inserirCargo())
                return false;

            csMessengers.mymsg(0,"Cargo adicionado com sucesso", "Cargos");
            return true;
            }

            public bool inserirCargo_Membro(int id_membro, int id_cargo)
            {
                if (id_membro <= 0)
                {
                csMessengers.mymsg(3, "Insere o ID do membro", "atenção");
                return false;
                }
                if (id_cargo <= 0)
                {
                    csMessengers.mymsg(3, "Insere o ID do cargo", "atenção");
                    return false;
                }

                c.Id_membro = id_membro;
                c.Id_cargo = id_cargo;

                if (!c.inserirCargo_Membro())
                return false;

            csMessengers.mymsg(0, "Cargo adicionado com sucesso", "Cargos");
            return true;
        }
        public bool editarCargo(int id,string nome)
        {
            if (id <= 0)
            {
                csMessengers.mymsg(3,"Insira  o Id do Cargo a ser editado", "atenção");
                return false;
            }
            if (nome == string.Empty)
            {
                csMessengers.mymsg(3,"Insira o nome do Cargo a ser editado", "atenção");
                return false;
            }

            c.Id = id;
            c.Nome = nome;

            if (!c.editarCargo())
                return false;

            csMessengers.mymsg(0,"Cargo editado com sucesso", "Cargos");
            return true;
        }

        public bool eliminarCargo(int id)
        {
            if (id <= 0)
            {
                csMessengers.mymsg(3, "Insira  o Id do Cargo a ser eliminado", "atenção");
                return false;
            }
            
            c.Id = id;

            if (!c.eliminarCargo())
                return false;

            csMessengers.mymsg(0, "Cargo eliminado com sucesso", "Cargos");
            return true;
        }

        public DataTable tb(string buscar)
        {
            return c.AllCargos(buscar);
        }

        public DataTable tb_cargosMembros(int id_membro)
        {
            return c.AllCargosMembros(id_membro);
        }

    }

}
