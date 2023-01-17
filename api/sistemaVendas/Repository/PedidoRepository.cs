using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistemaVendas.Context;
using sistemaVendas.Models;
using sistemaVendas.Dto;

namespace sistemaVendas.Repository
{
     public class PedidoRepository
    {
        private readonly VendasContext _context;

        public PedidoRepository(VendasContext context)
        {
            _context = context;
        }
        public void Cadastrar(Pedido pedido){
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();
        }
    }
}