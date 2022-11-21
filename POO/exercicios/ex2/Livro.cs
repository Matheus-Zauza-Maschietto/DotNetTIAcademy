using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ex2.autor;
namespace ex2.livro
{
    public class Livro
    {
        public string Nome;
        public Autor[] Autores;
        public Livro(string nome, Autor[] listaAutores){
            Autores = listaAutores;
            Nome = nome;
        }

    }
}