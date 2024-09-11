using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Revisao.Models
{
    public class Cachorro : Animal{
        public Cachorro (string Nome, string Raca):base (Nome, Raca){

        }

        public override void EmitirSom()
        {
            Console.WriteLine("Au Au!");
        }
    } 
}