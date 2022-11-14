using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.aula3.models
{
    public class ContaCorrente
    {
        public int Numero { get; set; }
        private decimal Saldo { get; set; }

        public ContaCorrente(decimal saldoInicial){
            Saldo = saldoInicial;
        }

        public void Sacar(int valor){
            if(valor > Saldo){
                Console.WriteLine("Saldo insuiciente");
            }
            else{
                Saldo = Saldo-valor;
                Console.WriteLine("Saldo retirado com sucesso");
            }
            
        }

        public void ExibirSaldo(){
            Console.WriteLine("Seu saldo é "+Saldo);
        }
    }
}