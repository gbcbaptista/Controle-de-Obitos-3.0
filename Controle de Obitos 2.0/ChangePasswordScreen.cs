using System;
using System.Windows.Forms;

namespace Controle_de_Obitos_2._0
{
    public partial class ChangePasswordScreen : Form
    {
        public ChangePasswordScreen()
        {
            InitializeComponent();
        }

        private void btnChangingPassword_Click(object sender, EventArgs e)
        {
           if (newPasswordChange.Text == newPasswordChangeConfirm.Text)
            {
                string changedPassword = newPasswordChange.Text;
                Login.changePasswordUser(changedPassword);
                ChangePasswordScreen.ActiveForm.Close();
            }
           else
            {
                MessageBox.Show("As senhas não conferem!");
            }
        }
    }
}
