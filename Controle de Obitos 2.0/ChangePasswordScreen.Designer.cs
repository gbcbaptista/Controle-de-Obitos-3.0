
namespace Controle_de_Obitos_2._0
{
    partial class ChangePasswordScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.newPasswordChange = new System.Windows.Forms.TextBox();
            this.newPasswordChangeConfirm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChangingPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite sua nova Senha:";
            // 
            // newPasswordChange
            // 
            this.newPasswordChange.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordChange.Location = new System.Drawing.Point(45, 94);
            this.newPasswordChange.Name = "newPasswordChange";
            this.newPasswordChange.PasswordChar = '*';
            this.newPasswordChange.Size = new System.Drawing.Size(214, 29);
            this.newPasswordChange.TabIndex = 1;
            // 
            // newPasswordChangeConfirm
            // 
            this.newPasswordChangeConfirm.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordChangeConfirm.Location = new System.Drawing.Point(45, 195);
            this.newPasswordChangeConfirm.Name = "newPasswordChangeConfirm";
            this.newPasswordChangeConfirm.PasswordChar = '*';
            this.newPasswordChangeConfirm.Size = new System.Drawing.Size(214, 29);
            this.newPasswordChangeConfirm.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Confirme sua nova Senha:";
            // 
            // btnChangingPassword
            // 
            this.btnChangingPassword.BackColor = System.Drawing.Color.SteelBlue;
            this.btnChangingPassword.FlatAppearance.BorderSize = 0;
            this.btnChangingPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangingPassword.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangingPassword.Location = new System.Drawing.Point(202, 259);
            this.btnChangingPassword.Name = "btnChangingPassword";
            this.btnChangingPassword.Size = new System.Drawing.Size(89, 36);
            this.btnChangingPassword.TabIndex = 4;
            this.btnChangingPassword.Text = "Salvar";
            this.btnChangingPassword.UseVisualStyleBackColor = false;
            this.btnChangingPassword.Click += new System.EventHandler(this.btnChangingPassword_Click);
            // 
            // ChangePasswordScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(324, 310);
            this.Controls.Add(this.btnChangingPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newPasswordChangeConfirm);
            this.Controls.Add(this.newPasswordChange);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePasswordScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newPasswordChange;
        private System.Windows.Forms.TextBox newPasswordChangeConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChangingPassword;
    }
}