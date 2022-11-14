using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.aula2.models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Idade { get; set; }
        public virtual void Apresentar(){
            Console.WriteLine($"Olá meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}