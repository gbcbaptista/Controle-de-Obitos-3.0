using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Controle_de_Obitos_2._0
{
    class DoctorsDB
    {
        public static string NomeDoMedico;
        public static string CRM;


        public static void consultaCRM(string crm)
        {
            MySqlConnection conexao = ConexaoDB.getInstancia().getConexao();

            try
            {
                MySqlCommand comando = ConexaoDB.openConexao(conexao);
                string CRMWithAspas = ConexaoDB.putAspas(crm);

                comando.CommandText = "SELECT Nome_do_Medico FROM doctor WHERE CRM =" + CRMWithAspas + ";";
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["Nome_do_Medico"] == null)
                    {
                        MessageBox.Show("CRM não encontrado!");
                    }
                    else
                    {
                        string retrievedDoctor = reader["Nome_do_Medico"].ToString();
                        DoctorsDB.NomeDoMedico = retrievedDoctor;
                    }
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
