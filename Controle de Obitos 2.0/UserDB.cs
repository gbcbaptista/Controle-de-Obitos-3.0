using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Controle_de_Obitos_2._0
{
    class UserDB
    {
        public static string User_ID;
        public static string Name;
        public static string User_Name;
        public static string passwd;
        public static string Access;

        public static void CreateUSER(string Name, string User_Name, string access)
        {
            MySqlConnection conexao = ConexaoDB.getInstancia().getConexao();

            try
            {
                MySqlCommand comando = ConexaoDB.openConexao(conexao);
                string NameWithAspas = ConexaoDB.putAspas(Name);
                string User_NameWithAspas = ConexaoDB.putAspas(User_Name);
                string accessWithAspas = ConexaoDB.putAspas(access);

                comando.CommandText = "INSERT INTO `controle_de_obitos`.`user_data` (`Name`, `User_Name`, `Access`) VALUES(" + NameWithAspas + "," + User_NameWithAspas + "," + accessWithAspas + "); ";
                int valorRetorno = comando.ExecuteNonQuery();
                if (valorRetorno < 1)
                {
                    MessageBox.Show("Erro ao criar!");
                }
                else
                {
                    MessageBox.Show("Usuário Criado!");
                }

            }
            catch (MySqlException msql)
            {
                MessageBox.Show(msql.Message);
            }
            finally
            {
                conexao.Close();
            }

            
        }
    }
}
