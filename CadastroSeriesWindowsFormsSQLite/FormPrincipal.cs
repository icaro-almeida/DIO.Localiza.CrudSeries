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
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            formLogin.repoUsuarios.ExecutaLogoff();
            formLogin.Show();
        }
    }
}
