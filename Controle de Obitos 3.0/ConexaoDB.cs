using System.Configuration;
using MySql.Data.MySqlClient;

namespace Controle_de_Obitos_2._0
{
    public class ConexaoDB
    {
        private static readonly ConexaoDB instanciaMySQL = new ConexaoDB();
        
        public static ConexaoDB getInstancia()
        {
            return instanciaMySQL;
        }

        public MySqlConnection getConexao()
        {
            string conn = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ToString();
            return new MySqlConnection(conn);

            

        }

        public static MySqlCommand openConexao(MySqlConnection conexao)
        {
            conexao.Open();
            MySqlCommand comando = new MySqlCommand();
            return conexao.CreateCommand();
        }

        public static string putAspas(string text)
        {
            string withAspasText = '"' + text + '"';
            return withAspasText;
        }

    }

    
}
