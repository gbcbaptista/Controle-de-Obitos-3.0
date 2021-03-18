using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Controle_de_Obitos_2._0
{
    public partial class MainScreen : Form
    {
        int verifying1;
        public MainScreen()
        {
            InitializeComponent();
            lblName.Text = Login.Name;
            pnlHome.BringToFront();
            
        }

        public void accessControl()
        {
            btnAdm.Enabled = false;
            btnPROAIM.Enabled = false;
            if (Login.access == 1)
            {
                btnAdm.Enabled = true;
                btnPROAIM.Enabled = true;
            }
            else if (Login.access == 2)
            {
                btnPROAIM.Enabled = true;
            }
            else
            {
                MessageBox.Show("Login efetuado com sucesso!");
            }
        }

        public void changeButtonBackColorForDefaultColor(Button btn)
        {
            btn.BackColor = Color.LightSteelBlue;
        }
        public void changeButtonBackColorForSelectedColor(Button btn)
        {
            btn.BackColor = Color.SteelBlue;
        }
        public void btnResetColor()
        {
            changeButtonBackColorForDefaultColor(btnCadastrarObitos);
            changeButtonBackColorForDefaultColor(btnVizualizarDOs);
            changeButtonBackColorForDefaultColor(btnVizualizarObitos);
            changeButtonBackColorForDefaultColor(btnPROAIM);
            changeButtonBackColorForDefaultColor(btnAdm);
            changeButtonBackColorForDefaultColor(btnIndicadores);
            btnCadastrarDOsCanceladas.Visible = false;
            btnPageCadastrarÓbitos.Visible = false;
            btnChangePassword.Visible = false;
        }

        private void btnCadastrarObitos_Click(object sender, EventArgs e)
        {
            btnResetColor();
            changeButtonBackColorForSelectedColor(btnCadastrarObitos);
            pnlCadastrarObitos.BringToFront();
            pnlPageCadatroObito.BringToFront();
            btnCadastrarDOsCanceladas.Visible = true;
            btnPageCadastrarÓbitos.Visible = true;

        }

        private void btnVizualizarObitos_Click(object sender, EventArgs e)
        {
            btnResetColor();
            changeButtonBackColorForSelectedColor(btnVizualizarObitos);
            pnlVizualizarObitos.BringToFront();
        }

        private void btnVizualizarDOs_Click(object sender, EventArgs e)
        {
            btnResetColor();
            changeButtonBackColorForSelectedColor(btnVizualizarDOs);
            pnlVizualizarDos.BringToFront();
        }

        private void btnPROAIM_Click(object sender, EventArgs e)
        {
            if (Login.access > 2)
            {
                MessageBox.Show("Acesso negado!");
            }
            else
            {
                btnResetColor();
                btnPROAIM.BackColor = Color.SteelBlue;
                pnlPROAIM.BringToFront();
            }
            
        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            if (Login.access > 2)
            {
                MessageBox.Show("Acesso negado!");
            }
            else
            {
                btnResetColor();
                btnAdm.BackColor = Color.SteelBlue;
                pnlAdm.BringToFront();
            }
            
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordScreen changeScreen = new ChangePasswordScreen();
            changeScreen.StartPosition = FormStartPosition.CenterScreen;
            changeScreen.ShowDialog();
        }

        private void pictureUser_Click(object sender, EventArgs e)
        {
            pnlHome.BringToFront();
            btnResetColor();
            btnChangePassword.Visible = true;
        }

        private void btnCadastrarDOsCanceladas_Click(object sender, EventArgs e)
        {
            pnlPageCadastroDOCanceladas.BringToFront();
            
        }

        private void btnPageCadastrarÓbitos_Click(object sender, EventArgs e)
        {
            pnlPageCadatroObito.BringToFront();
        }

        private void boxTipoDeObito_SelectionChangeCommitted(object sender, EventArgs e)
        {

            ComboBox senderComboBox = (ComboBox)sender;
            if (boxTipoDeObito.Text == "Não")
            {
                lblDONumber.Visible = true;
                txtDONumber.Visible = true;
                lblCausaDaMorte.Visible = true;
                txtCausaDaMorte.Visible = true;
                btnVerifyDO.Visible = true;
            }
            else
            {
                try
                {
                    lblDONumber.Visible = false;
                    txtDONumber.Visible = false;
                    lblCausaDaMorte.Visible = false;
                    txtCausaDaMorte.Visible = false;
                    btnVerifyDO.Visible = false;
                }
                catch
                {

                }
                
            }

        }

        private void btnSearchDoctor_Click(object sender, EventArgs e)
        {
            lblNomeDoMedico.Visible = true;
            lblNomeDoMedico.Text = Login.lookForDoctor(txtCRM.Text);
        }

        private void btnVerifyDO_Click(object sender, EventArgs e)
        {
            int verifying = 0;
            DeclaracaoDeObitoDB.found = 0;
            DeclaracaoDeObitoDB.Status_Da_DO = 0;
            verifying = Login.lookForDO(txtDONumber.Text);
            if (verifying == 1)
            {
                lblOk.Visible = true;
            }
            else if (verifying > 1)
            {
                MessageBox.Show("DO já ultilizada!");
            }
            else
            {

            }
        }

        public void AllowSave(object sender, EventArgs e)
        {
            
            if ((lblOk.Visible == true && lblNomeDoMedico.Visible == true) || boxTipoDeObito.Text == "Sim" || boxTipoDeObito.Text == "SVO")
            {
                btnSalvarObito.Enabled = true;
            }
        }
        public void ClearValues()
        {
            txtNomeDoPaciente.Text = String.Empty;
            dataObito.Text = String.Empty;
            dataNascimentoDoPaciente.Text = String.Empty;
            txtCausaDaMorte.Text = String.Empty;
            boxTipoDeObito.Text = String.Empty;
            txtDONumber.Text = String.Empty;
            txtCausaDaMorte.Text = String.Empty;
            txtCRM.Text = String.Empty;


            lblNomeDoMedico.Visible = false;
            lblNomeDoMedico.Text = "Medico";
            lblOk.Visible = false;
            lblDONumber.Visible = false;
            txtDONumber.Visible = false;
            lblCausaDaMorte.Visible = false;
            txtCausaDaMorte.Visible = false;
            btnVerifyDO.Visible = false;

        }

        private void btnSalvarObito_Click(object sender, EventArgs e)
        {
            
            if (boxTipoDeObito.Text == "Sim")
            {
                RegistrarObitoDB.SaveIML(Login.Name, txtNomeDoPaciente.Text, dataObito.Text, dataNascimentoDoPaciente.Text, boxTipoDeObito.Text, lblNomeDoMedico.Text);
            }
            else if (boxTipoDeObito.Text == "SVO")
            {
                RegistrarObitoDB.SaveSVO(Login.Name, txtNomeDoPaciente.Text, dataObito.Text, dataNascimentoDoPaciente.Text, boxTipoDeObito.Text, lblNomeDoMedico.Text);
            }
            else
            {
                RegistrarObitoDB.SaveNormalObito(Login.Name, txtNomeDoPaciente.Text, dataObito.Text, dataNascimentoDoPaciente.Text, boxTipoDeObito.Text, txtDONumber.Text, txtCausaDaMorte.Text, lblNomeDoMedico.Text);
            }

            ClearValues();

        }

        public void verifyDObtn()
        {
            int verifying = 0;
            DeclaracaoDeObitoDB.found = 0;
            DeclaracaoDeObitoDB.Status_Da_DO = 0;
            verifying = Login.lookForDO(txtNumeroDOCancela.Text);
            if (verifying == 1)
            {
                lblOk2.Visible = true;
            }
            else if (verifying > 1)
            {
                MessageBox.Show("DO já ultilizada!");
            }
        }
        private void btnVerificarDO_Click(object sender, EventArgs e)
        {
            verifyDObtn();
        }

        private void btnCancelaDO_Click(object sender, EventArgs e)
        {
            Login.cancelandoDO(txtNumeroDOCancela.Text);
            txtNumeroDOCancela.Text = String.Empty;
            lblOk2.Visible = false;
            btnCancelaDO.Enabled = false;
        }

        private void AllowCancelaDO(object sender, EventArgs e)
        {
            btnCancelaDO.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserDB.CreateUSER(txtNomeDoColaborador.Text, txtUserDoColaborador.Text, comboBoxAcessoColaborador.Text);
            txtNomeDoColaborador.Text = String.Empty;
            txtUserDoColaborador.Text = String.Empty;
            comboBoxAcessoColaborador.Text = String.Empty;
        }
 
        private void btnPesquisaDOsPROAIM_Click(object sender, EventArgs e)
        {
            if (listBoxVizualizarDOsPROAIM.Items.Count > 0 || listBoxLevarAoPROAIM.Items.Count > 0)
            {
                listBoxVizualizarDOsPROAIM.Items.Clear();
                listBoxLevarAoPROAIM.Items.Clear();
            }
            string comandoSQL = "SELECT Numero_da_DO FROM declaracao_de_obitos WHERE Status_da_DO = 3 AND PROAIM = 1";

            ComandBD.ComandSelectToBD(comandoSQL, Add_Numero_da_DO_ToListBox);
        }
        //FunçãoSuporte ao SELECT
        public void Add_Numero_da_DO_ToListBox(MySqlDataReader reader)
        {
            listBoxVizualizarDOsPROAIM.Items.Add(reader["Numero_da_DO"].ToString());
        }


        private void button3_Click(object sender, EventArgs e)
        {

          for (int i =0; i < listBoxVizualizarDOsPROAIM.Items.Count; i++)
            {
                listBoxVizualizarDOsPROAIM.SetSelected(i, true);
                listBoxLevarAoPROAIM.Items.Add(listBoxVizualizarDOsPROAIM.SelectedItem.ToString());
            }
            listBoxVizualizarDOsPROAIM.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBoxLevarAoPROAIM.Items.Clear();
        }

        private void listBoxLevarAoPROAIM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxLevarAoPROAIM.SelectedItem != null)
            {
                listBoxVizualizarDOsPROAIM.Items.Add(listBoxLevarAoPROAIM.SelectedItem.ToString());
                listBoxLevarAoPROAIM.Items.Remove(listBoxLevarAoPROAIM.SelectedItem.ToString());
            }
        }

        private void listBoxVizualizarDOsPROAIM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxVizualizarDOsPROAIM.SelectedItem != null)
            {
                listBoxLevarAoPROAIM.Items.Add(listBoxVizualizarDOsPROAIM.SelectedItem.ToString());
                listBoxVizualizarDOsPROAIM.Items.Remove(listBoxVizualizarDOsPROAIM.SelectedItem.ToString());
            }
        }

        private void escondeLblDODIsponivel(object sender, EventArgs e)
        {
            if (lblDODisponivel.Visible == true)
            {
                lblDODisponivel.Visible = false;
                verifying1 = 0;
                DeclaracaoDeObitoDB.found = 0;

            }
        }

        private void btnVerificaDOEspecifica_Click(object sender, EventArgs e)
        {
            verifying1 = 0;
            DeclaracaoDeObitoDB.found = 0;
            DeclaracaoDeObitoDB.Status_Da_DO = 0;
            verifying1 = Login.lookForDO(txtDONumberDisponibilidade.Text);
            Console.WriteLine(verifying1);
            if (verifying1 == 1)
            {
                lblDODisponivel.Visible = true;
                
            }
            else if (verifying1 > 1)
            {
                MessageBox.Show("DO não disponível ou não cadastrada!");
            }
            else
            {

            }
        }

        //SELECT -- Mostra DOs Disponiveis -------------------------------------------------------------------------------------------------------------------------------------
        public void findDOsDisponiveis()
        {
            if (listBoxDOsDisponiveis.Items.Count > 0)
            {
                listBoxDOsDisponiveis.Items.Clear();
            }

            string SQLComand = "SELECT Numero_da_DO, data_insercao_do FROM declaracao_de_obitos WHERE Status_da_DO = 1;";
            ComandBD.ComandSelectToBD(SQLComand, Add_Numero_da_DO_DisponivelToListBox);
        }
        //FunçãoSuporte ao SELECT
        public void Add_Numero_da_DO_DisponivelToListBox(MySqlDataReader reader)
        {
            if (reader["Numero_da_DO"] == null)
            {
                MessageBox.Show("Nenhuma DO disponível!");
            }
            else
            {

                listBoxDOsDisponiveis.Items.Add("Nº da DO: " + reader["Numero_da_DO"].ToString() + " Data da Inserção: " + reader["data_insercao_do"].ToString());

            }
        }

        //SELECT -- Mostra DOs Disponiveis para Cancelar ---------------------------------------------------------------------------------------------------------------------------
        public void findDOsDisponiveisParaCancelar()
        {
            if (listBoxDOsParaCancelar.Items.Count > 0)
            {
                listBoxDOsParaCancelar.Items.Clear();
            }

            string SQLComand = "SELECT Numero_da_DO FROM declaracao_de_obitos WHERE Status_da_DO = 1;";
            ComandBD.ComandSelectToBD(SQLComand, Add_Numero_da_DO_DisponivelParaCancelarToListBox);
          
        }
        //FunçãoSuporte ao SELECT
        public void Add_Numero_da_DO_DisponivelParaCancelarToListBox(MySqlDataReader reader)
        {
            if (reader["Numero_da_DO"] == null)
            {
                MessageBox.Show("Nenhuma DO disponível!");
            }
            else
            {

                listBoxDOsParaCancelar.Items.Add(reader["Numero_da_DO"].ToString());

            }
        }

        private void btnDosDisponiveis_Click(object sender, EventArgs e)
        {
            findDOsDisponiveis();
        }
        public void InsereDOFunction()
        {
            if (Login.access > 2)
            {
                MessageBox.Show("Acesso negado contate o administrador!");
            }
            else
            {
                Login.INSERT_do(txtDOinsert.Text);
                txtDOinsert.Text = String.Empty;
                findDOsDisponiveis();
            }
        }
        private void btnInsereNovaDO_Click(object sender, EventArgs e)
        {
            if (txtDOinsert.Text != "")
            {
                InsereDOFunction();
            }
            else
            {
                MessageBox.Show("Numero da DO deve ter 9 caracteres!");
            }
            
        }

        private void textChangeVerifyDOforCadastro(object sender, EventArgs e)
        {
            if (lblOk.Visible == true)
            {
                lblOk.Visible = false;
            }
        }

        private void escondeOk2(object sender, EventArgs e)
        {
            lblOk2.Visible = false;
            findDOsDisponiveisParaCancelar();
            
        }
        public void levarParaPROAIM(int contador)
        {
            MySqlConnection conexao = ConexaoDB.getInstancia().getConexao();

            try
            {
                MySqlCommand comando = ConexaoDB.openConexao(conexao);
                

                for (int i = 0; i < contador; i++)
                {
                    listBoxLevarAoPROAIM.SetSelected(i, true);
                    string valueUPDATE = ConexaoDB.putAspas(listBoxLevarAoPROAIM.SelectedItem.ToString());

                    comando.CommandText = "UPDATE `controle_de_obitos`.`declaracao_de_obitos` SET `PROAIM` = '2' WHERE(`Numero_da_DO` ="+valueUPDATE+");";


                    int valorRetorno = comando.ExecuteNonQuery();
                    if (valorRetorno < 1)
                    {
                        MessageBox.Show("Erro ao alterar!");
                    }
                    else
                    {
                    }
                }
                
            }

            catch (MySqlException msql)
            {
                MessageBox.Show(msql.Message);
            }
            finally
            {
                conexao.Close();
            }

            listBoxLevarAoPROAIM.Items.Clear();
            listBoxVizualizarDOsPROAIM.Items.Clear();
        }

        private void btnLevarDOsPROAIM_Click(object sender, EventArgs e)
        {
            levarParaPROAIM(listBoxLevarAoPROAIM.Items.Count);
        }

        private void btnDOsParaCancelar_Click(object sender, EventArgs e)
        {
            findDOsDisponiveisParaCancelar();
        }

        private void listBoxDOsParaCancelar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            if (listBoxDOsParaCancelar.SelectedItem != null)
            {
                txtNumeroDOCancela.Text = listBoxDOsParaCancelar.SelectedItem.ToString();
                findDOsDisponiveisParaCancelar();
                listBoxDOsParaCancelar.Items.Remove(txtNumeroDOCancela.Text);
                verifyDObtn();
            }
        }

        //SELECT -- Mostra Obitos ----------------------------------------------------------------------------------------------------------------------------------
        public void VizualizarObitos()
        {
            if (listBoxVerObitos.Items.Count > 0)
            {
                listBoxVerObitos.Items.Clear();
            }
            string SQLComand = "SELECT Obitos_ID, Nome_Do_Paciente, Doctor_Name, DO_Number FROM obitos;";
            ComandBD.ComandSelectToBD(SQLComand, Add_Obitos_ToListBox);
        }

        //FunçãoSuporte ao SELECT
        public void Add_Obitos_ToListBox(MySqlDataReader reader)
        {
            if (reader["Nome_Do_Paciente"] == null)
            {
                MessageBox.Show("Erro ao carregar óbito!");
            }
            else
            {

                listBoxVerObitos.Items.Add(reader["Obitos_ID"].ToString() + " Nome do Paciente: " + reader["Nome_Do_Paciente"].ToString() + " - Nome do Médico: " + reader["Doctor_Name"] + " - Numero da DO: " + reader["DO_Number"]);
            }
        }

        //SELECT -- Ver Dados dos Obitos ----------------------------------------------------------------------------------------------------------------------------------
        private void listBoxVerObitos_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (listBoxVerObitos.SelectedItem != null)
            {
                string id_consult = listBoxVerObitos.SelectedItem.ToString().Substring(0, 2).Trim();
                string id_consultWithAspas = ConexaoDB.putAspas(id_consult);
                string SQLComand = "SELECT User_Name, Nome_Do_Paciente, Data_do_Obito, DO_Number, Data_de_Nascimento_do_Paciente, Causa_Do_Obito, Doctor_Name, Tipo_De_Obito FROM obitos WHERE Obitos_ID = " + id_consultWithAspas + ";";
                ComandBD.ComandSelectToBD(SQLComand, ShowObitoData);
            }
            
        }
        //FunçãoSuporte ao SELECT
        public void ShowObitoData(MySqlDataReader reader)
        {
            if (reader["Nome_Do_Paciente"] == null)
            {
                MessageBox.Show("Erro ao carregar óbito!");
            }
            else
            {

                DadosDoObito ObitosScreen = new DadosDoObito();
                ObitosScreen.StartPosition = FormStartPosition.CenterScreen;
                DadosDoObito.User_Name = reader["User_Name"].ToString();
                DadosDoObito.Nome_Do_Paciente = reader["Nome_Do_Paciente"].ToString();
                DadosDoObito.Data_do_Obito = (reader["Data_do_Obito"].ToString()).Substring(0, 10);
                DadosDoObito.DO_Number = reader["DO_Number"].ToString();
                DadosDoObito.Data_de_Nascimento_do_Paciente = reader["Data_de_Nascimento_do_Paciente"].ToString();
                DadosDoObito.Causa_Do_Obito = reader["Causa_Do_Obito"].ToString();
                DadosDoObito.Doctor_Name = reader["Doctor_Name"].ToString();
                DadosDoObito.Tipo_De_Obito = reader["Tipo_De_Obito"].ToString();

                ObitosScreen.ShowDialog();
            }
        }
        //SELECT -- Ver Obitos Clicados ----------------------------------------------------------------------------------------------------------------------------------
        private void btnVerObitos_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.StartPosition = FormStartPosition.CenterScreen;
            form2.ShowDialog();
            //VizualizarObitos();
            //lblTotalObitos.Text = listBoxVerObitos.Items.Count.ToString();
        }

        public void PesquisaObitos(string valor, string Pesquisa, string Inicio, string Fim)
        {
            string SQLComand = SQLComandSearchType(valor, Pesquisa, Inicio, Fim);
            ComandBD.ComandSelectToBD(SQLComand, Add_Obitos_Pesquisados_ToListBox);
        }


        //FunçãoSuporte ao SELECT - 1
        public string SQLComandSearchType(string valor, string Pesquisa, string Inicio, string Fim)
        {
            Inicio = ConexaoDB.putAspas(Inicio);
            Fim = ConexaoDB.putAspas(Fim);
            string Comand = String.Empty;
            if (Pesquisa == "Data_do_Obito")
            {
                Comand = "SELECT Obitos_ID, Nome_Do_Paciente, Doctor_Name, DO_Number FROM controle_de_obitos.obitos WHERE Data_do_Obito BETWEEN " + Inicio + " AND " + Fim + ";";
            }
            else
            {
                string valorWithAspas = ConexaoDB.putAspas("%" + valor + "%");
                Comand = "SELECT Obitos_ID, Nome_Do_Paciente, Doctor_Name, DO_Number FROM controle_de_obitos.obitos WHERE " + Pesquisa + " LIKE " + valorWithAspas + " AND Data_do_Obito BETWEEN " + Inicio + " AND " + Fim + ";";
            }
            return Comand;
        }
        //FunçãoSuporte ao SELECT - 2
        public void Add_Obitos_Pesquisados_ToListBox(MySqlDataReader reader)
        {
            if (reader["Nome_Do_Paciente"] == null)
            {
                MessageBox.Show("Erro ao carregar óbito!");
            }
            else
            {
                listBoxVerObitos.Items.Add(reader["Obitos_ID"].ToString() + " Nome do Paciente: " + reader["Nome_Do_Paciente"].ToString() + " - Nome do Médico: " + reader["Doctor_Name"] + " - Numero da DO: " + reader["DO_Number"].ToString());
            }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            string dataInicio = String.Empty;
            string dataFim = String.Empty;
            string valorPesquisa = String.Empty;
            string tipoDePesquisa = String.Empty;
            string pesquisa = String.Empty;

            if (listBoxVerObitos.Items.Count > 0)
            {
                listBoxVerObitos.Items.Clear();
            }
            dataInicio = dateTimeObitoInicio.Text.Substring(6, 4) + "-" + dateTimeObitoInicio.Text.Substring(3, 2) + "-" + dateTimeObitoInicio.Text.Substring(0, 2);
            dataFim = dateTimeObitoFim.Text.Substring(6, 4) + "-" + dateTimeObitoFim.Text.Substring(3, 2) + "-" + dateTimeObitoFim.Text.Substring(0, 2);
            valorPesquisa = txtValorPesquisa.Text;
            tipoDePesquisa = comboBoxTipoDePesquisa.Text;
            
            
            if (tipoDePesquisa == "Nome Do Paciente")
            {
                pesquisa = "Nome_Do_Paciente";
                PesquisaObitos(valorPesquisa, pesquisa, dataInicio, dataFim);
            }
            else if (tipoDePesquisa == "Médico")
            {
                pesquisa = "Doctor_Name";
                PesquisaObitos(valorPesquisa, pesquisa, dataInicio, dataFim);
            }
            else if (tipoDePesquisa == "Numero da DO")
            {
                pesquisa = "DO_Number";
                PesquisaObitos(valorPesquisa, pesquisa, dataInicio, dataFim);
            }
            else if (tipoDePesquisa == "Causa da Morte")
            {
                pesquisa = "Causa_Do_Obito";
                PesquisaObitos(valorPesquisa, pesquisa, dataInicio, dataFim);
            }
            else if (tipoDePesquisa == "Data")
            {
                pesquisa = "Data_do_Obito";
                PesquisaObitos(valorPesquisa, pesquisa, dataInicio, dataFim);
            }
            else
            {
                MessageBox.Show("Selecione o tipo de Pesquisa!");
            }
            lblTotalObitos.Text = listBoxVerObitos.Items.Count.ToString();

        }

        //SELECT -- Contar Obitos ----------------------------------------------------------------------------------------------------------------------------------
        public void ContarObito(string InicioCount, string FimCount)
        {
            InicioCount = InicioCount.Substring(6, 4) + "-" + InicioCount.Substring(3, 2) + "-" + InicioCount.Substring(0, 2);
            InicioCount = ConexaoDB.putAspas(InicioCount);
            FimCount = FimCount.Substring(6, 4) + "-" + FimCount.Substring(3, 2) + "-" + FimCount.Substring(0, 2);
            FimCount = ConexaoDB.putAspas(FimCount);
            string SQLComand = "SELECT COUNT(Obitos_ID) FROM controle_de_obitos.obitos WHERE Data_do_Obito BETWEEN "+InicioCount+" AND "+FimCount+" ;";

            ComandBD.ComandSelectToBD(SQLComand, ShowCountedObitos);
            
        }
        //FunçãoSuporte ao SELECT
        public void ShowCountedObitos(MySqlDataReader reader)
        {
            if (reader["COUNT(Obitos_ID)"] == null)
            {
                MessageBox.Show("Erro ao carregar óbito!");
            }
            else
            {

                lblTotalDeObitos.Text = reader["COUNT(Obitos_ID)"].ToString();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
           ContarObito(txtInicioTotalObitos.Text, txtFimTotalObitos.Text);
        }

        private void EnterPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InsereDOFunction();
            }
            
        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.StartPosition = FormStartPosition.CenterScreen;
            form4.ShowDialog();
        }

        private void btnIndicadores_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modulo em Desenvolvimento em breve estara disponivel!");
        }

        private void btnAdicionarMedico_Click(object sender, EventArgs e)
        {
            AdicionarMedico doctorAddScreen = new AdicionarMedico();
            doctorAddScreen.StartPosition = FormStartPosition.CenterScreen;
            doctorAddScreen.ShowDialog();
        }

        private void btnExcluirDOeRegistrodeObito_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade em Desenvolvimento em breve estara disponivel!");
        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            ExcluirUsuario userDeleteScreen = new ExcluirUsuario();
            userDeleteScreen.StartPosition = FormStartPosition.CenterScreen;
            userDeleteScreen.ShowDialog();
        }

        private void btnExcluirDO_Click(object sender, EventArgs e)
        {
            ExcluirDO doDeleteScreen = new ExcluirDO();
            doDeleteScreen.StartPosition = FormStartPosition.CenterScreen;
            doDeleteScreen.ShowDialog();
        }

        private void btnExcluirRegistroDeObito_Click(object sender, EventArgs e)
        {
            ExcluirObito obitoDeleteScreen = new ExcluirObito();
            obitoDeleteScreen.StartPosition = FormStartPosition.CenterScreen;
            obitoDeleteScreen.ShowDialog();
        }
    }
}