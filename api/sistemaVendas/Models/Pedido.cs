using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistemaVendas.Dto;

namespace sistemaVendas.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int VendedorId { get; set; }
        public Vendedor Vendedor { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public decimal ValorTotal { get; set; }
        public Pedido()
        {

        }
        public Pedido(CadastrarPedidoDTO dto)
        {
            Data = dto.Data;
            VendedorId = dto.VendedorId;
            ClienteId = dto.ClienteId;
        }

        public void MapearAtualizarPedidoDTO(AtualizarPedidoDTO dto)
        {
            Data = dto.Data;
            VendedorId = dto.VendedorId;
            ClienteId = dto.ClienteId; 
        }
    }

    
}