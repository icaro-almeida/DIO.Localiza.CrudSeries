using System;

namespace DIO.Series
{
    public class Filme : EntidadeBase
    {

        // Métodos
        public Filme(long Id, Int64 Genero, String Titulo, String Descricao, Int64 Ano, Int64 Excluido)
        {
            this.Id = Id;
            this.Genero = (Genero)Genero;
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.Ano = (int)Ano;
            this.Excluido = Convert.ToBoolean(Excluido);
        }
        public Filme(int id, Genero genero, string titulo, string descricao, int ano)
		{
			this.Id = id;
			this.Genero = genero;
			this.Titulo = titulo;
			this.Descricao = descricao;
			this.Ano = ano;
            this.Excluido = false;
		}

        public override string ToString()
		{
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
			return retorno;
		}       
    }
}