using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        internal SerieRepositorio repoSeries = new SerieRepositorio();
        internal FilmeRepositorio repoFilmes = new FilmeRepositorio();

        private long idSelecionado = 0;

        public FormPrincipal(FormLogin pFormLogin)
        {
            formLogin = pFormLogin;
            InitializeComponent();
            //preenche label com o username do usuario logado
            this.labelUsuarioLogado.Text = formLogin.repoUsuarios.usuarioLogado_username;
            this.labelStatus.Text = $"Usuário {this.labelUsuarioLogado.Text} logado com sucesso!";

            //Preenche combo box de gênero
            comboBoxGenero.DataSource = Listar(typeof(Genero));
            comboBoxGenero.DisplayMember = "Value";
            comboBoxGenero.ValueMember = "Key";

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

        private void AtualizaListViewCadastros()
        {
            if (radioButtonFilme.Checked)
            {
                repoFilmes.RecarregaLista();

                //https://www.youtube.com/watch?v=Q8XQg8PoB9U
                listViewCadastros.Items.Clear();
                foreach (Filme filme in repoFilmes.listaDeFilmes)
                {
                    var row = new string[] { ObterDescricao(filme.Genero), filme.Titulo.ToString(), filme.Ano.ToString() };
                    var lvi = new ListViewItem(row);
                    lvi.Tag = filme; //armazena objeto completo caso precise de detalhes (precisa usar cast do tipo User)
                    listViewCadastros.Items.Add(lvi);
                }
            }
            else if (radioButtonSerie.Checked)
            {
                repoSeries.RecarregaLista();

                //https://www.youtube.com/watch?v=Q8XQg8PoB9U
                listViewCadastros.Items.Clear();
                foreach (Serie serie in repoSeries.listaDeSeries)
                {
                    var row = new string[] { ObterDescricao(serie.Genero), serie.Titulo.ToString(), serie.Ano.ToString() };
                    var lvi = new ListViewItem(row);
                    lvi.Tag = serie; //armazena objeto completo caso precise de detalhes (precisa usar cast do tipo User)
                    listViewCadastros.Items.Add(lvi);
                }
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
            //verifica se nome foi inserido e informa ao usuário
            if (textBoxNome.Text.Equals(""))
            {
                this.labelInsiraNome.Text = "Insira o nome!";
                this.labelInsiraNome.Visible = true;
                fieldsAreFilled = false;
            }
            else
                this.labelInsiraNome.Visible = false;

            
            if (textBoxUsuario.Text.Equals("")) // se usuario NÃO foi digitado
            { //informa ao usuário
                this.labelInsiraUsuario.Text = "Insira o usuário!";
                this.labelInsiraUsuario.Visible = true;
                fieldsAreFilled = false;
            }
            //todo - melhorar esta analise... está um pouco confusa
            else if (usernameAvailable) //só remove mensagem de usuário indisponível se username estiver livre
                this.labelInsiraUsuario.Visible = false;

            //verifica se a senha foi inserida e informa ao usuário
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
                //todo - verificar necessidade de retestar usuario disponivel
                if (formLogin.repoUsuarios.BuscaUsuario(textBoxUsuario.Text) == null) //se username está disponível
                {
                    //cadastra novo usuário
                    User novoUsuario = new User(textBoxNome.Text, textBoxUsuario.Text, textBoxSenha.Text);
                    
                    if (formLogin.repoUsuarios.InsereUsuario(novoUsuario)) //se inseriu usuário com sucesso
                    {
                        ResetTabUsuarios();
                        this.labelStatus.Text = $"Usuário {novoUsuario.Username} inserido com sucesso!";
                        logger.Trace($"Usuário {novoUsuario.Username} inserido com sucesso!");
                        AtualizaListViewUsers();
                    }
                    else //se não inseriu usuário novo
                    {
                        this.labelStatus.Text = $"Erro ao inserir usuário {novoUsuario.Username}!";
                        logger.Trace($"Erro ao inserir usuário {novoUsuario.Username}!");
                    }
                }
                else //se username NÃO está disponível
                {
                    this.labelInsiraUsuario.ForeColor = Color.Red;
                    this.labelInsiraUsuario.Text = "Usuário já cadastrado!";
                    this.labelInsiraUsuario.Visible = true;
                }
            }

        }

        private void ResetTabUsuarios()
        {
            //limpa campos e mensagens ao usuário após inserção de novo usuário
            this.labelInsiraNome.Visible = false;
            this.labelInsiraUsuario.Visible = false;
            this.labelInsiraSenha.Visible = false;
            this.textBoxNome.Text = "";
            this.textBoxUsuario.Text = "";
            this.textBoxSenha.Text = "";
        }

        /// <summary>
        /// Obtém a descrição de um determinado Enumerador.
        /// </summary>
        /// <param name="valor">Enumerador que terá a descrição obtida.</param>
        /// <returns>String com a descrição do Enumerador.</returns>
        /// https://imasters.com.br/dotnet/populando-um-combobox-com-enumeradores
        public static string ObterDescricao(Enum valor)
        {
            FieldInfo fieldInfo = valor.GetType().GetField(valor.ToString());

            DescriptionAttribute[] atributos = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return atributos.Length > 0 ? atributos[0].Description ?? "Nulo" : valor.ToString();
        }

        /// <summary>
        /// Retorna uma lista com os valores de um determinado enumerador.
        /// </summary>
        /// <param name="tipo">Enumerador que terá os valores listados.</param>
        /// <returns>Lista com os valores do Enumerador.</returns>
        /// https://imasters.com.br/dotnet/populando-um-combobox-com-enumeradores
        public static IList Listar(Type tipo)
        {
            ArrayList lista = new ArrayList();
            if (tipo != null)
            {
                Array enumValores = Enum.GetValues(tipo);
                foreach (Enum valor in enumValores)
                {
                    lista.Add(new KeyValuePair<Enum, string>(valor, ObterDescricao(valor)));
                }
            }

            return lista;
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "") //se nao inseriu username
            {
                usernameAvailable = false;
                this.labelInsiraUsuario.Visible = false;
                return;
            }

            if (formLogin.repoUsuarios.BuscaUsuario(textBoxUsuario.Text) == null) //se username está disponível
            { //informa ao usuário enquanto ele digita
                usernameAvailable = true;
                this.labelInsiraUsuario.ForeColor = Color.Green;
                this.labelInsiraUsuario.Text = $"Usuário {textBoxUsuario.Text} disponível!";
                this.labelInsiraUsuario.Visible = true;
            }
            else //se username NÃO está disponível
            { //informa ao usuário enquanto ele digita
                usernameAvailable = false;
                this.labelInsiraUsuario.ForeColor = Color.Red;
                this.labelInsiraUsuario.Text = $"Usuário {textBoxUsuario.Text} indisponível!";
                this.labelInsiraUsuario.Visible = true;
            }
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNome.Text != "") //se o nome foi preenchido
            { //remove mensagem ao usuário
                labelInsiraNome.Visible = false;
            }
        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSenha.Text != "") //se a senha foi preenchida
            { //remove mensagem ao usuário
                labelInsiraSenha.Visible = false;
            }
        }

        private void radioButtonSerie_CheckedChanged(object sender, EventArgs e)
        {
            AtualizaListViewCadastros();
        }

        private void listViewCadastros_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listViewCadastros.SelectedItems.Count == 1)
            {
                buttonAtualizarSerieFilme.Enabled = true;

                EntidadeBase itemSelecionado = (EntidadeBase)listViewCadastros.SelectedItems[0].Tag;

                idSelecionado = itemSelecionado.Id;

                comboBoxGenero.SelectedIndex = (int)itemSelecionado.Genero;
                textBoxTitulo.Text = itemSelecionado.Titulo;
                numericUpDownAno.Value = itemSelecionado.Ano;
                richTextBoxDescricao.Text = itemSelecionado.Descricao;
                checkBoxExcluido.Checked = itemSelecionado.Excluido;
            }
            else if (listViewCadastros.SelectedItems.Count == 0)
            {
                buttonAtualizarSerieFilme.Enabled = false;
            }         
        }

        private void buttonAtualizarSerieFilme_Click(object sender, EventArgs e)
        {
            if (radioButtonFilme.Checked)
            {
                var novoFilme = new Filme(idSelecionado,
                 Convert.ToInt64(comboBoxGenero.SelectedIndex),
                 textBoxTitulo.Text,
                 richTextBoxDescricao.Text,
                 (int)numericUpDownAno.Value,
                 Convert.ToInt64(checkBoxExcluido.Checked));
                SqliteDataAccess.UpdateFilme(novoFilme);
            }
            else if (radioButtonSerie.Checked)
            {
                var novaSerie = new Serie(idSelecionado,
                 Convert.ToInt64(comboBoxGenero.SelectedIndex),
                 textBoxTitulo.Text,
                 richTextBoxDescricao.Text,
                 (int)numericUpDownAno.Value,
                 Convert.ToInt64(checkBoxExcluido.Checked));
                SqliteDataAccess.UpdateSerie(novaSerie);
            }

            AtualizaListViewCadastros();
        }

    }//fim da classe

}//fim do namespace
