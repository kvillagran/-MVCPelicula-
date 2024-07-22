using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _MVCPelicula_.Migrations
{
    /// <inheritdoc />
    public partial class Migracion_Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Peliculas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FechaLanzamiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GeneroId = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Director = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peliculas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Peliculas_Generos_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "Generos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Comedia" },
                    { 2, "Romance" },
                    { 3, "Aventura" },
                    { 4, "Acción" },
                    { 5, "Ficción" },
                    { 6, "Drama" }
                });

            migrationBuilder.InsertData(
                table: "Peliculas",
                columns: new[] { "ID", "Director", "FechaLanzamiento", "GeneroId", "Precio", "Titulo" },
                values: new object[,]
                {
                    { 1, "Hermanas Wachowski", new DateTime(2003, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 10.99m, "Matrix recargado" },
                    { 2, "Peter Jackson", new DateTime(2002, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 11.99m, "El señor de los anillos: Las dos torres" },
                    { 3, "Chris Columbus", new DateTime(2002, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 9.99m, "Harry Potter y la cámara secreta" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Peliculas_GeneroId",
                table: "Peliculas",
                column: "GeneroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Peliculas");

            migrationBuilder.DropTable(
                name: "Generos");
        }
    }
}
