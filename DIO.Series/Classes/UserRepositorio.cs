﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.Series
{
    public class UserRepositorio
    {
        private List<User> listaUsers = new List<User>();
        public string usuarioLogado_username;

        //todo entender erro abaixo
        private User _usuarioLogado;
        public User UsuarioLogado
        {
            get
            {
                return _usuarioLogado;
            }
            set
            {
                _usuarioLogado = value;
                usuarioLogado_username = _usuarioLogado.Username;
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
        private User BuscaUsuario(string pUsuario)
        {
            List<User> resultsList = this.listaUsers.FindAll(x => (x.Username == pUsuario));
            if (resultsList.Count == 0)
            {
                return null;
            }
            else
            {
                //Como o nome de usuário é único no banco de dados, pode-se retornar o primeiro
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
            {
                senhaCorreta = Password.CompararSenhas(pSenha, usuario.Salt, usuario.Senha);
            }
            else
                return LoginOutput.UserNotFound;

            if (senhaCorreta)
            {
                this.UsuarioLogado = usuario;
            }
            else
                return LoginOutput.WrongPassword;

            //todo log into log file
            return LoginOutput.Succeeded;
        }

    }
}