using System;
using System.Windows.Forms;


namespace Controle_de_Obitos_2._0
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        public void LoginStart()
        {
            string usersLogin = textBox1.Text;
            string usersPassword = textBox2.Text;
            if (usersLogin !="" && usersPassword != "")
            {
                Login userLogin = new Login(usersLogin, usersPassword);
            }
            else
            {
                MessageBox.Show("Usuário e Senha devem ser preenchidos!");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginStart();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginStart();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoginScreen.ActiveForm.Close();
            Application.Exit();
        }
    }
}
