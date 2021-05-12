using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DIO.Series;
using NLog;

namespace CadastroSeriesWindowsFormsSQLite
{
    public partial class FormPrincipal : Form
    {
        FormLogin formLogin;
        private Logger logger = LogManager.GetCurrentClassLogger();
        private bool usernameAvailable = false;


        public FormPrincipal(FormLogin pFormLogin)
        {
            formLogin = pFormLogin;
            InitializeComponent();
            //preenche label com o username do usuario logado
            this.labelUsuarioLogado.Text = formLogin.repoUsuarios.usuarioLogado_username;
            this.labelStatus.Text = $"Usuário {this.labelUsuarioLogado.Text} logado com sucesso!";

            AtualizaListViewUsers();
        }

        private void AtualizaListViewUsers()
        {
            //preenche listViewUsers
            //https://www.youtube.com/watch?v=Q8XQg8PoB9U
            listViewUsers.Items.Clear();
            foreach (User user in formLogin.repoUsuarios.listaUsers)
            {
                var row = new string[] { user.Id.ToString(), user.Username, user.Nome };
                var lvi = new ListViewItem(row);
                lvi.Tag = user; //armazena objeto completo caso precise de detalhes (precisa usar cast do tipo User)
                listViewUsers.Items.Add(lvi);
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            formLogin.repoUsuarios.ExecutaLogoff();
            formLogin.Show();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            bool fieldsAreFilled = true;
            //verifica se nome foi inserido
            if (textBoxNome.Text.Equals(""))
            {
                this.labelInsiraNome.Text = "Insira o nome!";
                this.labelInsiraNome.Visible = true;
                fieldsAreFilled = false;
            }
            else
                this.labelInsiraNome.Visible = false;

            //verifica se usuario foi inserido
            if (textBoxUsuario.Text.Equals(""))
            {
                this.labelInsiraUsuario.Text = "Insira o usuário!";
                this.labelInsiraUsuario.Visible = true;
                fieldsAreFilled = false;
            }
            else if (usernameAvailable) //evita a remoção da mensagem de usuário indisponível
                this.labelInsiraUsuario.Visible = false;

            //verifica se a senha foi inserida
            if (textBoxSenha.Text.Equals(""))
            {
                this.labelInsiraSenha.Text = "Insira a senha!";
                this.labelInsiraSenha.Visible = true;
                fieldsAreFilled = false;
            }
            else
                this.labelInsiraSenha.Visible = false;


            if (usernameAvailable && fieldsAreFilled)
            {
                //add - fazer verificação de usuario disponivel enquanto digita
                if (formLogin.repoUsuarios.BuscaUsuario(textBoxUsuario.Text) == null)
                {
                    User novoUsuario = new User(textBoxNome.Text, textBoxUsuario.Text, textBoxSenha.Text);
                    formLogin.repoUsuarios.InsereUsuario(novoUsuario);
                    ResetTabUsuarios();
                    this.labelStatus.Text = $"Usuário {novoUsuario.Username} inserido com sucesso!";
                    logger.Trace($"Usuário {novoUsuario.Username} inserido com sucesso!");
                    AtualizaListViewUsers();
                }
                else
                {
                    this.labelInsiraUsuario.ForeColor = Color.Red;
                    this.labelInsiraUsuario.Text = "Usuário já cadastrado!";
                    this.labelInsiraUsuario.Visible = true;
                }
            }

        }

        private void ResetTabUsuarios()
        {
            this.labelInsiraNome.Visible = false;
            this.labelInsiraUsuario.Visible = false;
            this.labelInsiraSenha.Visible = false;
            this.textBoxNome.Text = "";
            this.textBoxUsuario.Text = "";
            this.textBoxSenha.Text = "";
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "")
            {
                usernameAvailable = false;
                this.labelInsiraUsuario.Visible = false;
                return;
            }
            if (formLogin.repoUsuarios.BuscaUsuario(textBoxUsuario.Text) == null)
            {
                usernameAvailable = true;
                this.labelInsiraUsuario.ForeColor = Color.Green;
                this.labelInsiraUsuario.Text = $"Usuário {textBoxUsuario.Text} disponível!";
                this.labelInsiraUsuario.Visible = true;
            }
            else
            {
                usernameAvailable = false;
                this.labelInsiraUsuario.ForeColor = Color.Red;
                this.labelInsiraUsuario.Text = $"Usuário {textBoxUsuario.Text} indisponível!";
                this.labelInsiraUsuario.Visible = true;
            }
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNome.Text != "")
            {
                labelInsiraNome.Visible = false;
            }
        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSenha.Text != "")
            {
                labelInsiraSenha.Visible = false;
            }
        }
    }
}
