using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.Series
{
    public class UserRepositorio
    {
        public List<User> listaUsers { get; private set; }
        public string usuarioLogado_username;
        private Logger logger = LogManager.GetCurrentClassLogger();

        private User _usuarioLogado;
        private User UsuarioLogado
        {
            get
            {
                return _usuarioLogado;
            }
            set
            {
                _usuarioLogado = value;
                if (_usuarioLogado != null)
                    usuarioLogado_username = _usuarioLogado.Username;
                else
                    usuarioLogado_username = "";
            }
        }

        public UserRepositorio()
        {
            // loads from db into list
            listaUsers = SqliteDataAccess.LoadUsers();
        }

        /// <summary>
        /// Busca usuário na lista por username
        /// </summary>
        /// <param name="pUsuario"></param>
        /// <returns>True se o usuário foi encontrado</returns>
        public User BuscaUsuario(string pUsuario)
        {
            List<User> resultsList = this.listaUsers.FindAll(x => (x.Username == pUsuario));
            if (resultsList.Count == 0)
            {
                return null;
            }
            else
            {
                //Como o nome de usuário é único no banco de dados, pode-se retornar o primeiro encontrado
                return resultsList[0];
            }
        }

        /// <summary>
        /// Exibe login do operador e pede usuário e senha
        /// </summary>
        /// <param name="pListOperadores">Lista de operadores</param>
        /// <returns></returns>
        public LoginOutput ExecutaLogin(string pUsername, string pSenha)
        {
            User usuario = null;
            bool senhaCorreta = false;

            usuario = BuscaUsuario(pUsername);
            if (usuario != null)
                senhaCorreta = Password.CompararSenhas(pSenha, usuario.Salt, usuario.Senha);
            else
                return LoginOutput.UserNotFound;

            if (senhaCorreta) //faz login
            {
                this.UsuarioLogado = usuario;
                logger.Trace($"Usuário {pUsername} fez login.");
                return LoginOutput.Succeeded;
            }
            else
                return LoginOutput.WrongPassword;

        }

        public void ExecutaLogoff()
        {
            logger.Trace($"Usuário {usuarioLogado_username} fez logoff.");
            UsuarioLogado = null;
        }

        public bool InsereUsuario(User pUsuarioNovo)
        {
            //inserts a new user into DB
            SqliteDataAccess.SaveUser(pUsuarioNovo);
            // loads from db into list
            listaUsers = SqliteDataAccess.LoadUsers();

            //todo - analisar possivel melhoria ou sobrecarga do método BuscaUsuario, ex: retornar boolean
            if (BuscaUsuario(pUsuarioNovo.Username) != null)
                return true;
            else
                return false;
        }

    }
}
