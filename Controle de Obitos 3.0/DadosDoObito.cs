using System;
using System.Windows.Forms;

namespace Controle_de_Obitos_2._0
{
    public partial class DadosDoObito : Form
    {
        public DadosDoObito()
        {
            InitializeComponent();
        }
        public static string User_Name;
        public static string Nome_Do_Paciente;
        public static string Data_do_Obito;
        public static string DO_Number ;
        public static string Data_de_Nascimento_do_Paciente;
        public static string Causa_Do_Obito;
        public static string Doctor_Name;
        public static string Tipo_De_Obito;
        

        private void DadosDoObito_Load(object sender, EventArgs e)
        {
            if (DadosDoObito.Tipo_De_Obito == "1")
            {
                lbl5.Text = "Causa do Óbito";
                lblDONumber.Text = DadosDoObito.DO_Number;
                lblCausaDoObito.Text = DadosDoObito.Causa_Do_Obito;
            }

            lblObitoUsuario.Text = DadosDoObito.User_Name;
            lblNomeDoPaciente.Text = DadosDoObito.Nome_Do_Paciente;
            lblDataDoObito.Text = DadosDoObito.Data_do_Obito;
            
            lblDoctorName.Text = DadosDoObito.Doctor_Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DadosDoObito.ActiveForm.Close();
        }

    }
}
