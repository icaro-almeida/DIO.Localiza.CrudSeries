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

namespace CadastroSeriesWindowsFormsSQLite
{
    public partial class FormPrincipal : Form
    {
        FormLogin formLogin;

        public FormPrincipal(FormLogin pFormLogin)
        {
            formLogin = pFormLogin;
            InitializeComponent();
            //preenche label com o username do usuario logado
            this.labelUsuarioLogado.Text = formLogin.repoUsuarios.usuarioLogado_username;
            this.labelStatus.Text = $"Usuário {this.labelUsuarioLogado.Text} logado com sucesso!";
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
                this.labelInsiraUsuario.Visible = false;

            //verifica se usuario foi inserido
            if (textBoxUsuario.Text.Equals(""))
            {
                this.labelInsiraUsuario.Text = "Insira o usuário!";
                this.labelInsiraUsuario.Visible = true;
                fieldsAreFilled = false;
            }
            else
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

            if (fieldsAreFilled)
            {
                //todo - fazer verificação de usuario disponivel enquanto digita
                if (formLogin.repoUsuarios.BuscaUsuario(textBoxUsuario.Text) == null)
                {
                    User novoUsuario = new User(textBoxNome.Text, textBoxUsuario.Text, textBoxSenha.Text);
                    formLogin.repoUsuarios.InsereUsuario(novoUsuario);
                    this.labelInsiraNome.Visible = false;
                    this.labelInsiraUsuario.Visible = false;
                    this.labelInsiraSenha.Visible = false;
                    this.labelStatus.Text = $"Usuário {novoUsuario.Username} inserido com sucesso!";                    
                }
                else
                {
                    this.labelInsiraUsuario.Text = "Usuário já cadastrado!";
                    this.labelInsiraUsuario.Visible = true;
                }
                
            }
        }
    }
}
