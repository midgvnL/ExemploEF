using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExemploEF.Migrations
{
    /// <inheritdoc />
    public partial class AddProdutoEAltereiCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_TbCategorias_CategoriaId",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos");

            migrationBuilder.RenameTable(
                name: "Produtos",
                newName: "TbProdutos");

            migrationBuilder.RenameIndex(
                name: "IX_Produtos_CategoriaId",
                table: "TbProdutos",
                newName: "IX_TbProdutos_CategoriaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TbProdutos",
                table: "TbProdutos",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_TbProdutos_TbCategorias_CategoriaId",
                table: "TbProdutos",
                column: "CategoriaId",
                principalTable: "TbCategorias",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbProdutos_TbCategorias_CategoriaId",
                table: "TbProdutos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TbProdutos",
                table: "TbProdutos");

            migrationBuilder.RenameTable(
                name: "TbProdutos",
                newName: "Produtos");

            migrationBuilder.RenameIndex(
                name: "IX_TbProdutos_CategoriaId",
                table: "Produtos",
                newName: "IX_Produtos_CategoriaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_TbCategorias_CategoriaId",
                table: "Produtos",
                column: "CategoriaId",
                principalTable: "TbCategorias",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
