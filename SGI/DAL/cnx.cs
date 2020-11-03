using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace DAL
{
    public class cnx
    {
        public static MySqlConnection Conect { get; set; }
        public static MySqlDataAdapter Adp { get; set; }
        public static MySqlCommand Cmd { get; set; }
        public static DataTable Tabela { get; set; }
        public static void dbOnn(bool ligar)
        {
            if (ligar)
            {
                Conect = new MySqlConnection("server=localhost;user id=root;database=db_igreja");
                Adp = new MySqlDataAdapter();
                Cmd = new MySqlCommand();
                Tabela = new DataTable();
                Conect.Open();
            }
            else
            {
                Conect = new MySqlConnection();
                Conect.Close();
                Conect.Dispose();
            }
        }

        public static bool cmd_Execute(string comando)
        {
            try
            {
                dbOnn(true);
                cnx.Cmd = new MySqlCommand(comando, Conect);
                cnx.Cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                dbOnn(false);
            }
        }

        public static bool cmd_Execute_with_img(string comando, byte[] imagem)
        {
            try
            {
                dbOnn(true);
                cnx.Cmd = new MySqlCommand(comando, Conect);
                cnx.Cmd.Parameters.AddWithValue("@imagem1", imagem);
                cnx.Cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                dbOnn(false);
            }
        }

        public static DataTable adp_Execute(string comando)
        {
            try
            {
                dbOnn(true);
                Tabela.Clear();
                Adp.SelectCommand =new MySqlCommand(comando,Conect);
                Adp.Fill(Tabela);
            }
            catch (Exception ms)
            {
                MessageBox.Show("Erro ao selecionar os dados \n "+ms.Message);
            }
            finally
            {
                dbOnn(false);
            }
            return Tabela;
        }
    }
}
