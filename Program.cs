using System.Net.WebSockets;
using System.Runtime.InteropServices;
using Revisao.Models;

Console.Clear();

Cachorro dog1 = new Cachorro("fred", "SRD");

Gato cat1 = new Gato("Pedro", "Persa");

Console.WriteLine("-------------------------------------------------------");

Clinica NovoPet = new Clinica("NovoPet");
NovoPet.AdicionarAnimal(dog1);
NovoPet.AdicionarAnimal(cat1);

Veterinario Manuel = new Veterinario("Roberto", "70707070");
Manuel.Examinar(NovoPet.animals);
//teste
