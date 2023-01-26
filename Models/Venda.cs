

using Microsoft.EntityFrameworkCore;

namespace ProjetoVendaAPI.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public string NomeDoProduto { get; set; }
        public DateTime Data { get; set; }
        public EnumVendaStatus Status { get; set; }
        public Vendedor vendedor { get; set; }
        
    }
}