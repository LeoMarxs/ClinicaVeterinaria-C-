using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Revisao.Models
{
    public class Clinica 
    {
        public string RazaoSocial { get; set; }
        public List<Animal> animals { get; set; }
        public Clinica(string RazaoSocial)
        {
            this.RazaoSocial = RazaoSocial;
            this.animals = new List<Animal>();
        }

        public void AdicionarAnimal(Animal animal)
        {
            this.animals.Add(animal);
        }
    }
}