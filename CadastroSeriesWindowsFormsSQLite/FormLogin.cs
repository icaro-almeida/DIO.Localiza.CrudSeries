using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using DIO.Series; //classes, enums and interfaces
using NLog;

namespace CadastroSeriesWindowsFormsSQLite
{
    public partial class FormLogin : Form
    {
        internal UserRepositorio repoUsuarios = new UserRepositorio();
        internal SerieRepositorio repoSeries = new SerieRepositorio();
        private Logger logger = LogManager.GetCurrentClassLogger();

        private FormPrincipal formPrincipal;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool fieldsAreFilled = true;
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
                //tentar login do usuário
                LoginOutput loginOutput = repoUsuarios.ExecutaLogin(textBoxUsuario.Text, textBoxSenha.Text);

                switch (loginOutput)
                {
                    case LoginOutput.Succeeded:
                        this.textBoxUsuario.Text = "";
                        this.textBoxSenha.Text = "";
                        formPrincipal = new FormPrincipal(this);
                        formPrincipal.Show();
                        this.Hide();
                        break;
                    case LoginOutput.UserNotFound:
                        this.labelInsiraUsuario.Text = "Usuário não encontrado!";
                        this.labelInsiraUsuario.Visible = true;
                        break;
                    case LoginOutput.WrongPassword:
                        this.labelInsiraSenha.Text = "Senha incorreta!";
                        this.labelInsiraSenha.Visible = true;
                        break;
                    default:
                        break;
                }
            }

        }

    }
}
