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
    public partial class AdicionarMedico : Form
    {
        public AdicionarMedico()
        {
            InitializeComponent();
        }

        private void btnRegistraMedico_Click(object sender, EventArgs e)
        {
            if (txtBoxNomeDoMédico.Text != String.Empty && txtBoxCRM.Text != String.Empty)
            {
                string nameDoctor = ConexaoDB.putAspas(txtBoxNomeDoMédico.Text);
                string crmDoctor = ConexaoDB.putAspas(txtBoxCRM.Text);
                string SQLComand = "INSERT INTO `controle_de_obitos`.`doctor` (`Nome_do_Medico`, `CRM`) VALUES(" + nameDoctor + "," + crmDoctor + ");";
                ComandBD.ComandInsertToBD(SQLComand);
                txtBoxCRM.Text = String.Empty;
                txtBoxNomeDoMédico.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Preencha os dois Campos!");
            }
            
        }
    }
}
