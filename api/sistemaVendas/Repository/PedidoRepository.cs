using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistemaVendas.Context;
using sistemaVendas.Models;
using sistemaVendas.Dto;
using Microsoft.EntityFrameworkCore;

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

        public Pedido ObterPorId(int id)
        {
            var pedido = _context.Pedidos.Include(x => x.Vendedor)
                                         .Include(x => x.Cliente)
                                         .FirstOrDefault(x => x.Id == id);
            return pedido;
        }

        public List<ObterPedidoComIdDTO> ObterTodos()
        {
            var pedidos = _context.Pedidos.Include(x => x.Vendedor)
                                          .Include(x => x.Cliente)
                                          .Select(x => new ObterPedidoComIdDTO(x))
                                          .ToList(); 
            return pedidos;
        }

        public void AtualizarPedido(Pedido pedido)
        {
            _context.Pedidos.Update(pedido);
            _context.SaveChanges();
        }

        public void DeletarPedido(Pedido pedido)
        {
            _context.Pedidos.Remove(pedido);
            _context.SaveChanges();
        }
    }
}