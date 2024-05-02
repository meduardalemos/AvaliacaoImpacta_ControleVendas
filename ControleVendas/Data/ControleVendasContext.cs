using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ControleVendas.Models;

namespace ControleVendas.Data
{
    public class ControleVendasContext : DbContext
    {
        public ControleVendasContext (DbContextOptions<ControleVendasContext> options)
            : base(options)
        {
        }

        public DbSet<ControleVendas.Models.Produto> Produto { get; set; } = default!;
        public DbSet<ControleVendas.Models.Funcionario> Funcionario { get; set; } = default!;
        public DbSet<ControleVendas.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<ControleVendas.Models.Acesso> Acesso { get; set; } = default!;
        public DbSet<ControleVendas.Models.Pedido> Pedido { get; set; } = default!;
    }
}
