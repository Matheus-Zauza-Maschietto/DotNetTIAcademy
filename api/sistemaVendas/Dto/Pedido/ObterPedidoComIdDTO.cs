using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistemaVendas.Models;

namespace sistemaVendas.Dto
{
    public class ObterPedidoComIdDTO
    {

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public ObterVendedorComIdDTO Vendedor { get; set; }
        public ObterClienteComIdDTO Cliente { get; set; }

        public ObterPedidoComIdDTO(Pedido pedido)
        {
            Id = pedido.Id;
            Data = pedido.Data;
            Vendedor = new ObterVendedorComIdDTO(pedido.Vendedor);
            Cliente = new ObterClienteComIdDTO(pedido.Cliente);
        }
    }
}