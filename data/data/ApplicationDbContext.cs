using GlobalGO.models;
using Microsoft.EntityFrameworkCore;


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
            public DbSet<DistribuidorMotos> DistribuidoresMotos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for Marcas
            modelBuilder.Entity<Marcas>().HasData(
                new Marcas { idMarca = 1, marca = "Yamaha", logo = "yamaha-logo.png", rgb = "#FF5733" }
                //new Marcas { idMarca = 2, marca = "Honda", logo = "honda-logo.png", rgb = "#92E7AB" }
            );

            // Seed data for Modelos
            modelBuilder.Entity<Modelos>().HasData(
                new Modelos { idModelo = 1, idMarca = 1, modelo = "YZF-R1", slogan = "Super Sport", texto = "Lorem ipsum...", video = "r1-video.mp4", logo = "r1-logo.png", rgb = "#0000FF" }
                //new Modelos { idModelo = 2, idMarca = 2, modelo = "CBR1000RR", slogan = "The Fireblade", texto = "Lorem ipsum...", video = "cbr-video.mp4", logo = "cbr-logo.png", rgb = "#FF0000" }
            );

            // Seed data for Colores
            modelBuilder.Entity<Colores>().HasData(
                new Colores { idColor = 1, idModelo = 1, color = "Blue", icono = "blue-icon.png" }
                //new Colores { idColor = 2, idModelo = 2, color = "Red", icono = "red-icon.png" }
            );

            // Seed data for Categorias
            //modelBuilder.Entity<Categorias>().HasData(
            //    new Categorias { idCategoria = 1, idModelo = 1, categoria = "Sport", icono = "sport-icon.png" },
            //    new Categorias { idCategoria = 2, idModelo = 2, categoria = "Touring", icono = "touring-icon.png" }
            //);

            // Seed data for Especificaciones
            //modelBuilder.Entity<Especificaciones>().HasData(
            //    new Especificaciones { idEspecificacion = 1, idModelo = 1, imagen = "r1-image.png", anio = "2023", cilindrada = "998cc", potencia = "200hp", torque = "112Nm", combustible = "Gasoline", tanque = "17L", rendimiento = "15km/L", autonomia = "255km", transmision = "6-speed", velocidad = "299km/h", freno_delantero = "Dual Disc", freno_posterior = "Disc", suspension_delantero = "Telescopic Fork", suspension_posterior = "Swingarm", peso = "200kg", carga = "150kg", largo = "2050mm", ancho = "690mm", alto = "1150mm" },
            //    new Especificaciones { idEspecificacion = 2, idModelo = 2, imagen = "r1-image.png", anio = "2023", cilindrada = "999cc", potencia = "200hp", torque = "112Nm", combustible = "Gasoline", tanque = "17L", rendimiento = "16km/L", autonomia = "256km", transmision = "6-speed", velocidad = "299km/h", freno_delantero = "Dual Disc", freno_posterior = "Disc", suspension_delantero = "Telescopic Fork", suspension_posterior = "Swingarm", peso = "200kg", carga = "150kg", largo = "2050mm", ancho = "690mm", alto = "1150mm" }
            //);

            // Seed data for Galerias
            //modelBuilder.Entity<Galerias>().HasData(
            //    new Galerias { idGaleria = 1, idModelo = 1, imagen = "r1-gallery1.png" },
            //    new Galerias { idGaleria = 2, idModelo = 2, imagen = "cbr-gallery1.png" }
            //);

            // Seed data for Precios
            //modelBuilder.Entity<Precios>().HasData(
            //    new Precios { idPrecio = 1, idModelo = 1, precio = 20000m, fecha = DateTime.Now },
            //    new Precios { idPrecio = 2, idModelo = 2, precio = 18000m, fecha = DateTime.Now }
            //);

            // Seed data for Distribuidores
            //modelBuilder.Entity<Distribuidores>().HasData(
            //    new Distribuidores { idDistribuidor = 1, distribuidor = "MotoDistribuidor", direccion = "123 Calle Principal, Ciudad", longitud = "40.712776", latitud = "-74.005974" },
            //    new Distribuidores { idDistribuidor = 2, distribuidor = "MotoCentro", direccion = "456 Avenida Secundaria, Ciudad", longitud = "34.052235", latitud = "-118.243683" }
            //);

            // Seed data for DistribuidorMotos
            //modelBuilder.Entity<DistribuidorMotos>().HasData(
            //    new DistribuidorMotos { idDealerMoto = 1, idDistribuidor = 1, idModelo = 1 },
            //    new DistribuidorMotos { idDealerMoto = 2, idDistribuidor = 2, idModelo = 2 }
            //);

            // Seed data for Carruseles
            //modelBuilder.Entity<Carruseles>().HasData(
            //    new Carruseles { idCarrusel = 1, idModelo = 1, imagen = "r1-carousel1.png", titulo = "Speed", texto1 = "Feel the rush", texto2 = "Like never before" },
            //    new Carruseles { idCarrusel = 2, idModelo = 2, imagen = "cbr-carousel1.png", titulo = "Performance", texto1 = "Unleash the beast", texto2 = "With Fireblade" }
            //);
        }
    }
}
