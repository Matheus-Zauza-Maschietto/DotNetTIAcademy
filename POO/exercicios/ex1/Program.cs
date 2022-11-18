using ex1;
using System;

class exercicio1{
    static void Main(){
        Passaro passarinho = new Passaro("Arara", "Pequeno");
        passarinho.EmitirSom();

        Cachorro cachorro = new Cachorro("Vira-Lata", "Grande");
        cachorro.EmitirSom();

        Gato gato = new Gato("Siames", "Médio");
        gato.EmitirSom();
    }
}


