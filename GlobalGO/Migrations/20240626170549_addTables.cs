using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GlobalGO.Migrations
{
    /// <inheritdoc />
    public partial class addTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Distribuidores",
                columns: table => new
                {
                    idDistribuidor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    distribuidor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    longitud = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    latitud = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distribuidores", x => x.idDistribuidor);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    idMarca = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    marca = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    logo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    rgb = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.idMarca);
                });

            migrationBuilder.CreateTable(
                name: "Modelos",
                columns: table => new
                {
                    idModelo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idMarca = table.Column<int>(type: "int", nullable: false),
                    modelo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    slogan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    texto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    video = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    logo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    rgb = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelos", x => x.idModelo);
                    table.ForeignKey(
                        name: "FK_Modelos_Marcas_idMarca",
                        column: x => x.idMarca,
                        principalTable: "Marcas",
                        principalColumn: "idMarca",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carruseles",
                columns: table => new
                {
                    idCarrusel = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idModelo = table.Column<int>(type: "int", nullable: false),
                    modeloidModelo = table.Column<int>(type: "int", nullable: false),
                    imagen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    titulo = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    texto1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    texto2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carruseles", x => x.idCarrusel);
                    table.ForeignKey(
                        name: "FK_Carruseles_Modelos_modeloidModelo",
                        column: x => x.modeloidModelo,
                        principalTable: "Modelos",
                        principalColumn: "idModelo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    idCategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idModelo = table.Column<int>(type: "int", nullable: false),
                    modeloidModelo = table.Column<int>(type: "int", nullable: false),
                    categoria = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    icono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.idCategoria);
                    table.ForeignKey(
                        name: "FK_Categorias_Modelos_modeloidModelo",
                        column: x => x.modeloidModelo,
                        principalTable: "Modelos",
                        principalColumn: "idModelo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Colores",
                columns: table => new
                {
                    idColor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idModelo = table.Column<int>(type: "int", nullable: false),
                    color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    icono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colores", x => x.idColor);
                    table.ForeignKey(
                        name: "FK_Colores_Modelos_idModelo",
                        column: x => x.idModelo,
                        principalTable: "Modelos",
                        principalColumn: "idModelo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DistribuidorMotos",
                columns: table => new
                {
                    idDealerMoto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idDistribuidor = table.Column<int>(type: "int", nullable: false),
                    distribuidoridDistribuidor = table.Column<int>(type: "int", nullable: false),
                    idModelo = table.Column<int>(type: "int", nullable: false),
                    modeloidModelo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistribuidorMotos", x => x.idDealerMoto);
                    table.ForeignKey(
                        name: "FK_DistribuidorMotos_Distribuidores_distribuidoridDistribuidor",
                        column: x => x.distribuidoridDistribuidor,
                        principalTable: "Distribuidores",
                        principalColumn: "idDistribuidor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DistribuidorMotos_Modelos_modeloidModelo",
                        column: x => x.modeloidModelo,
                        principalTable: "Modelos",
                        principalColumn: "idModelo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Especificaciones",
                columns: table => new
                {
                    idEspecificacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idModelo = table.Column<int>(type: "int", nullable: false),
                    modeloidModelo = table.Column<int>(type: "int", nullable: false),
                    imagen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    anio = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    cilindrada = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    potencia = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    torque = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    combustible = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    tanque = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    rendimiento = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    autonomia = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    transmision = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    velocidad = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    freno_delantero = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    freno_posterior = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    suspension_delantero = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    suspension_posterior = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    peso = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    carga = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    largo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ancho = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    alto = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especificaciones", x => x.idEspecificacion);
                    table.ForeignKey(
                        name: "FK_Especificaciones_Modelos_modeloidModelo",
                        column: x => x.modeloidModelo,
                        principalTable: "Modelos",
                        principalColumn: "idModelo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Galerias",
                columns: table => new
                {
                    idGaleria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idModelo = table.Column<int>(type: "int", nullable: false),
                    modeloidModelo = table.Column<int>(type: "int", nullable: false),
                    imagen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galerias", x => x.idGaleria);
                    table.ForeignKey(
                        name: "FK_Galerias_Modelos_modeloidModelo",
                        column: x => x.modeloidModelo,
                        principalTable: "Modelos",
                        principalColumn: "idModelo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Precios",
                columns: table => new
                {
                    idPrecio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idModelo = table.Column<int>(type: "int", nullable: false),
                    modeloidModelo = table.Column<int>(type: "int", nullable: false),
                    precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Precios", x => x.idPrecio);
                    table.ForeignKey(
                        name: "FK_Precios_Modelos_modeloidModelo",
                        column: x => x.modeloidModelo,
                        principalTable: "Modelos",
                        principalColumn: "idModelo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carruseles_modeloidModelo",
                table: "Carruseles",
                column: "modeloidModelo");

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_modeloidModelo",
                table: "Categorias",
                column: "modeloidModelo");

            migrationBuilder.CreateIndex(
                name: "IX_Colores_idModelo",
                table: "Colores",
                column: "idModelo");

            migrationBuilder.CreateIndex(
                name: "IX_DistribuidorMotos_distribuidoridDistribuidor",
                table: "DistribuidorMotos",
                column: "distribuidoridDistribuidor");

            migrationBuilder.CreateIndex(
                name: "IX_DistribuidorMotos_modeloidModelo",
                table: "DistribuidorMotos",
                column: "modeloidModelo");

            migrationBuilder.CreateIndex(
                name: "IX_Especificaciones_modeloidModelo",
                table: "Especificaciones",
                column: "modeloidModelo");

            migrationBuilder.CreateIndex(
                name: "IX_Galerias_modeloidModelo",
                table: "Galerias",
                column: "modeloidModelo");

            migrationBuilder.CreateIndex(
                name: "IX_Modelos_idMarca",
                table: "Modelos",
                column: "idMarca");

            migrationBuilder.CreateIndex(
                name: "IX_Precios_modeloidModelo",
                table: "Precios",
                column: "modeloidModelo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carruseles");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Colores");

            migrationBuilder.DropTable(
                name: "DistribuidorMotos");

            migrationBuilder.DropTable(
                name: "Especificaciones");

            migrationBuilder.DropTable(
                name: "Galerias");

            migrationBuilder.DropTable(
                name: "Precios");

            migrationBuilder.DropTable(
                name: "Distribuidores");

            migrationBuilder.DropTable(
                name: "Modelos");

            migrationBuilder.DropTable(
                name: "Marcas");
        }
    }
}
