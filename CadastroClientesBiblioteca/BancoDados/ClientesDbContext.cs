using CadastroClientesBiblioteca.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroClientesBiblioteca.BancoDados
{
    public class ClientesDbContext : DbContext
    {
        public ClientesDbContext() { }

        public ClientesDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conn = "Server=localhost,1433;Database=CadastroClienteDB;User ID=sa;Password=example_123;TrustServerCertificate=True";

            if (!optionsBuilder.IsConfigured)
            {
                 optionsBuilder.UseSqlServer(conn);
            }
        }
    }
}
