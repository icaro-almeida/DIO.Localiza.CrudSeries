
namespace CadastroSeriesWindowsFormsSQLite
{
    partial class FormPrincipal
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelInsiraNome = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelInsiraSenha = new System.Windows.Forms.Label();
            this.labelInsiraUsuario = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUsuarioLogado = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(938, 477);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelInsiraNome);
            this.tabPage1.Controls.Add(this.labelNome);
            this.tabPage1.Controls.Add(this.textBoxNome);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.labelInsiraSenha);
            this.tabPage1.Controls.Add(this.labelInsiraUsuario);
            this.tabPage1.Controls.Add(this.labelSenha);
            this.tabPage1.Controls.Add(this.labelUsuario);
            this.tabPage1.Controls.Add(this.textBoxSenha);
            this.tabPage1.Controls.Add(this.textBoxUsuario);
            this.tabPage1.Controls.Add(this.buttonCadastrar);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(930, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Usuários";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelInsiraNome
            // 
            this.labelInsiraNome.AutoSize = true;
            this.labelInsiraNome.ForeColor = System.Drawing.Color.Red;
            this.labelInsiraNome.Location = new System.Drawing.Point(96, 137);
            this.labelInsiraNome.Name = "labelInsiraNome";
            this.labelInsiraNome.Size = new System.Drawing.Size(103, 20);
            this.labelInsiraNome.TabIndex = 17;
            this.labelInsiraNome.Text = "Insira o nome!";
            this.labelInsiraNome.Visible = false;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(37, 107);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(53, 20);
            this.labelNome.TabIndex = 16;
            this.labelNome.Text = "Nome:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(96, 107);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(281, 27);
            this.textBoxNome.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(96, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cadastrar usuário:";
            // 
            // labelInsiraSenha
            // 
            this.labelInsiraSenha.AutoSize = true;
            this.labelInsiraSenha.ForeColor = System.Drawing.Color.Red;
            this.labelInsiraSenha.Location = new System.Drawing.Point(96, 257);
            this.labelInsiraSenha.Name = "labelInsiraSenha";
            this.labelInsiraSenha.Size = new System.Drawing.Size(102, 20);
            this.labelInsiraSenha.TabIndex = 13;
            this.labelInsiraSenha.Text = "Insira a senha!";
            this.labelInsiraSenha.Visible = false;
            // 
            // labelInsiraUsuario
            // 
            this.labelInsiraUsuario.AutoSize = true;
            this.labelInsiraUsuario.ForeColor = System.Drawing.Color.Red;
            this.labelInsiraUsuario.Location = new System.Drawing.Point(96, 197);
            this.labelInsiraUsuario.Name = "labelInsiraUsuario";
            this.labelInsiraUsuario.Size = new System.Drawing.Size(113, 20);
            this.labelInsiraUsuario.TabIndex = 12;
            this.labelInsiraUsuario.Text = "Insira o usuário!";
            this.labelInsiraUsuario.Visible = false;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(38, 227);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(52, 20);
            this.labelSenha.TabIndex = 11;
            this.labelSenha.Text = "Senha:";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(28, 167);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(62, 20);
            this.labelUsuario.TabIndex = 10;
            this.labelUsuario.Text = "Usuário:";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(96, 227);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(281, 27);
            this.textBoxSenha.TabIndex = 9;
            this.textBoxSenha.UseSystemPasswordChar = true;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(96, 167);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(281, 27);
            this.textBoxUsuario.TabIndex = 8;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(151, 308);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(94, 29);
            this.buttonCadastrar.TabIndex = 7;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(930, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastrar Séries";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(930, 444);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cadastrar Filmes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário logado:";
            // 
            // labelUsuarioLogado
            // 
            this.labelUsuarioLogado.AutoSize = true;
            this.labelUsuarioLogado.Location = new System.Drawing.Point(132, 9);
            this.labelUsuarioLogado.Name = "labelUsuarioLogado";
            this.labelUsuarioLogado.Size = new System.Drawing.Size(0, 20);
            this.labelUsuarioLogado.TabIndex = 2;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.ForeColor = System.Drawing.Color.Green;
            this.labelStatus.Location = new System.Drawing.Point(110, 524);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(104, 20);
            this.labelStatus.TabIndex = 18;
            this.labelStatus.Text = "ÚLTIMA AÇÃO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 524);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Última ação:";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 553);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelUsuarioLogado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUsuarioLogado;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelInsiraSenha;
        private System.Windows.Forms.Label labelInsiraUsuario;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Label labelInsiraNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label3;
    }
}