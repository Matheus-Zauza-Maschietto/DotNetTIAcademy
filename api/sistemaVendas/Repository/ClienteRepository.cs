using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistemaVendas.Context;
using sistemaVendas.Models;
using sistemaVendas.Dto;



namespace sistemaVendas.Repository
{
    public class ClienteRepository
    {
        private readonly VendasContext _context;
        public ClienteRepository(VendasContext context)
        {
            _context = context;
        }

        public void Cadastrar(Cliente cliente)
        {
            _context.Cliente.Add(cliente);
            _context.SaveChanges();
        }
    }
}