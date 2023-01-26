using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoVendaAPI.Models;

namespace ProjetoVendaAPI.Context
{
    public class GerenciadorDeVendasContext : DbContext 
    {
       public GerenciadorDeVendasContext(DbContextOptions<GerenciadorDeVendasContext> options) : base(options)
       {
           
       }
       public DbSet<Venda> Vendas{get; set;}
    }
}