
namespace Controle_de_Obitos_2._0
{
    partial class AdicionarPack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarPack));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCRM = new System.Windows.Forms.Label();
            this.txtBoxAdicionaDoAoEnvelope = new System.Windows.Forms.TextBox();
            this.txtBoxNomeDoMédico = new System.Windows.Forms.TextBox();
            this.listBoxDosDoEnvelope = new System.Windows.Forms.ListBox();
            this.btnExcluirDO = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBoxNomeDoMédico);
            this.groupBox1.Location = new System.Drawing.Point(64, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Envelope de DO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite o numero de DOs:";
            // 
            // lblCRM
            // 
            this.lblCRM.AutoSize = true;
            this.lblCRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCRM.Location = new System.Drawing.Point(78, 149);
            this.lblCRM.Name = "lblCRM";
            this.lblCRM.Size = new System.Drawing.Size(267, 20);
            this.lblCRM.TabIndex = 2;
            this.lblCRM.Text = "Digite DO para adionar ao Envelope:";
            // 
            // txtBoxAdicionaDoAoEnvelope
            // 
            this.txtBoxAdicionaDoAoEnvelope.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAdicionaDoAoEnvelope.Location = new System.Drawing.Point(99, 172);
            this.txtBoxAdicionaDoAoEnvelope.Name = "txtBoxAdicionaDoAoEnvelope";
            this.txtBoxAdicionaDoAoEnvelope.Size = new System.Drawing.Size(313, 25);
            this.txtBoxAdicionaDoAoEnvelope.TabIndex = 1;
            // 
            // txtBoxNomeDoMédico
            // 
            this.txtBoxNomeDoMédico.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNomeDoMédico.Location = new System.Drawing.Point(18, 50);
            this.txtBoxNomeDoMédico.Name = "txtBoxNomeDoMédico";
            this.txtBoxNomeDoMédico.Size = new System.Drawing.Size(313, 25);
            this.txtBoxNomeDoMédico.TabIndex = 0;
            // 
            // listBoxDosDoEnvelope
            // 
            this.listBoxDosDoEnvelope.BackColor = System.Drawing.Color.SteelBlue;
            this.listBoxDosDoEnvelope.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxDosDoEnvelope.FormattingEnabled = true;
            this.listBoxDosDoEnvelope.Location = new System.Drawing.Point(6, 19);
            this.listBoxDosDoEnvelope.Name = "listBoxDosDoEnvelope";
            this.listBoxDosDoEnvelope.Size = new System.Drawing.Size(453, 143);
            this.listBoxDosDoEnvelope.TabIndex = 3;
            // 
            // btnExcluirDO
            // 
            this.btnExcluirDO.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnExcluirDO.FlatAppearance.BorderSize = 0;
            this.btnExcluirDO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirDO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirDO.Location = new System.Drawing.Point(464, 163);
            this.btnExcluirDO.Name = "btnExcluirDO";
            this.btnExcluirDO.Size = new System.Drawing.Size(118, 45);
            this.btnExcluirDO.TabIndex = 20;
            this.btnExcluirDO.Text = "Adicionar";
            this.btnExcluirDO.UseVisualStyleBackColor = false;
            this.btnExcluirDO.Click += new System.EventHandler(this.btnExcluirDO_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(553, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 45);
            this.button1.TabIndex = 21;
            this.button1.Text = "Salvar novo Envelope";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxDosDoEnvelope);
            this.groupBox2.Location = new System.Drawing.Point(64, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 177);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Declarações no Envelope";
            // 
            // AdicionarPack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(683, 466);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExcluirDO);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCRM);
            this.Controls.Add(this.txtBoxAdicionaDoAoEnvelope);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdicionarPack";
            this.Text = "Adicionar Pacote de Declarações de Óbito";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCRM;
        private System.Windows.Forms.TextBox txtBoxAdicionaDoAoEnvelope;
        private System.Windows.Forms.TextBox txtBoxNomeDoMédico;
        private System.Windows.Forms.ListBox listBoxDosDoEnvelope;
        private System.Windows.Forms.Button btnExcluirDO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}