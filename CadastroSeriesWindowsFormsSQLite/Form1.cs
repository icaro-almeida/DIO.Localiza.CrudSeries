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
        private UserRepositorio repoUsuarios = new UserRepositorio();
        private SerieRepositorio repoSeries = new SerieRepositorio();
        private Logger logger = LogManager.GetCurrentClassLogger();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool fieldsAreFilled = true;
            if (textBoxUsuario.Text.Equals(""))
            {
                this.labelInsiraUsuario.Visible = true;
                fieldsAreFilled = false;
            }
            else
                this.labelInsiraUsuario.Visible = false;

            if (textBoxSenha.Text.Equals(""))
            {
                this.labelInsiraSenha.Visible = true;
                fieldsAreFilled = false;
            }
            else
                this.labelInsiraSenha.Visible = false;

            if (fieldsAreFilled)
            {
                //tentar login do usuário
                repoUsuarios.ExecutaLogin(textBoxUsuario.Text, textBoxSenha.Text);
            }

        }

    }
}
