using GlobalGO.models;
using Microsoft.EntityFrameworkCore;
using System;

namespace GlobalGO.data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Carruseles> Carruseles { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Colores> Colores { get; set; }
        public DbSet<Distribuidores> Distribuidores { get; set; }
        public DbSet<DistribuidorMotos> DistribuidorMotos { get; set; }
        public DbSet<Especificaciones> Especificaciones { get; set; }
        public DbSet<Galerias> Galerias { get; set; }
        public DbSet<Marcas> Marcas { get; set; }
        public DbSet<Modelos> Modelos { get; set; }
        public DbSet<Precios> Precios { get; set; }
    }
}
