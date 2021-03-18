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
    public partial class ExcluirObito : Form
    {
        public ExcluirObito()
        {
            InitializeComponent();
        }

        private void btnRegistraMedico_Click(object sender, EventArgs e)
        {
            if (txtBoxNomeDoPaciente.Text != String.Empty && txtBoxNumeroDaDO.Text != String.Empty)
            {
                string nome_delete = ConexaoDB.putAspas(txtBoxNomeDoPaciente.Text);
                string do_delete = ConexaoDB.putAspas(txtBoxNumeroDaDO.Text);

                string SQLCommand = "DELETE FROM `controle_de_obitos`.`obitos` WHERE (`Nome_Do_Paciente` = " + nome_delete + " && `DO_Number` = " + do_delete + " );";

                ComandBD.ComandDeleteToBD(SQLCommand);
                txtBoxNomeDoPaciente.Text = String.Empty;
                txtBoxNumeroDaDO.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Preencha os dois campos!");
            }
        }
    }
}
