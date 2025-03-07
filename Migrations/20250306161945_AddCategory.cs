using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExemploEF.Migrations
{
    /// <inheritdoc />
    public partial class AddCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "TbClientes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TbClientes",
                table: "TbClientes",
                column: "ClienteId");

            migrationBuilder.CreateTable(
                name: "TbCategorias",
                columns: table => new
                {
                    CategoriaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbCategorias", x => x.CategoriaId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbCategorias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TbClientes",
                table: "TbClientes");

            migrationBuilder.RenameTable(
                name: "TbClientes",
                newName: "Clientes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "ClienteId");
        }
    }
}
