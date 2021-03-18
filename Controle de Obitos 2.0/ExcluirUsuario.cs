using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Obitos_2._0
{
    public partial class ExcluirUsuario : Form
    {
        public ExcluirUsuario()
        {
            InitializeComponent();
        }

        private void btnRegistraMedico_Click(object sender, EventArgs e)
        {
            if (txtBoxUsuario.Text != String.Empty)
            {
                string user_delete = ConexaoDB.putAspas(txtBoxUsuario.Text);
                string SQLCommand = "DELETE FROM `controle_de_obitos`.`user_data` WHERE (`User_Name` = " + user_delete + ");";

                ComandBD.ComandDeleteToBD(SQLCommand);
                txtBoxUsuario.Text = String.Empty;
            }
            
        }
    }
}
