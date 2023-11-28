using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Req231123_V1.Migrations
{
    public partial class Popular_Produtos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Produtos (Nome) VALUES ('Caneta')");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome) VALUES ('Lápis')");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome) VALUES ('Borracha')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DEKETE FROM Produtos");

        }
    }
}
