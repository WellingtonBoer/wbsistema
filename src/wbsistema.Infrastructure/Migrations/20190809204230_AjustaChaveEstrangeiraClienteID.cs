using Microsoft.EntityFrameworkCore.Migrations;

namespace wbsistema.Infrastructure.Migrations
{
    public partial class AjustaChaveEstrangeiraClienteID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contato_Cliente_ClienteId",
                table: "Contato");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Contato",
                newName: "ClienteID");

            migrationBuilder.RenameIndex(
                name: "IX_Contato_ClienteId",
                table: "Contato",
                newName: "IX_Contato_ClienteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contato_Cliente_ClienteID",
                table: "Contato",
                column: "ClienteID",
                principalTable: "Cliente",
                principalColumn: "ClienteID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contato_Cliente_ClienteID",
                table: "Contato");

            migrationBuilder.RenameColumn(
                name: "ClienteID",
                table: "Contato",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Contato_ClienteID",
                table: "Contato",
                newName: "IX_Contato_ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contato_Cliente_ClienteId",
                table: "Contato",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "ClienteID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
