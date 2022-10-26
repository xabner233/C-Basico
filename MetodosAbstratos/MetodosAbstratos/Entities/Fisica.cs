using System;
using System.Collections.Generic;
using System.Text;
using MetodosAbstratos.Entities;

namespace MetodosAbstratos.Entities
{
    class Fisica : Contribuintes 
    {
        public double  Saude { get; set; }
        

        public Fisica(string nome, double rendaAnual, double imposto, double saude) : base (nome, rendaAnual, imposto)
        {
            Saude = saude;
        }

       
        public override double CalculoImposto()
        {
                     
            return (RendaAnual *( Imposto /100)) - (Saude * 50 / 100);
        }
    }
}
