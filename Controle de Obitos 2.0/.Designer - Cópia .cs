﻿
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
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(777, 391);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private controle_de_obitosDataSet controle_de_obitosDataSet;
        private System.Windows.Forms.BindingSource declaracaodeobitosBindingSource;
        private controle_de_obitosDataSetTableAdapters.declaracao_de_obitosTableAdapter declaracao_de_obitosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerodaDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusdaDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datainsercaodoDataGridViewTextBoxColumn;
    }
}