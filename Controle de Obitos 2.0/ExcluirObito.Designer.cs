
namespace Controle_de_Obitos_2._0
{
    partial class ExcluirObito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcluirObito));
            this.btnRegistraMedico = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCRM = new System.Windows.Forms.Label();
            this.txtBoxNumeroDaDO = new System.Windows.Forms.TextBox();
            this.txtBoxNomeDoPaciente = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistraMedico
            // 
            this.btnRegistraMedico.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRegistraMedico.FlatAppearance.BorderSize = 0;
            this.btnRegistraMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistraMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistraMedico.Location = new System.Drawing.Point(541, 214);
            this.btnRegistraMedico.Name = "btnRegistraMedico";
            this.btnRegistraMedico.Size = new System.Drawing.Size(118, 45);
            this.btnRegistraMedico.TabIndex = 20;
            this.btnRegistraMedico.Text = "Registrar Médico";
            this.btnRegistraMedico.UseVisualStyleBackColor = false;
            this.btnRegistraMedico.Click += new System.EventHandler(this.btnRegistraMedico_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblCRM);
            this.groupBox1.Controls.Add(this.txtBoxNumeroDaDO);
            this.groupBox1.Controls.Add(this.txtBoxNomeDoPaciente);
            this.groupBox1.Location = new System.Drawing.Point(64, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 167);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Do Obito a ser Excluido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite o Nome Completo do Paciente:";
            // 
            // lblCRM
            // 
            this.lblCRM.AutoSize = true;
            this.lblCRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCRM.Location = new System.Drawing.Point(14, 88);
            this.lblCRM.Name = "lblCRM";
            this.lblCRM.Size = new System.Drawing.Size(239, 20);
            this.lblCRM.TabIndex = 2;
            this.lblCRM.Text = "Digite o Numero da DO utilizada:";
            // 
            // txtBoxNumeroDaDO
            // 
            this.txtBoxNumeroDaDO.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNumeroDaDO.Location = new System.Drawing.Point(18, 121);
            this.txtBoxNumeroDaDO.Name = "txtBoxNumeroDaDO";
            this.txtBoxNumeroDaDO.Size = new System.Drawing.Size(313, 25);
            this.txtBoxNumeroDaDO.TabIndex = 1;
            // 
            // txtBoxNomeDoPaciente
            // 
            this.txtBoxNomeDoPaciente.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNomeDoPaciente.Location = new System.Drawing.Point(18, 50);
            this.txtBoxNomeDoPaciente.Name = "txtBoxNomeDoPaciente";
            this.txtBoxNomeDoPaciente.Size = new System.Drawing.Size(313, 25);
            this.txtBoxNomeDoPaciente.TabIndex = 0;
            // 
            // ExcluirObito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(683, 271);
            this.Controls.Add(this.btnRegistraMedico);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExcluirObito";
            this.Text = "Excluir Óbito";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistraMedico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCRM;
        private System.Windows.Forms.TextBox txtBoxNumeroDaDO;
        private System.Windows.Forms.TextBox txtBoxNomeDoPaciente;
    }
}