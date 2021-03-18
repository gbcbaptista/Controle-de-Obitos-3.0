
namespace Controle_de_Obitos_2._0
{
    partial class ExcluirDO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcluirDO));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroDaDO = new System.Windows.Forms.TextBox();
            this.btnExcluirDO = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNumeroDaDO);
            this.groupBox1.Location = new System.Drawing.Point(64, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 167);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Declaração de Óbito para Excluir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero da DO:";
            // 
            // txtNumeroDaDO
            // 
            this.txtNumeroDaDO.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroDaDO.Location = new System.Drawing.Point(18, 80);
            this.txtNumeroDaDO.Name = "txtNumeroDaDO";
            this.txtNumeroDaDO.Size = new System.Drawing.Size(313, 25);
            this.txtNumeroDaDO.TabIndex = 0;
            // 
            // btnExcluirDO
            // 
            this.btnExcluirDO.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnExcluirDO.FlatAppearance.BorderSize = 0;
            this.btnExcluirDO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirDO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirDO.Location = new System.Drawing.Point(541, 214);
            this.btnExcluirDO.Name = "btnExcluirDO";
            this.btnExcluirDO.Size = new System.Drawing.Size(118, 45);
            this.btnExcluirDO.TabIndex = 19;
            this.btnExcluirDO.Text = "Excluir DO";
            this.btnExcluirDO.UseVisualStyleBackColor = false;
            this.btnExcluirDO.Click += new System.EventHandler(this.btnExcluirDO_Click);
            // 
            // ExcluirDO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(683, 271);
            this.Controls.Add(this.btnExcluirDO);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExcluirDO";
            this.Text = "Excluir Declaração de Óbito";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroDaDO;
        private System.Windows.Forms.Button btnExcluirDO;
    }
}