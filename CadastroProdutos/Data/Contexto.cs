using CadastroProdutos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroProdutos.Data
{
    public class Contexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("Host=projetoscti.com.br;" +
                                     "Database=cti_db;" +
                                     "Username=ra2557038;"+
                                     "Password=O0AGe1PuZJx1vZE;" +
                                     "Port=54432");
        }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
