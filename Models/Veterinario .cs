using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Revisao.Models
{
    public class Veterinario 
    {
        public string  Nome { get; set; }
        public string Cnpj { get; set; }
        
        public Veterinario(string nome, string cnpj)
        {
            Nome = nome;
            Cnpj = cnpj;
        }

        public void Examinar(Animal animal)
        {
            DateTime DataHora = DateTime.Now;
            Console.WriteLine("Iniciando o exame do animal " + animal.Nome + " em " + DataHora.ToString("G"));
            Console.WriteLine("Tipo do animal: " + animal.GetType().Name);
            Console.WriteLine("Raça: " + animal.Raca);
            Console.Write("Som do animal: ");
            animal.EmitirSom();
            Console.WriteLine("Fim do exame do animal " + animal.Nome);
            Console.WriteLine("-------------------------------------------------------");

        }

        public void Examinar(List<Animal> animals)
        {
            Console.WriteLine("Iniciando exames da lista de animais:");
            Console.WriteLine("-------------------------------------------------------");

            foreach (Animal animal in animals)
            {
                Examinar(animal);
                Console.WriteLine();
            }

            Console.WriteLine("Fim dos exames da lista de animais");
            Console.WriteLine("-------------------------------------------------------");

        }
    }
}