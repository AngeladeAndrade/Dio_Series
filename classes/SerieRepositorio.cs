using System;
using System.Collections.Generic;
using Dio.series.interfaces;
using Dio.Series.classes;

namespace Dio.series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {

        private List<Serie> listaSerie = new List<Serie>();

            public void atualizar(int id, Serie Objeto )
        {
           listaSerie[id] = Objeto;    }

        public void Exclui(int id)
        {
            listaSerie[id]. Excluir();     }

        public void Insere(Serie objeto)
        {
           listaSerie.Add(objeto);
        }

        public List<Serie> List()
        {
            return listaSerie;
        }

                public int ProximoId()
        {
             return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
             return listaSerie[id];
        }
    }
}   
    
