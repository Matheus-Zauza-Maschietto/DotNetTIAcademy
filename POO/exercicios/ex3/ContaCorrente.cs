using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex3.ContaCorrente
{
    public class ContaCorrente
    {   
        public string NomeCorrentista { get; set; }
        protected int numero_conta { get; set; }
        protected int numero_agencia { get; set; }
        private double _saldo { get; set; }

        public ContaCorrente(string _NomeCorrentista, int _NumeroConta, int _NumeroAgencia, double _Saldo){
            NomeCorrentista = _NomeCorrentista;
            numero_conta = _NumeroConta;
            numero_agencia = _NumeroAgencia;
            _saldo = _Saldo;
        }
    }
}