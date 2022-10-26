using System;
using System.Collections.Generic;
using System.Text;

namespace MetodosAbstratos.Entities
{
    abstract class Contribuintes
    {
        private Contribuintes contribuintes;

        public string Nome { get; set; }
        public double RendaAnual { get; set; }
        public double Imposto { get; set; }

        public Contribuintes()
        {

        }
       
        public Contribuintes(string nome, double rendaAnual, double imposto)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
            Imposto = imposto;
        }

        protected Contribuintes(Contribuintes contribuintes)
        {
            this.contribuintes = contribuintes;
        }

        public abstract double CalculoImposto();

    }
}
