using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POO.aula2.models;

namespace POO.aula4.models
{
    public class Aluno : Pessoa{
        public double Nota { get; set; }
        public override void Apresentar(){
            Console.WriteLine($"Meu nome é {Nome}, tenho {Idade} anos, e sou um alunos nota {Nota}");
        }
    }
}