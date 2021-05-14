using System;
using System.Collections.Generic;

namespace DIO.Series
{
	public class FilmeRepositorio : IRepositorio<Filme>
	{
        public List<Filme> listaDeFilmes { get; private set; }

		public FilmeRepositorio()
		{
			// loads from db into list
			listaDeFilmes = SqliteDataAccess.LoadFilmes();
		}

		public void RecarregaLista()
        {
			// reloads from db into list
			listaDeFilmes = SqliteDataAccess.LoadFilmes();
		}

		public void Atualiza(int id, Filme objeto)
		{
			listaDeFilmes[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaDeFilmes[id].Excluir();
		}

		public void Insere(Filme objeto)
		{
			listaDeFilmes.Add(objeto);
		}

		public List<Filme> Lista()
		{
			return listaDeFilmes;
		}

		public int ProximoId()
		{
			return listaDeFilmes.Count;
		}

		public Filme RetornaPorId(int id)
		{
			return listaDeFilmes[id];
		}
	}
}