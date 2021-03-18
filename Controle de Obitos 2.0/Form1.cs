using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Obitos_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controle_de_obitosDataSet.declaracao_de_obitos'. Você pode movê-la ou removê-la conforme necessário.
            this.declaracao_de_obitosTableAdapter.Fill(this.controle_de_obitosDataSet.declaracao_de_obitos);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Consulta!");

        }

    }
}
