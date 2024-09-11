using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Revisao.Models
{
    public abstract class Animal
    {
        public string Nome { get; set; }
        public string Raca { get; set; }

        public abstract void EmitirSom();

        public Animal(string Nome, string Raca)
        {
            this.Nome = Nome;
            this.Raca = Raca;
        }

    }

}