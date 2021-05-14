
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
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.columnHeaderId = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderUser = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderNome = new System.Windows.Forms.ColumnHeader();
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
            this.buttonCadastrarUsuario = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxExcluido = new System.Windows.Forms.CheckBox();
            this.listViewCadastros = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.numericUpDownAno = new System.Windows.Forms.NumericUpDown();
            this.buttonAtualizarSerieFilme = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtonFilme = new System.Windows.Forms.RadioButton();
            this.radioButtonSerie = new System.Windows.Forms.RadioButton();
            this.richTextBoxDescricao = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUsuarioLogado = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAno)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(938, 477);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewUsers);
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
            this.tabPage1.Controls.Add(this.buttonCadastrarUsuario);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(930, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Usuários";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewUsers
            // 
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderUser,
            this.columnHeaderNome});
            this.listViewUsers.FullRowSelect = true;
            this.listViewUsers.GridLines = true;
            this.listViewUsers.HideSelection = false;
            this.listViewUsers.Location = new System.Drawing.Point(640, 3);
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(287, 438);
            this.listViewUsers.TabIndex = 18;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "ID";
            this.columnHeaderId.Width = 40;
            // 
            // columnHeaderUser
            // 
            this.columnHeaderUser.Text = "Usuário";
            this.columnHeaderUser.Width = 120;
            // 
            // columnHeaderNome
            // 
            this.columnHeaderNome.Text = "Nome";
            this.columnHeaderNome.Width = 120;
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
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
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
            this.textBoxSenha.TextChanged += new System.EventHandler(this.textBoxSenha_TextChanged);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(96, 167);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(281, 27);
            this.textBoxUsuario.TabIndex = 8;
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
            // 
            // buttonCadastrarUsuario
            // 
            this.buttonCadastrarUsuario.Location = new System.Drawing.Point(151, 308);
            this.buttonCadastrarUsuario.Name = "buttonCadastrarUsuario";
            this.buttonCadastrarUsuario.Size = new System.Drawing.Size(94, 29);
            this.buttonCadastrarUsuario.TabIndex = 7;
            this.buttonCadastrarUsuario.Text = "Cadastrar";
            this.buttonCadastrarUsuario.UseVisualStyleBackColor = true;
            this.buttonCadastrarUsuario.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBoxExcluido);
            this.tabPage2.Controls.Add(this.listViewCadastros);
            this.tabPage2.Controls.Add(this.numericUpDownAno);
            this.tabPage2.Controls.Add(this.buttonAtualizarSerieFilme);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.radioButtonFilme);
            this.tabPage2.Controls.Add(this.radioButtonSerie);
            this.tabPage2.Controls.Add(this.richTextBoxDescricao);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBoxTitulo);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.comboBoxGenero);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(930, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Séries e Filmes";
            this.tabPage2.ToolTipText = "Cadastrar ou atualizar séries e filmes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBoxExcluido
            // 
            this.checkBoxExcluido.AutoSize = true;
            this.checkBoxExcluido.Location = new System.Drawing.Point(23, 376);
            this.checkBoxExcluido.Name = "checkBoxExcluido";
            this.checkBoxExcluido.Size = new System.Drawing.Size(87, 24);
            this.checkBoxExcluido.TabIndex = 20;
            this.checkBoxExcluido.Text = "Excluído";
            this.checkBoxExcluido.UseVisualStyleBackColor = true;
            // 
            // listViewCadastros
            // 
            this.listViewCadastros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewCadastros.FullRowSelect = true;
            this.listViewCadastros.GridLines = true;
            this.listViewCadastros.HideSelection = false;
            this.listViewCadastros.Location = new System.Drawing.Point(490, 58);
            this.listViewCadastros.MultiSelect = false;
            this.listViewCadastros.Name = "listViewCadastros";
            this.listViewCadastros.Size = new System.Drawing.Size(427, 383);
            this.listViewCadastros.TabIndex = 19;
            this.listViewCadastros.UseCompatibleStateImageBehavior = false;
            this.listViewCadastros.View = System.Windows.Forms.View.Details;
            this.listViewCadastros.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewCadastros_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Gênero";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Título";
            this.columnHeader2.Width = 230;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ano";
            this.columnHeader3.Width = 80;
            // 
            // numericUpDownAno
            // 
            this.numericUpDownAno.Location = new System.Drawing.Point(116, 151);
            this.numericUpDownAno.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownAno.Name = "numericUpDownAno";
            this.numericUpDownAno.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownAno.TabIndex = 12;
            // 
            // buttonAtualizarSerieFilme
            // 
            this.buttonAtualizarSerieFilme.Enabled = false;
            this.buttonAtualizarSerieFilme.Location = new System.Drawing.Point(185, 371);
            this.buttonAtualizarSerieFilme.Name = "buttonAtualizarSerieFilme";
            this.buttonAtualizarSerieFilme.Size = new System.Drawing.Size(160, 29);
            this.buttonAtualizarSerieFilme.TabIndex = 11;
            this.buttonAtualizarSerieFilme.Text = "Atualizar";
            this.buttonAtualizarSerieFilme.UseVisualStyleBackColor = true;
            this.buttonAtualizarSerieFilme.Click += new System.EventHandler(this.buttonAtualizarSerieFilme_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tipo:";
            // 
            // radioButtonFilme
            // 
            this.radioButtonFilme.AutoSize = true;
            this.radioButtonFilme.Location = new System.Drawing.Point(185, 18);
            this.radioButtonFilme.Name = "radioButtonFilme";
            this.radioButtonFilme.Size = new System.Drawing.Size(66, 24);
            this.radioButtonFilme.TabIndex = 9;
            this.radioButtonFilme.TabStop = true;
            this.radioButtonFilme.Text = "Filme";
            this.radioButtonFilme.UseVisualStyleBackColor = true;
            // 
            // radioButtonSerie
            // 
            this.radioButtonSerie.AutoSize = true;
            this.radioButtonSerie.Location = new System.Drawing.Point(116, 18);
            this.radioButtonSerie.Name = "radioButtonSerie";
            this.radioButtonSerie.Size = new System.Drawing.Size(63, 24);
            this.radioButtonSerie.TabIndex = 8;
            this.radioButtonSerie.TabStop = true;
            this.radioButtonSerie.Text = "Série";
            this.radioButtonSerie.UseVisualStyleBackColor = true;
            this.radioButtonSerie.CheckedChanged += new System.EventHandler(this.radioButtonSerie_CheckedChanged);
            // 
            // richTextBoxDescricao
            // 
            this.richTextBoxDescricao.Location = new System.Drawing.Point(116, 194);
            this.richTextBoxDescricao.Name = "richTextBoxDescricao";
            this.richTextBoxDescricao.Size = new System.Drawing.Size(338, 120);
            this.richTextBoxDescricao.TabIndex = 7;
            this.richTextBoxDescricao.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Descrição:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ano:";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(116, 102);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(338, 27);
            this.textBoxTitulo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Título:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gênero:";
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Location = new System.Drawing.Point(116, 58);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(151, 28);
            this.comboBoxGenero.TabIndex = 0;
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
            this.Text = "CRUD Séries e Filmes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUsuarioLogado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelInsiraSenha;
        private System.Windows.Forms.Label labelInsiraUsuario;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Button buttonCadastrarUsuario;
        private System.Windows.Forms.Label labelInsiraNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderUser;
        private System.Windows.Forms.ColumnHeader columnHeaderNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonFilme;
        private System.Windows.Forms.RadioButton radioButtonSerie;
        private System.Windows.Forms.RichTextBox richTextBoxDescricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonAtualizarSerieFilme;
        private System.Windows.Forms.ListView listViewCadastros;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.NumericUpDown numericUpDownAno;
        private System.Windows.Forms.CheckBox checkBoxExcluido;
    }
}