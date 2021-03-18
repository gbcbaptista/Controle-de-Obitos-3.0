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
    public partial class ExcluirDO : Form
    {
        public ExcluirDO()
        {
            InitializeComponent();
        }

        private void btnExcluirDO_Click(object sender, EventArgs e)
        {
            if (txtNumeroDaDO.Text != String.Empty)
            {
                string do_delete = ConexaoDB.putAspas(txtNumeroDaDO.Text);
                string SQLCommand = "DELETE FROM `controle_de_obitos`.`declaracao_de_obitos` WHERE (`Numero_da_DO` = " + do_delete + ");";

                ComandBD.ComandDeleteToBD(SQLCommand);
                txtNumeroDaDO.Text = String.Empty;
            }
            
        }
    }
}
