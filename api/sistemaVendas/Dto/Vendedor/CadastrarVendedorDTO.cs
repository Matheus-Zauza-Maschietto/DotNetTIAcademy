namespace sistemaVendas.Dto
{
    // Data Transfer Object (Objeto para transferencia de dados)
    public class CadastrarVendedorDTO
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}