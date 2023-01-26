using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoVendaAPI.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string CPF { get; set; }
        public string NomeDoVendedor { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}