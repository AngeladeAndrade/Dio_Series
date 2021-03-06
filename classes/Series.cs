using Dio.series.classes.Enum;
using System;
namespace Dio.Series.classes
{
    public class Serie : IntidadeBase

    {
       
        
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido {get; set;}

         public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido= false;

        }
        public override string ToString()
        {
            string retorno = "";
            retorno +=" Genero: "+ this.Genero + Environment.NewLine;
            retorno += "Titulo: "+ this.Titulo + Environment.NewLine;
            retorno +=" Descricao: " +this.Descricao + Environment. NewLine;
            retorno += "Ano: " +this.Ano + Environment. NewLine;

            return retorno;

        }
        public string retornaTitulo()
        {
            return this.Titulo;

        }
         public int retornaId()
        {
            return this.Id;

        }

        public void Excluir()
        {
          this.Excluido = true;
        }   
    }

}


