using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BLL;

namespace DTO
{
    public class dto_out_in
    {
        BLL.out_in c = new out_in();
        public bool registarSaida(string descricao,decimal valor,int id_user)
        {
            if (id_user <= 0)
            {
                csMessengers.mymsg(3, "Informe o Id do usuário", "atenção");
                return false;
            }
            if (valor <= 0)
            {
                csMessengers.mymsg(3, "Esta valor não é válido para efectuar uma saída", "atenção");
                return false;
            }
            if (descricao == string.Empty)
            {
                csMessengers.mymsg(3, "Insira o motivo desta saída", "atenção");
                return false;
            }

            c.Descricao = descricao;
            c.Valor = valor;
            c.Id_user = id_user;

            if (!c.registarSaida())
                return false;

            csMessengers.mymsg(0, "Saída registada com sucesso", "Saída");
            return true;
          }

        public bool editarSaida(int id,string descricao, decimal valor, int id_user)
        {
            if (id_user <= 0)
            {
                csMessengers.mymsg(3, "Informe o Id do usuário", "atenção");
                return false;
            }
            if (valor <= 0)
            {
                csMessengers.mymsg(3, "Esta valor não é válido para efectuar uma saída", "atenção");
                return false;
            }

            if (descricao == string.Empty)
            {
                csMessengers.mymsg(3, "Insira o motivo desta saída", "atenção");
                return false;
            }

            c.Id = id;
            c.Descricao = descricao;
            c.Valor = valor;
            c.Id_user = id_user;

            if (!c.editarSaida())
                return false;

            csMessengers.mymsg(0, "Saída registada com sucesso", "Saída");
            return true;
        }



        public bool eliminarSaida(int id)
        {
            if (id <= 0)
            {
                csMessengers.mymsg(3, "Insira  o Id do regito a ser eliminado", "atenção");
                return false;
            }
            
            c.Id = id;

            if (!c.eliminarSaida())
                return false;

            csMessengers.mymsg(0, "Registo eliminado com sucesso", "Saidas");
            return true;
        }

        public DataTable tb_entradas(string buscar)
        {
            return c.AllEntradas(buscar);
        }

        public DataTable tb_saidas(string buscar)
        {
            return c.AllSaidas(buscar);
        }
    }

}
