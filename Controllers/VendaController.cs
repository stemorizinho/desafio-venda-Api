using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoVendaAPI.Context;
using ProjetoVendaAPI.Models;

namespace ProjetoVendaAPI.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        private readonly GerenciadorDeVendasContext _context;

        public VendaController(GerenciadorDeVendasContext context)
        {
            _context = context;
        }
         
        [HttpPost("Registrar Venda")]
        public IActionResult RegistrarVenda(Venda venda)
        {
            _context.Add(venda);
            _context.SaveChanges();
            return Ok(venda);
        }
        
        [HttpGet("Buscar Venda {id}")]
        public IActionResult BuscarVenda(int id)
        {
            var venda = _context.Vendas.Find(id);
            if (venda == null)
              return NotFound();
            return Ok(venda);
        }
        
        [HttpPatch("Atualizar Status")]
        public IActionResult AtualizarStatus(int id, Venda venda)
        { 
          var vendaBanco = _context.Vendas.Find(id);
          vendaBanco.Status = venda.Status;
          _context.Update(vendaBanco);
          _context.SaveChanges();
          return Ok(vendaBanco);
           
        }



    }
}