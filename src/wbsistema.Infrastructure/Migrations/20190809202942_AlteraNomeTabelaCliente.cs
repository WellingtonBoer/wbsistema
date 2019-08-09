using Microsoft.EntityFrameworkCore.Migrations;

namespace wbsistema.Infrastructure.Migrations
{
    public partial class AlteraNomeTabelaCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_cliente",
                table: "tb_cliente");

            migrationBuilder.RenameTable(
                name: "tb_cliente",
                newName: "Cliente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "ClienteID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "tb_cliente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_cliente",
                table: "tb_cliente",
                column: "ClienteID");
        }
    }
}
