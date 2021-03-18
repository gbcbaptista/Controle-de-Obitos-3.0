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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controle_de_obitosDataSet3.obitos'. Você pode movê-la ou removê-la conforme necessário.
            this.obitosTableAdapter.Fill(this.controle_de_obitosDataSet3.obitos);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.obitosTableAdapter.Fill(this.controle_de_obitosDataSet3.obitos);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.obitosTableAdapter.JANEIRO(this.controle_de_obitosDataSet3.obitos);
        }

        private void btnFEVEREIRO_Click(object sender, EventArgs e)
        {
            this.obitosTableAdapter.FEVEREIRO(this.controle_de_obitosDataSet3.obitos);
        }

        private void btnMarco_Click(object sender, EventArgs e)
        {
            this.obitosTableAdapter.MARÇO(this.controle_de_obitosDataSet3.obitos);
        }

        private void btnAbril_Click(object sender, EventArgs e)
        {
            this.obitosTableAdapter.ABRIL(this.controle_de_obitosDataSet3.obitos);
        }

        private void btnMaio_Click(object sender, EventArgs e)
        {
            this.obitosTableAdapter.MAIO(this.controle_de_obitosDataSet3.obitos);
        }

        private void btnJunho_Click(object sender, EventArgs e)
        {
            this.obitosTableAdapter.JUNHO(this.controle_de_obitosDataSet3.obitos);
        }
    }    
}
