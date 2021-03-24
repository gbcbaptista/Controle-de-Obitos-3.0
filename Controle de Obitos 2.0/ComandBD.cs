using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Obitos_2._0
{
    class ComandBD
    {
        public static void ComandSelectToBD(string SQLComand, Action<MySqlDataReader> DataFunction)
        {
            MySqlConnection conexao = ConexaoDB.getInstancia().getConexao();
            try
            {
                MySqlCommand comando = ConexaoDB.openConexao(conexao);
                comando.CommandText = SQLComand;
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    DataFunction(reader);
                }

            }
            catch (MySqlException msql)
            {
                MessageBox.Show("Erro no acesso ao banco SQL: " + msql.Message, "Erro");
            }
            finally
            {
                conexao.Close();
            }

        }

        public static void ComandInsertToBD(string SQLComand)
        {

            MySqlConnection conexao = ConexaoDB.getInstancia().getConexao();
            try
            {
                MySqlCommand comando = ConexaoDB.openConexao(conexao);
                comando.CommandText = SQLComand;
                int valorRetorno = comando.ExecuteNonQuery();
                if (valorRetorno < 1)
                {
                    MessageBox.Show("Falha ao Salvar...");
                }
                else
                {
                    MessageBox.Show("Registro realizado com Sucesso!");
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

        public static void ComandDeleteToBD(string SQLComand)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                MySqlConnection conexao = ConexaoDB.getInstancia().getConexao();
                try
                {
                    MySqlCommand comando = ConexaoDB.openConexao(conexao);
                    comando.CommandText = SQLComand;
                    int valorRetorno = comando.ExecuteNonQuery();
                }
                catch (MySqlException msql)
                {
                    MessageBox.Show(msql.Message);
                }
                finally
                {
                    conexao.Close();
                }

                MessageBox.Show("Registro apagado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public static void ComandUpdateBD(string SQLComand)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja atualizar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                MySqlConnection conexao = ConexaoDB.getInstancia().getConexao();
                try
                {
                    MySqlCommand comando = ConexaoDB.openConexao(conexao);
                    comando.CommandText = SQLComand;
                    int valorRetorno = comando.ExecuteNonQuery();
                }
                catch (MySqlException msql)
                {
                    MessageBox.Show(msql.Message);
                }
                finally
                {
                    conexao.Close();
                }
                MessageBox.Show("Registro atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        
    }
}
