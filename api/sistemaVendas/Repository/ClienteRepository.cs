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

        public Cliente ObterPorId(int id)
        {
            var cliente = _context.Cliente.Find(id);
            return cliente;
        }

        public List<ObterClienteComIdDTO> ObterTodos()
        {
            var clientes = _context.Cliente.Select((x) => new ObterClienteComIdDTO(x)).ToList();
            return clientes;
        }

        public void AtualizarCliente(Cliente cliente)
        {
            _context.Cliente.Update(cliente);
            _context.SaveChanges();
        }

        public void DeletarCliente(Cliente cliente)
        {
            _context.Cliente.Remove(cliente);
            _context.SaveChanges();

        }
    }
}