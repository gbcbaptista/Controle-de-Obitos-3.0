using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Controle_de_Obitos_2._0
{
    class DeclaracaoDeObitoDB
    {
        public static string Numero_Da_DO;
        public static int Status_Da_DO;
        public static int PROAIM;
        public static int found = 0;
        public static string[] Declaracoes;


        public static void ConsultaDO(string DO_Number, string TypeOfSearch)
        {
            MySqlConnection conexao = ConexaoDB.getInstancia().getConexao();

            if (TypeOfSearch == "RetrievAllNotUsed")
            {
                try
                {
                    MySqlCommand comando = ConexaoDB.openConexao(conexao);

                    comando.CommandText = "SELECT Numero_da_DO FROM declaracao_de_obitos WHERE Status_da_DO = 1";
                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader["Numero_da_DO"] == null)
                        {
                            MessageBox.Show("Nenhuma DO Disponivel!!");
                        }
                        else
                        {
                            MessageBox.Show("Listando DOs Disponiveis!");
                            //Recuperar e Ler Todas DOs Disponiveis----------------------------------------------------------------------
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
            else if (TypeOfSearch == "RetrievAllCanceledPendent")
            {
                try
                {
                    MySqlCommand comando = ConexaoDB.openConexao(conexao);

                    comando.CommandText = "SELECT Numero_da_DO FROM declaracao_de_obitos WHERE Status_da_DO = 3 AND PROAIM = 1";
                    MySqlDataReader reader = comando.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        if (reader["Numero_da_DO"] == null)
                        {
                            MessageBox.Show("Nenhuma DO pendente!");
                        }
                        else
                        {

                            //MessageBox.Show("DOs Recuperadas!");
                            
                        }
                    }

                }
                catch(MySqlException msql)
                {
                    MessageBox.Show(msql.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
            else
            {
                try
                {
                    MySqlCommand comando = ConexaoDB.openConexao(conexao);
                    string DO_NumberWithASpas = ConexaoDB.putAspas(DO_Number);

                    comando.CommandText = "SELECT Status_da_DO FROM declaracao_de_obitos WHERE Numero_da_DO = " + DO_NumberWithASpas + ";";
                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        
                        if (reader["Status_da_DO"] == null)
                        {
                            MessageBox.Show("DO não encontrada!");
                        }
                        else
                        {
                            int retrievedStatus = Convert.ToInt32(reader["Status_da_DO"]);
                            DeclaracaoDeObitoDB.found = 1;
                            DeclaracaoDeObitoDB.Status_Da_DO = retrievedStatus;
                        }
                    }
                    if (DeclaracaoDeObitoDB.found == 0)
                    {
                        MessageBox.Show("Declaração de Óbito não encontrado!");
                    }

                }
                catch(MySqlException msql)
                {
                    MessageBox.Show(msql.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }

            

        }
        public static void CancelaDO(string DO_number)
        {
            MySqlConnection conexao = ConexaoDB.getInstancia().getConexao();

            try
            {
                MySqlCommand comando = ConexaoDB.openConexao(conexao);
                string DO_numberWithAspas = ConexaoDB.putAspas(DO_number);

                comando.CommandText = "UPDATE `controle_de_obitos`.`declaracao_de_obitos` SET `Status_da_DO` = '3' WHERE (`Numero_da_DO` = " + DO_numberWithAspas + ");" +
                    "UPDATE `controle_de_obitos`.`declaracao_de_obitos` SET `PROAIM` = '1' WHERE(`Numero_da_DO` = " + DO_numberWithAspas + "); ";
                int valorRetorno = comando.ExecuteNonQuery();
                if (valorRetorno < 1)
                {
                    MessageBox.Show("Erro ao salvar!");
                }
                else
                {
                    MessageBox.Show("DO Cancelada!");
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



        public static void INSERTdo(string DO_Number_Insert)
        {
            MySqlConnection conexao = ConexaoDB.getInstancia().getConexao();
            try
            {
                MySqlCommand comando = ConexaoDB.openConexao(conexao);

                
                    string value = ConexaoDB.putAspas(DO_Number_Insert);

                    comando.CommandText = "INSERT INTO `controle_de_obitos`.`declaracao_de_obitos` (`Numero_da_DO`) VALUES("+value+");";

                int valorRetorno = comando.ExecuteNonQuery();
                if (valorRetorno < 1)
                {
                    MessageBox.Show("Erro ao salvar!");
                }
                else
                {
                    MessageBox.Show("DO salva!");
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

