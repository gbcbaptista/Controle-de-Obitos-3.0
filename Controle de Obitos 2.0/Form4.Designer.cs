
namespace Controle_de_Obitos_2._0
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dataGridViewExport = new System.Windows.Forms.DataGridView();
            this.obitosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFEVEREIRO = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnJANEIRO = new System.Windows.Forms.Button();
            this.btnMarco = new System.Windows.Forms.Button();
            this.btnAbril = new System.Windows.Forms.Button();
            this.btnMaio = new System.Windows.Forms.Button();
            this.btnJunho = new System.Windows.Forms.Button();
            this.datadoobitoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDoPacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controledeobitosDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controle_de_obitosDataSet3 = new Controle_de_Obitos_2._0.controle_de_obitosDataSet3();
            this.obitosTableAdapter = new Controle_de_Obitos_2._0.controle_de_obitosDataSet3TableAdapters.obitosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obitosBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controledeobitosDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_de_obitosDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewExport
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewExport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewExport.AutoGenerateColumns = false;
            this.dataGridViewExport.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewExport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewExport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewExport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datadoobitoDataGridViewTextBoxColumn,
            this.dONumberDataGridViewTextBoxColumn,
            this.nomeDoPacienteDataGridViewTextBoxColumn,
            this.doctorNameDataGridViewTextBoxColumn,
            this.cRMDataGridViewTextBoxColumn});
            this.dataGridViewExport.DataSource = this.obitosBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewExport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewExport.EnableHeadersVisualStyles = false;
            this.dataGridViewExport.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewExport.Location = new System.Drawing.Point(0, 40);
            this.dataGridViewExport.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewExport.Name = "dataGridViewExport";
            this.dataGridViewExport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewExport.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewExport.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewExport.Size = new System.Drawing.Size(1091, 410);
            this.dataGridViewExport.TabIndex = 0;
            // 
            // obitosBindingSource
            // 
            this.obitosBindingSource.DataMember = "obitos";
            this.obitosBindingSource.DataSource = this.controledeobitosDataSet3BindingSource;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewExport, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1091, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnJunho);
            this.panel1.Controls.Add(this.btnMaio);
            this.panel1.Controls.Add(this.btnAbril);
            this.panel1.Controls.Add(this.btnMarco);
            this.panel1.Controls.Add(this.btnFEVEREIRO);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnJANEIRO);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 40);
            this.panel1.TabIndex = 1;
            // 
            // btnFEVEREIRO
            // 
            this.btnFEVEREIRO.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFEVEREIRO.FlatAppearance.BorderSize = 0;
            this.btnFEVEREIRO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFEVEREIRO.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnFEVEREIRO.Location = new System.Drawing.Point(240, 9);
            this.btnFEVEREIRO.Margin = new System.Windows.Forms.Padding(0);
            this.btnFEVEREIRO.Name = "btnFEVEREIRO";
            this.btnFEVEREIRO.Size = new System.Drawing.Size(79, 25);
            this.btnFEVEREIRO.TabIndex = 2;
            this.btnFEVEREIRO.Text = "FEVEREIRO";
            this.btnFEVEREIRO.UseVisualStyleBackColor = false;
            this.btnFEVEREIRO.Click += new System.EventHandler(this.btnFEVEREIRO_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button2.Location = new System.Drawing.Point(12, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "GERAL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnJANEIRO
            // 
            this.btnJANEIRO.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnJANEIRO.FlatAppearance.BorderSize = 0;
            this.btnJANEIRO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJANEIRO.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnJANEIRO.Location = new System.Drawing.Point(144, 9);
            this.btnJANEIRO.Margin = new System.Windows.Forms.Padding(0);
            this.btnJANEIRO.Name = "btnJANEIRO";
            this.btnJANEIRO.Size = new System.Drawing.Size(75, 25);
            this.btnJANEIRO.TabIndex = 0;
            this.btnJANEIRO.Text = "JANEIRO";
            this.btnJANEIRO.UseVisualStyleBackColor = false;
            this.btnJANEIRO.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMarco
            // 
            this.btnMarco.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMarco.FlatAppearance.BorderSize = 0;
            this.btnMarco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarco.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnMarco.Location = new System.Drawing.Point(341, 9);
            this.btnMarco.Margin = new System.Windows.Forms.Padding(0);
            this.btnMarco.Name = "btnMarco";
            this.btnMarco.Size = new System.Drawing.Size(79, 25);
            this.btnMarco.TabIndex = 3;
            this.btnMarco.Text = "MARÇO";
            this.btnMarco.UseVisualStyleBackColor = false;
            this.btnMarco.Click += new System.EventHandler(this.btnMarco_Click);
            // 
            // btnAbril
            // 
            this.btnAbril.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAbril.FlatAppearance.BorderSize = 0;
            this.btnAbril.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbril.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAbril.Location = new System.Drawing.Point(435, 9);
            this.btnAbril.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbril.Name = "btnAbril";
            this.btnAbril.Size = new System.Drawing.Size(79, 25);
            this.btnAbril.TabIndex = 4;
            this.btnAbril.Text = "ABRIL";
            this.btnAbril.UseVisualStyleBackColor = false;
            this.btnAbril.Click += new System.EventHandler(this.btnAbril_Click);
            // 
            // btnMaio
            // 
            this.btnMaio.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMaio.FlatAppearance.BorderSize = 0;
            this.btnMaio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaio.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnMaio.Location = new System.Drawing.Point(527, 9);
            this.btnMaio.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaio.Name = "btnMaio";
            this.btnMaio.Size = new System.Drawing.Size(79, 25);
            this.btnMaio.TabIndex = 5;
            this.btnMaio.Text = "MAIO";
            this.btnMaio.UseVisualStyleBackColor = false;
            this.btnMaio.Click += new System.EventHandler(this.btnMaio_Click);
            // 
            // btnJunho
            // 
            this.btnJunho.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnJunho.FlatAppearance.BorderSize = 0;
            this.btnJunho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJunho.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnJunho.Location = new System.Drawing.Point(620, 9);
            this.btnJunho.Margin = new System.Windows.Forms.Padding(0);
            this.btnJunho.Name = "btnJunho";
            this.btnJunho.Size = new System.Drawing.Size(79, 25);
            this.btnJunho.TabIndex = 6;
            this.btnJunho.Text = "JUNHO";
            this.btnJunho.UseVisualStyleBackColor = false;
            this.btnJunho.Click += new System.EventHandler(this.btnJunho_Click);
            // 
            // datadoobitoDataGridViewTextBoxColumn
            // 
            this.datadoobitoDataGridViewTextBoxColumn.DataPropertyName = "Data_do_obito";
            this.datadoobitoDataGridViewTextBoxColumn.HeaderText = "DATA";
            this.datadoobitoDataGridViewTextBoxColumn.Name = "datadoobitoDataGridViewTextBoxColumn";
            // 
            // dONumberDataGridViewTextBoxColumn
            // 
            this.dONumberDataGridViewTextBoxColumn.DataPropertyName = "DO_Number";
            this.dONumberDataGridViewTextBoxColumn.HeaderText = "Nº DECLARAÇÃO DE ÓBITO";
            this.dONumberDataGridViewTextBoxColumn.Name = "dONumberDataGridViewTextBoxColumn";
            this.dONumberDataGridViewTextBoxColumn.Width = 250;
            // 
            // nomeDoPacienteDataGridViewTextBoxColumn
            // 
            this.nomeDoPacienteDataGridViewTextBoxColumn.DataPropertyName = "Nome_Do_Paciente";
            this.nomeDoPacienteDataGridViewTextBoxColumn.HeaderText = "NOME PACIENTE";
            this.nomeDoPacienteDataGridViewTextBoxColumn.Name = "nomeDoPacienteDataGridViewTextBoxColumn";
            this.nomeDoPacienteDataGridViewTextBoxColumn.Width = 350;
            // 
            // doctorNameDataGridViewTextBoxColumn
            // 
            this.doctorNameDataGridViewTextBoxColumn.DataPropertyName = "Doctor_Name";
            this.doctorNameDataGridViewTextBoxColumn.HeaderText = "MÉDICO ATENDIMENTO";
            this.doctorNameDataGridViewTextBoxColumn.Name = "doctorNameDataGridViewTextBoxColumn";
            this.doctorNameDataGridViewTextBoxColumn.Width = 350;
            // 
            // cRMDataGridViewTextBoxColumn
            // 
            this.cRMDataGridViewTextBoxColumn.DataPropertyName = "CRM";
            this.cRMDataGridViewTextBoxColumn.HeaderText = "CRM";
            this.cRMDataGridViewTextBoxColumn.Name = "cRMDataGridViewTextBoxColumn";
            // 
            // controledeobitosDataSet3BindingSource
            // 
            this.controledeobitosDataSet3BindingSource.DataSource = this.controle_de_obitosDataSet3;
            this.controledeobitosDataSet3BindingSource.Position = 0;
            // 
            // controle_de_obitosDataSet3
            // 
            this.controle_de_obitosDataSet3.DataSetName = "controle_de_obitosDataSet3";
            this.controle_de_obitosDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // obitosTableAdapter
            // 
            this.obitosTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1091, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados dos Obitos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obitosBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.controledeobitosDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_de_obitosDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewExport;
        private System.Windows.Forms.BindingSource controledeobitosDataSet3BindingSource;
        private controle_de_obitosDataSet3 controle_de_obitosDataSet3;
        private System.Windows.Forms.BindingSource obitosBindingSource;
        private controle_de_obitosDataSet3TableAdapters.obitosTableAdapter obitosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn datadoobitoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDoPacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRMDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnJANEIRO;
        private System.Windows.Forms.Button btnFEVEREIRO;
        private System.Windows.Forms.Button btnJunho;
        private System.Windows.Forms.Button btnMaio;
        private System.Windows.Forms.Button btnAbril;
        private System.Windows.Forms.Button btnMarco;
    }
}