
namespace CadastroSeriesWindowsFormsSQLite
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelInsiraUsuario = new System.Windows.Forms.Label();
            this.labelInsiraSenha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(150, 239);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(94, 29);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Entrar";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(60, 67);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(281, 27);
            this.textBoxUsuario.TabIndex = 1;
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(60, 156);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(281, 27);
            this.textBoxSenha.TabIndex = 2;
            this.textBoxSenha.UseSystemPasswordChar = true;
            this.textBoxSenha.TextChanged += new System.EventHandler(this.textBoxSenha_TextChanged);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(60, 36);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(62, 20);
            this.labelUsuario.TabIndex = 3;
            this.labelUsuario.Text = "Usuário:";
            this.labelUsuario.Click += new System.EventHandler(this.labelUsuario_Click);
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(60, 125);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(52, 20);
            this.labelSenha.TabIndex = 4;
            this.labelSenha.Text = "Senha:";
            this.labelSenha.Click += new System.EventHandler(this.labelSenha_Click);
            // 
            // labelInsiraUsuario
            // 
            this.labelInsiraUsuario.AutoSize = true;
            this.labelInsiraUsuario.ForeColor = System.Drawing.Color.Red;
            this.labelInsiraUsuario.Location = new System.Drawing.Point(60, 97);
            this.labelInsiraUsuario.Name = "labelInsiraUsuario";
            this.labelInsiraUsuario.Size = new System.Drawing.Size(113, 20);
            this.labelInsiraUsuario.TabIndex = 5;
            this.labelInsiraUsuario.Text = "Insira o usuário!";
            this.labelInsiraUsuario.Visible = false;
            this.labelInsiraUsuario.Click += new System.EventHandler(this.labelInsiraUsuario_Click);
            // 
            // labelInsiraSenha
            // 
            this.labelInsiraSenha.AutoSize = true;
            this.labelInsiraSenha.ForeColor = System.Drawing.Color.Red;
            this.labelInsiraSenha.Location = new System.Drawing.Point(60, 186);
            this.labelInsiraSenha.Name = "labelInsiraSenha";
            this.labelInsiraSenha.Size = new System.Drawing.Size(102, 20);
            this.labelInsiraSenha.TabIndex = 6;
            this.labelInsiraSenha.Text = "Insira a senha!";
            this.labelInsiraSenha.Visible = false;
            this.labelInsiraSenha.Click += new System.EventHandler(this.labelInsiraSenha_Click);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 300);
            this.Controls.Add(this.labelInsiraSenha);
            this.Controls.Add(this.labelInsiraUsuario);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.buttonLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelInsiraUsuario;
        private System.Windows.Forms.Label labelInsiraSenha;
    }
}

