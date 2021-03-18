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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controle_de_obitosDataSet1.obitos'. Você pode movê-la ou removê-la conforme necessário.
            this.obitosTableAdapter.Fill(this.controle_de_obitosDataSet1.obitos);

        }


        
    }
}
