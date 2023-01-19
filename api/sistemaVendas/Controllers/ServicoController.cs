using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sistemaVendas.Repository;
using sistemaVendas.Dto;
using sistemaVendas.Models;

namespace sistemaVendas.Controllers
{   
    [ApiController]
    [Route("[controller]")]
    public class ServicoController: ControllerBase
    {
        private readonly ServicoRepository _repository;
        public ServicoController(ServicoRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Cadastrar(CadastrarServicoDTO dto)
        {
            var servico = new Servico(dto);
            _repository.Cadastrar(servico);
            return Ok(servico);
        }

        public IActionResult ObterPorId(int id)
        {
            var servico = _repository.ObterPorId(id);
            if(servico is not null)
            {   
                var servicoDTO = new ObterServicoDTO(servico);
                return Ok(servicoDTO);
            }
            return NotFound(new {mensagem = $"Não foi encontrada um serviço com id {id}"}); 
        }

    }
}