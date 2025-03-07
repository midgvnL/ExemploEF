﻿using ExemploEF.Models;
using Microsoft.EntityFrameworkCore;

namespace ExemploEF.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("TbClientes");
            modelBuilder.Entity<Categoria>().ToTable("TbCategorias");


        }
    }
}
