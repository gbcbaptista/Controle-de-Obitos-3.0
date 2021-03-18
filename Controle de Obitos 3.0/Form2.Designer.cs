
namespace Controle_de_Obitos_2._0
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDoPacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datadoObitoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Causa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obitosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controle_de_obitosDataSet1 = new Controle_de_Obitos_2._0.controle_de_obitosDataSet1();
            this.obitosTableAdapter = new Controle_de_Obitos_2._0.controle_de_obitosDataSet1TableAdapters.obitosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obitosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_de_obitosDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.nomeDoPacienteDataGridViewTextBoxColumn,
            this.datadoObitoDataGridViewTextBoxColumn,
            this.dONumberDataGridViewTextBoxColumn,
            this.doctorNameDataGridViewTextBoxColumn,
            this.createdtimeDataGridViewTextBoxColumn,
            this.Causa});
            this.dataGridView1.DataSource = this.obitosBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(1283, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "User_Name";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "Usuário que Cadastrou";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // nomeDoPacienteDataGridViewTextBoxColumn
            // 
            this.nomeDoPacienteDataGridViewTextBoxColumn.DataPropertyName = "Nome_Do_Paciente";
            this.nomeDoPacienteDataGridViewTextBoxColumn.HeaderText = "Nome do Paciente";
            this.nomeDoPacienteDataGridViewTextBoxColumn.Name = "nomeDoPacienteDataGridViewTextBoxColumn";
            this.nomeDoPacienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDoPacienteDataGridViewTextBoxColumn.Width = 200;
            // 
            // datadoObitoDataGridViewTextBoxColumn
            // 
            this.datadoObitoDataGridViewTextBoxColumn.DataPropertyName = "Data_do_Obito";
            this.datadoObitoDataGridViewTextBoxColumn.HeaderText = "Data do Obito";
            this.datadoObitoDataGridViewTextBoxColumn.Name = "datadoObitoDataGridViewTextBoxColumn";
            this.datadoObitoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dONumberDataGridViewTextBoxColumn
            // 
            this.dONumberDataGridViewTextBoxColumn.DataPropertyName = "DO_Number";
            this.dONumberDataGridViewTextBoxColumn.HeaderText = "Numero da DO";
            this.dONumberDataGridViewTextBoxColumn.Name = "dONumberDataGridViewTextBoxColumn";
            this.dONumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doctorNameDataGridViewTextBoxColumn
            // 
            this.doctorNameDataGridViewTextBoxColumn.DataPropertyName = "Doctor_Name";
            this.doctorNameDataGridViewTextBoxColumn.HeaderText = "Nome do Médico";
            this.doctorNameDataGridViewTextBoxColumn.Name = "doctorNameDataGridViewTextBoxColumn";
            this.doctorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.doctorNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // createdtimeDataGridViewTextBoxColumn
            // 
            this.createdtimeDataGridViewTextBoxColumn.DataPropertyName = "created_time";
            this.createdtimeDataGridViewTextBoxColumn.HeaderText = "Data do Cadastro";
            this.createdtimeDataGridViewTextBoxColumn.Name = "createdtimeDataGridViewTextBoxColumn";
            this.createdtimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdtimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // Causa
            // 
            this.Causa.DataPropertyName = "Causa_Do_Obito";
            this.Causa.HeaderText = "Causa Do Obito";
            this.Causa.Name = "Causa";
            this.Causa.ReadOnly = true;
            this.Causa.Width = 350;
            // 
            // obitosBindingSource
            // 
            this.obitosBindingSource.DataMember = "obitos";
            this.obitosBindingSource.DataSource = this.controle_de_obitosDataSet1;
            // 
            // controle_de_obitosDataSet1
            // 
            this.controle_de_obitosDataSet1.DataSetName = "controle_de_obitosDataSet1";
            this.controle_de_obitosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // obitosTableAdapter
            // 
            this.obitosTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1283, 450);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Obitos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obitosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_de_obitosDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private controle_de_obitosDataSet1 controle_de_obitosDataSet1;
        private System.Windows.Forms.BindingSource obitosBindingSource;
        private controle_de_obitosDataSet1TableAdapters.obitosTableAdapter obitosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDoPacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datadoObitoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Causa;
    }
}