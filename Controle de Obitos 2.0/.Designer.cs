
namespace Controle_de_Obitos_2._0
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.declaracaodeobitosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.controle_de_obitosDataSet2 = new Controle_de_Obitos_2._0.controle_de_obitosDataSet2();
            this.declaracao_de_obitosTableAdapter1 = new Controle_de_Obitos_2._0.controle_de_obitosDataSet2TableAdapters.declaracao_de_obitosTableAdapter();
            this.declaracaodeobitosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controle_de_obitosDataSet = new Controle_de_Obitos_2._0.controle_de_obitosDataSet();
            this.declaracao_de_obitosTableAdapter = new Controle_de_Obitos_2._0.controle_de_obitosDataSetTableAdapters.declaracao_de_obitosTableAdapter();
            this.numerodaDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROAIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.declaracaodeobitosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_de_obitosDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.declaracaodeobitosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_de_obitosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numerodaDODataGridViewTextBoxColumn,
            this.Status,
            this.PROAIM});
            this.dataGridView1.DataSource = this.declaracaodeobitosBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(659, 450);
            this.dataGridView1.TabIndex = 2;
            // 
            // declaracaodeobitosBindingSource1
            // 
            this.declaracaodeobitosBindingSource1.DataMember = "declaracao_de_obitos";
            this.declaracaodeobitosBindingSource1.DataSource = this.controle_de_obitosDataSet2;
            // 
            // controle_de_obitosDataSet2
            // 
            this.controle_de_obitosDataSet2.DataSetName = "controle_de_obitosDataSet2";
            this.controle_de_obitosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // declaracao_de_obitosTableAdapter1
            // 
            this.declaracao_de_obitosTableAdapter1.ClearBeforeFill = true;
            // 
            // declaracaodeobitosBindingSource
            // 
            this.declaracaodeobitosBindingSource.DataMember = "declaracao_de_obitos";
            this.declaracaodeobitosBindingSource.DataSource = this.controle_de_obitosDataSet;
            // 
            // controle_de_obitosDataSet
            // 
            this.controle_de_obitosDataSet.DataSetName = "controle_de_obitosDataSet";
            this.controle_de_obitosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // declaracao_de_obitosTableAdapter
            // 
            this.declaracao_de_obitosTableAdapter.ClearBeforeFill = true;
            // 
            // numerodaDODataGridViewTextBoxColumn
            // 
            this.numerodaDODataGridViewTextBoxColumn.DataPropertyName = "Numero_da_DO";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.numerodaDODataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.numerodaDODataGridViewTextBoxColumn.HeaderText = "Numero da DO";
            this.numerodaDODataGridViewTextBoxColumn.Name = "numerodaDODataGridViewTextBoxColumn";
            this.numerodaDODataGridViewTextBoxColumn.ReadOnly = true;
            this.numerodaDODataGridViewTextBoxColumn.Width = 150;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 200;
            // 
            // PROAIM
            // 
            this.PROAIM.DataPropertyName = "PROAIM";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.PROAIM.DefaultCellStyle = dataGridViewCellStyle3;
            this.PROAIM.HeaderText = "PROAIM";
            this.PROAIM.Name = "PROAIM";
            this.PROAIM.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Declarações de Obitos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.declaracaodeobitosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_de_obitosDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.declaracaodeobitosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_de_obitosDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private controle_de_obitosDataSet controle_de_obitosDataSet;
        private System.Windows.Forms.BindingSource declaracaodeobitosBindingSource;
        private controle_de_obitosDataSetTableAdapters.declaracao_de_obitosTableAdapter declaracao_de_obitosTableAdapter;
        private controle_de_obitosDataSet2 controle_de_obitosDataSet2;
        private System.Windows.Forms.BindingSource declaracaodeobitosBindingSource1;
        private controle_de_obitosDataSet2TableAdapters.declaracao_de_obitosTableAdapter declaracao_de_obitosTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerodaDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROAIM;
    }
}