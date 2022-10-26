using System;
using System.Collections.Generic;
using System.Text;

namespace MetodosAbstratos.Entities
{
    class Juridica : Contribuintes
    {
        public int Funcionarios { get; set; }

        public Juridica(string nome, double rendaAnual, double imposto, int funcionarios) : base(nome, rendaAnual, imposto)
        {
            Funcionarios = funcionarios;
        }

        public override double CalculoImposto()
        {
            return RendaAnual * Funcionarios /100;
        }
    }
}
