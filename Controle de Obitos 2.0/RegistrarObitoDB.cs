using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Controle_de_Obitos_2._0
{
    class RegistrarObitoDB
    {
        public static string User_Name;
        public static string Nome_Do_Paciente;
        public static string Data_Do_Obito;
        public static string Data_De_Nascimento_Do_Paciente;
        public static string Tipo_De_Obito;
        public static string DO_Number;
        public static string Causa_Do_Obito;
        public static string Nome_Do_Medico;


        public RegistrarObitoDB()
        {

        }

        
        public static void SaveIML(string UserName, string NomeDoPaciente, string DataDoObito, string DataDeNascimentoDoPaciente, string TipoDeObito, string NomeDoMedico)
        {
            RegistrarObitoDB.User_Name = UserName;
            RegistrarObitoDB.Nome_Do_Paciente = NomeDoPaciente;
            RegistrarObitoDB.Data_Do_Obito = DataDoObito.Substring(6, 4) + "-" + DataDoObito.Substring(3, 2) + "-" + DataDoObito.Substring(0, 2);
            RegistrarObitoDB.Data_De_Nascimento_Do_Paciente = DataDeNascimentoDoPaciente.Substring(6, 4) + "-" + DataDeNascimentoDoPaciente.Substring(3, 2) + "-" + DataDeNascimentoDoPaciente.Substring(0, 2);
            RegistrarObitoDB.Tipo_De_Obito = TipoDeObito;
            RegistrarObitoDB.Nome_Do_Medico = NomeDoMedico;
            Console.WriteLine(RegistrarObitoDB.Data_Do_Obito);
            Console.WriteLine(RegistrarObitoDB.Data_De_Nascimento_Do_Paciente);
            SaveBD(2);
        }

        public static void SaveSVO(string UserName, string NomeDoPaciente, string DataDoObito, string DataDeNascimentoDoPaciente, string TipoDeObito, string NomeDoMedico)
        {
            RegistrarObitoDB.User_Name = UserName;
            RegistrarObitoDB.Nome_Do_Paciente = NomeDoPaciente;
            RegistrarObitoDB.Data_Do_Obito = DataDoObito.Substring(6, 4) + "-" + DataDoObito.Substring(3, 2) + "-" + DataDoObito.Substring(0, 2);
            RegistrarObitoDB.Data_De_Nascimento_Do_Paciente = DataDeNascimentoDoPaciente.Substring(6, 4) + "-" + DataDeNascimentoDoPaciente.Substring(3, 2) + "-" + DataDeNascimentoDoPaciente.Substring(0, 2);
            RegistrarObitoDB.Tipo_De_Obito = TipoDeObito;
            RegistrarObitoDB.Nome_Do_Medico = NomeDoMedico;
            Console.WriteLine(RegistrarObitoDB.Data_Do_Obito);
            Console.WriteLine(RegistrarObitoDB.Data_De_Nascimento_Do_Paciente);
            SaveBD(3);
        }
        public static void SaveNormalObito(string UserName, string NomeDoPaciente, string DataDoObito, string DataDeNascimentoDoPaciente, string TipoDeObito, string DONumber, string CausaDoObito, string NomeDoMedico)
        {
            RegistrarObitoDB.User_Name = UserName;
            RegistrarObitoDB.Nome_Do_Paciente = NomeDoPaciente;
            RegistrarObitoDB.Data_Do_Obito = DataDoObito.Substring(6, 4) + "-" + DataDoObito.Substring(3, 2) + "-" + DataDoObito.Substring(0, 2);
            RegistrarObitoDB.Data_De_Nascimento_Do_Paciente = DataDeNascimentoDoPaciente.Substring(6, 4) + "-" + DataDeNascimentoDoPaciente.Substring(3, 2) + "-" + DataDeNascimentoDoPaciente.Substring(0, 2);
            RegistrarObitoDB.Tipo_De_Obito = TipoDeObito;
            RegistrarObitoDB.DO_Number = DONumber;
            RegistrarObitoDB.Causa_Do_Obito = CausaDoObito;
            RegistrarObitoDB.Nome_Do_Medico = NomeDoMedico;
            Console.WriteLine("Dados colocados na classe!");
            SaveBD(1);
        }

        public static void SaveBD(int TypeOFObito)
        {

            MySqlConnection conexao = ConexaoDB.getInstancia().getConexao();
            try
            {
                MySqlCommand comando = ConexaoDB.openConexao(conexao);

                if (TypeOFObito == 1)
                {
                    string value1 = ConexaoDB.putAspas(RegistrarObitoDB.User_Name);
                    string value2 = ConexaoDB.putAspas(RegistrarObitoDB.Nome_Do_Paciente);
                    string value3 = ConexaoDB.putAspas(RegistrarObitoDB.Data_Do_Obito);
                    string value4 = ConexaoDB.putAspas(RegistrarObitoDB.Data_De_Nascimento_Do_Paciente);
                    string value6 = ConexaoDB.putAspas(RegistrarObitoDB.DO_Number);
                    string value7 = ConexaoDB.putAspas(RegistrarObitoDB.Causa_Do_Obito);
                    string value8 = ConexaoDB.putAspas(RegistrarObitoDB.Nome_Do_Medico);

                    comando.CommandText = "INSERT INTO `controle_de_obitos`.`obitos` (`User_Name`, `Nome_Do_Paciente`, `Data_do_Obito`, `Data_de_Nascimento_do_Paciente`, `Tipo_De_Obito`, `DO_Number`, `Causa_Do_Obito`, `Doctor_Name`) VALUES(" + value1 + ", " + value2 + ", " + value3 + ", " + value4 + ", 1, " + value6 + ", " + value7 + ", " + value8 + ");" + "UPDATE `controle_de_obitos`.`declaracao_de_obitos` SET `Status_da_DO` = '2' WHERE (`Numero_da_DO` = " + value6 + ");";
                }
                else if (TypeOFObito == 2)
                {
                    string value1 = ConexaoDB.putAspas(RegistrarObitoDB.User_Name);
                    string value2 = ConexaoDB.putAspas(RegistrarObitoDB.Nome_Do_Paciente);
                    string value3 = ConexaoDB.putAspas(RegistrarObitoDB.Data_Do_Obito);
                    string value4 = ConexaoDB.putAspas(RegistrarObitoDB.Data_De_Nascimento_Do_Paciente);
                    string value7 = ConexaoDB.putAspas(RegistrarObitoDB.Nome_Do_Medico);
                    comando.CommandText = "INSERT INTO `controle_de_obitos`.`obitos` ( `User_Name`, `Nome_Do_Paciente`, `Data_do_Obito`, `Data_de_Nascimento_do_Paciente`, `Tipo_De_Obito`, `DO_Number`, `Doctor_Name`) VALUES(" + value1 + ", " + value2 + ", " + value3 + ", " + value4 + ", 2, 'IML', " + value7 + "); ";

                }
                else
                {
                    string value1 = ConexaoDB.putAspas(RegistrarObitoDB.User_Name);
                    string value2 = ConexaoDB.putAspas(RegistrarObitoDB.Nome_Do_Paciente);
                    string value3 = ConexaoDB.putAspas(RegistrarObitoDB.Data_Do_Obito);
                    string value4 = ConexaoDB.putAspas(RegistrarObitoDB.Data_De_Nascimento_Do_Paciente);
                    string value7 = ConexaoDB.putAspas(RegistrarObitoDB.Nome_Do_Medico);
                    comando.CommandText = "INSERT INTO `controle_de_obitos`.`obitos` ( `User_Name`, `Nome_Do_Paciente`, `Data_do_Obito`, `Data_de_Nascimento_do_Paciente`, `Tipo_De_Obito`, `DO_Number`, `Doctor_Name`) VALUES(" + value1 + ", " + value2 + ", " + value3 + ", " + value4 + ", 3, 'SVO'," + value7 + "); ";
                }

                    int valorRetorno = comando.ExecuteNonQuery();
                if (valorRetorno < 1)
                {
                    MessageBox.Show("Erro ao salvar!");
                }
                else
                {
                    MessageBox.Show("Salvo!");
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
