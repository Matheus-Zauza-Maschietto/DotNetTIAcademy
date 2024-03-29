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
    public class ServicoRepository
    {
        private readonly VendasContext _context;
        public ServicoRepository(VendasContext context)
        {
            _context = context;
        }

        public void Cadastrar(Servico servico)
        {
            _context.Servicos.Add(servico);
            _context.SaveChanges();
        }

        public Servico ObterPorId(int id)
        {
            var servico = _context.Servicos.Find(id);
            return servico;
        }

        public List<ObterServicoComIdDTO> ObterTodos()
        {
            var servicos = _context.Servicos.Select(x => new ObterServicoComIdDTO(x)).ToList();
            return servicos;
        }
        public void AtualizarServico(Servico servico)
        {
            _context.Servicos.Update(servico);
            _context.SaveChanges();
        }

        public void DeletarServico(Servico servico)
        {
            _context.Servicos.Remove(servico);
            _context.SaveChanges();
        }
    }
}