using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Controle_de_Obitos_2._0
{
    class Login
    {
        public static string user;
        public static string Name;
        public static string userPassword;
        public static int access;
        public static bool  verified = false;
        public static int found = 0;
        public static string changedUserPassword;

        public Login(string usersLogin, string usersPassword)
        {
            user = usersLogin;
            userPassword = usersPassword;
            this.makeLogin();

        }
        

        public void makeLogin()
        {
            string userWithAspas = ConexaoDB.putAspas(Login.user);
            string SQLComand = "SELECT User_Name, Name, passwd, Access FROM user_data WHERE User_Name =" + userWithAspas;
            ComandBD.ComandSelectToBD(SQLComand, RetrievUserData);
            if (Login.found == 0)
            {
                MessageBox.Show("Usuário não encontrado");
            }
            if (Login.verified)
            { 
                MainScreen mainScreen = new MainScreen();
                mainScreen.StartPosition = FormStartPosition.CenterScreen;
                LoginScreen.ActiveForm.Visible = false;
                mainScreen.ShowDialog();
            }
        }
        //Função Suporte SELECT
        public void RetrievUserData(MySqlDataReader reader)
        {
            Login.found = 1;
            if (reader["User_Name"] == null)
            {
                MessageBox.Show("Usuário não encontrado!");
            }
            else
            {
                string retrievedUser = reader["User_Name"].ToString();
                string retrievedName = reader["Name"].ToString();
                string retrievedPwd = reader["Passwd"].ToString();
                int retrievedAccess = Convert.ToInt32(reader["Access"]);
                if (retrievedUser == Login.user && retrievedPwd == Login.userPassword)
                {
                    Login.Name = retrievedName;
                    Login.access = retrievedAccess;
                    Login.verified = true;
                }
                else
                {
                    MessageBox.Show("Login ou Senha incorretos!");
                }
            }
        }

        public static void changePasswordUser(string receivedChangedPassword)
        {
            Login.changedUserPassword = receivedChangedPassword;
            MySqlConnection conexao = ConexaoDB.getInstancia().getConexao();

            try
            {
                MySqlCommand comando = ConexaoDB.openConexao(conexao);
                string changedUserPasswordWithAspas = ConexaoDB.putAspas(Login.changedUserPassword);
                string userWithAspas = ConexaoDB.putAspas(Login.user);

                comando.CommandText = "UPDATE controle_de_obitos.user_data SET passwd = " + changedUserPasswordWithAspas + " WHERE User_Name = " + userWithAspas +";";
                int valorRetorno = comando.ExecuteNonQuery();
                if (valorRetorno < 1)
                {
                    MessageBox.Show("Erro ao alterar!");
                }
                else
                {
                    MessageBox.Show("Salvo!");
                }
            }
            catch(MySqlException mysql)
            {
                MessageBox.Show(mysql.Message);
            }
            finally
            {
                conexao.Close();
            }

            

        }
        public static string lookForDoctor(string crm)
        {

            DoctorsDB.consultaCRM(crm);
            return DoctorsDB.NomeDoMedico;
        }

        public static int lookForDO(string DO_Number)
        {
            DeclaracaoDeObitoDB.ConsultaDO(DO_Number, "VerifyDO");
            return DeclaracaoDeObitoDB.Status_Da_DO;
        }

        public static void cancelandoDO(string Do_number)
        {
            DeclaracaoDeObitoDB.CancelaDO(Do_number);
        }

        
        public static void INSERT_do(string number)
        {
            DeclaracaoDeObitoDB.INSERTdo(number);
        }

        }

    }

