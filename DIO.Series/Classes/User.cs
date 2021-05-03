using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.Series
{
	
	public class User
    {
		public Int64 Id { get; private set; }
		public string Nome { get; private set; }
		public string Username { get; private set; }
		public string Senha { get; private set; }	
		public string Salt { get; private set; }

		

		public User(Int64 Id, String Nome,String Username,String Senha, String Salt)
		{
			this.Id = Id;
			this.Nome = Nome;
			this.Username = Username;			
			this.Senha = Senha;
			this.Salt = Salt;
		}
		public User(string pNome, string pUsername, string pSenha)
        {
			this.Nome = pNome;
			this.Username = pUsername;
			this.Salt = Password.CreateSalt(8);
			this.Senha = Password.GenerateSaltedHash(pSenha, this.Salt);
		}


		/// <summary>
		/// Verifica senha antiga inserida e troca pela senha nova
		/// </summary>
		/// <param name="pSenhaAntiga"></param>
		/// <param name="pSenhaNova"></param>
		/// <returns></returns>
		public bool AlterarSenha(string pSenhaAntiga, string pSenhaNova)
        {
			if (!Password.CompararSenhas(pSenhaAntiga, this.Salt, this.Senha))
			{
				Console.WriteLine("Senha incorreta!");
				return false;
			}

			this.Senha = Password.GenerateSaltedHash(pSenhaNova, this.Salt);
			return true;
		}



	}//fim da classe
}// fim do namespace
