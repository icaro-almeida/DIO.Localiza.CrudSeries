using System;
using System.Collections.Generic;

namespace DIO.Series
{
	public class SerieRepositorio : IRepositorio<Serie>
	{
        public List<Serie> listaDeSeries { get; private set; }

		public SerieRepositorio()
		{
			// loads from db into list
			listaDeSeries = SqliteDataAccess.LoadSeries();
		}

		public void RecarregaLista()
		{
			// reloads from db into list
			listaDeSeries = SqliteDataAccess.LoadSeries();
		}

		public void Atualiza(int id, Serie objeto)
		{
			listaDeSeries[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaDeSeries[id].Excluir();
		}

		public void Insere(Serie objeto)
		{
			listaDeSeries.Add(objeto);
		}

		public List<Serie> Lista()
		{
			return listaDeSeries;
		}

		public int ProximoId()
		{
			return listaDeSeries.Count;
		}

		public Serie RetornaPorId(int id)
		{
			return listaDeSeries[id];
		}
	}
}