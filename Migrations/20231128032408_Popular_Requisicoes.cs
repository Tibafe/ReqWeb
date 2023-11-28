using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Req231123_V1.Migrations
{
    public partial class Popular_Requisicoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Requisicoes(Data, ProdutoId) VALUES('27/11/2023',1)");
            migrationBuilder.Sql("INSERT INTO Requisicoes(Data, ProdutoId) VALUES('27/11/2023',2)");
            migrationBuilder.Sql("INSERT INTO Requisicoes(Data, ProdutoId) VALUES('27/11/2023',3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Requisicoes");
        }
    }
}
