using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class dtoMembros
    {
        BLL.bllMembros m = new BLL.bllMembros();

        public bool Cadastrar_Membro(string Bi,string nome, string apelido, string pai, string mae, string sexo, 
            string data_n, string estado_civil, string residencia, string email, byte[] imagem,
            string tel1, string tel2)
        {
            if (nome==string.Empty)
            {
                csMessengers.mymsg(3,"Insira o nome do membro a ser cadastrado", "atenção");
                return false;
            }
            if (apelido == string.Empty)
            {
                csMessengers.mymsg(3, "Insira o apelido do membro a ser cadastrado", "atenção");
                return false;
            }
            if (pai == string.Empty)
            {
                csMessengers.mymsg(3, "Insira o nome do pai", "atenção");
                return false;
            }
            if (mae == string.Empty)
            {
                csMessengers.mymsg(3, "Insira o nome da mãe", "atenção");
                return false;
            }
            if (data_n == string.Empty)
            {
                csMessengers.mymsg(3, "Insira a data de nascimento do membro a ser cadastrado", "atenção");
                return false;
            }
            if (estado_civil == string.Empty)
            {
                csMessengers.mymsg(3, "Informe o estado civil do membro a ser cadastrado", "atenção");
                return false;
            }
            if (residencia == string.Empty)
            {
                csMessengers.mymsg(3, "Informe a residência do membro a ser cadastrado", "atenção");
                return false;
            }
            
            m.BI = Bi;
            m.Nome = nome;
            m.Apelido = apelido;
            m.Pai = pai;
            m.Mae = mae;
            m.Sexo = sexo;
            m.Data_n = data_n;
            m.Estado_civil = estado_civil;
            m.Residencia = residencia;
            m.Email = email;
            m.Imagem = imagem;
            m.Tel1 = tel1;
            m.Tel2 = tel2;

            if (!m.inserirMembro())
                return false;

            csMessengers.mymsg(0,"Membro Cadastrado com sucesso", "Membros");
            return true;
            }

        public bool SalvarConta(int id_membro, string username, string acesso, string senha, string confSenha)
        {
            if (username == string.Empty)
            {
                csMessengers.mymsg(3, "Insira o nome de usuário", "atenção");
                return false;
            }
            if (acesso == string.Empty)
            {
                csMessengers.mymsg(3, "Selecione o nível de acesso", "atenção");
                return false;
            }
            if (senha!=confSenha)
            {
                csMessengers.mymsg(3, "SAs senhas não são compactíveis", "atenção");
                return false;   
            }

            m.Id = id_membro;
            m.Nome = username;
            m.Acesso = acesso;
            m.Senha = senha;

            if (!m.SalvarConta())
                return false;

            csMessengers.mymsg(0, "Credenciais alteradas com sucesso", "Membros");
            return true;
        }

        public bool Editar_Membro(int id, string Bi, string nome, string apelido, string pai, string mae, string sexo,string data_n, string estado_civil, string residencia, string email, byte[] imagem,
            string tel1, string tel2)
        {
            if (id <= 0)
            {
                csMessengers.mymsg(3, "Insira o ID do membro a ser editado", "atenção");
                return false;
            }
            if (nome == string.Empty)
            {
                csMessengers.mymsg(3, "Insira o nome do membro a ser editado", "atenção");
                return false;
            }
            if (apelido == string.Empty)
            {
                csMessengers.mymsg(3, "Insira o apelido do membro a ser editado", "atenção");
                return false;
            }
            if (pai == string.Empty)
            {
                csMessengers.mymsg(3, "Insira o nome do pai", "atenção");
                return false;
            }
            if (mae == string.Empty)
            {
                csMessengers.mymsg(3, "Insira o nome da mãe", "atenção");
                return false;
            }
            if (data_n == string.Empty)
            {
                csMessengers.mymsg(3, "Insira a data de nascimento do membro a ser editado", "atenção");
                return false;
            }
            if (estado_civil == string.Empty)
            {
                csMessengers.mymsg(3, "Informe o estado civil do membro a ser editado", "atenção");
                return false;
            }
            if (residencia == string.Empty)
            {
                csMessengers.mymsg(3, "Informe a residência do membro a ser editado", "atenção");
                return false;
            }
            m.Id = id;
            m.BI = Bi;
            m.Nome = nome;
            m.Apelido = apelido;
            m.Pai = pai;
            m.Mae = mae;
            m.Sexo = sexo;
            m.Data_n = data_n;
            m.Estado_civil = estado_civil;
            m.Residencia = residencia;
            m.Email = email;
            m.Imagem = imagem;
            m.Tel1 = tel1;
            m.Tel2 = tel2;

            if (!m.editarMembros())
                return false;

            csMessengers.mymsg(0, "Membro Editado com sucesso", "Membros");
            return true;
        }

        public bool eliminarMembro(int id)
        {
            if (id <= 0)
            {
                csMessengers.mymsg(3, "Insira  o Id do membro a ser eliminado", "atenção");
                return false;
            }
            
            m.Id = id;

            if (!m.eliminarMembros())
                return false;

            csMessengers.mymsg(0, "Membro eliminado com sucesso", "Membros");
            return true;
        }

        public bool estado(int id,bool x)
        {
            if (id <= 0)
            {
                csMessengers.mymsg(3, "Insira  o Id do membro", "atenção");
                return false;
            }
            
            m.Id = id;

            if (!m.Estado(x))
                return false;

            csMessengers.mymsg(0, "Operação concluida com sucesso", "Membros");
            return true;
        }

        public bool batizar(int id,bool x)
        {
            if (id <= 0)
            {
                csMessengers.mymsg(3, "Insira  o Id do membro", "atenção");
                return false;
            }

            m.Id = id;

            if (!m.Batizar(x))
                return false;

            csMessengers.mymsg(0, "Operação concluida com sucesso", "Membros");
            return true;
        }

        public bool Eliminar_Conta(int id)
        {
            if (id <= 0)
            {
                csMessengers.mymsg(3, "Insira  o Id do membro", "atenção");
                return false;
            }

            m.Id = id;

            if (!m.eliminar_conta())
                return false;

            csMessengers.mymsg(0, "Operação concluida com sucesso", "Membros");
            return true;
        }


        public bool eliminarCargoMembro(int id)
        {
            if (id <= 0)
            {
                csMessengers.mymsg(3, "Insira  o Id do cargo a ser eliminado", "atenção");
                return false;
            }

            m.Id = id;
            
            if (!m.eliminarCargoMembro())
                return false;

            csMessengers.mymsg(0, "Cargo eliminado com sucesso", "Membros");
            return true;
        }

        public DataTable tb(string buscar,string tipo)
        {
            if (tipo=="All")
            {
                return m.AllMembros(buscar);
            }
            else
            {
                return m.AllMembros_Users(buscar);
            }
        }

        public DataTable tbCargos(int id)
        {
            return m.AllCargosMembros(id);
        }

        public DataTable tbBatizados(string buscar,string batizado)
        {
            return m.AllMembrosBatismo(buscar,batizado);
        }


        public static DataTable tbLogin(string nome, string senha)
        {
            return BLL.bllMembros.tbLogin(nome, senha);
        }

        public static DataTable tbPerfil(int id)
        {
            return BLL.bllMembros.tb_Perfil(id);
        }

        public static bool Login(string userName, string senha){
            try
            {
                DataTable tb = new DataTable();
                tb = tbLogin(userName, senha);
                
                if (tb.Rows.Count >0)
                {
                    if (userName != tb.Rows[0]["nome_usuario"].ToString())
                    {
                        csMessengers.mymsg(3, "O nome de Usuário digitado está incorrecto", "Atenção");
                        return false;
                    }
                    if (senha != tb.Rows[0]["senha"].ToString())
                    {
                        DTO.csMessengers.mymsg(3, "A senha digitada está incorrecto", "Atenção");
                        return false;
                    }
                    return true;
                }
                else
                {
                    DTO.csMessengers.mymsg(1, "Esta conta não está registada", "Atenção");
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

}
