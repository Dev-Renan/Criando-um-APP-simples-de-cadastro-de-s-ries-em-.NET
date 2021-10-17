using System;
using System.Collections.Generic;
using Dio.Series.Interfaces;
namespace Dio.Series.Classes
{
    public class SerieRepositorio : irepositorio<Series> //implementando a classe series
    {
        private List<Series> listaSeries = new List<Series>(); //lista que contem todas as series, desenvolvimento em camadas

        public void Atualiza(int id, Series objeto)
        {
            listaSeries[id] = objeto; //atualiza as series
        }

        public void Exclui(int id)
        {
            listaSeries[id].Exclui(); //exclui as series
            //implementação de enviar e-mail.
        }

        public void Insere(Series objeto)
        {
            listaSeries.Add(objeto); //insere séries
        }

        public List<Series> Lista()
        {
            return listaSeries; //lista s
        }

        public int ProximoId()
        {
            return listaSeries.Count;
        }

        public Series RetornaPorId(int id)
        {
            return listaSeries[id];
        }
    }
}