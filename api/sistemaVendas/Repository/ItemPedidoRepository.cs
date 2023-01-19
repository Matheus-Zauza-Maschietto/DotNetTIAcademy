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
    public class ItemPedidoRepository
    {
        private readonly VendasContext _context;
        public ItemPedidoRepository(VendasContext context)
        {
            _context = context;
        }

        public void Cadastrar(ItemPedido itemPedido)
        {
            _context.ItensPedido.Add(itemPedido);
            _context.SaveChanges();
        }

        public List<ObterItemPedidoComIdDTO> ObterTodos()
        {
           var itensPedido = _context.ItensPedido.Include(x => x.Pedido)
                                                 .Include(x => x.Servico)
                                                 .Select(x => new ObterItemPedidoComIdDTO(x))
                                                 .ToList();
           return itensPedido;
        }

        public ItemPedido ObterPorId(int id)
        {
            var itemPedido = _context.ItensPedido.Find(id);
            return itemPedido;
        }

        public void Atualizar(ItemPedido itemPedido)
        {
            _context.ItensPedido.Update(itemPedido);
            _context.SaveChanges();
        }

        public void Deletar(ItemPedido itemPedido)
        {
            _context.ItensPedido.Remove(itemPedido);
            _context.SaveChanges();
        }
    }
}