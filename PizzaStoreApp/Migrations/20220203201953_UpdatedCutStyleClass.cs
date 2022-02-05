using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaStoreApp.Migrations
{
    public partial class UpdatedCutStyleClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_CrustStyles_CrustStyleId",
                table: "Pizzas");

            migrationBuilder.DropTable(
                name: "CrustStyles");

            migrationBuilder.RenameColumn(
                name: "CrustStyleId",
                table: "Pizzas",
                newName: "CutStyleId");

            migrationBuilder.RenameIndex(
                name: "IX_Pizzas_CrustStyleId",
                table: "Pizzas",
                newName: "IX_Pizzas_CutStyleId");

            migrationBuilder.CreateTable(
                name: "CutStyles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CutStyles", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_CutStyles_CutStyleId",
                table: "Pizzas",
                column: "CutStyleId",
                principalTable: "CutStyles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_CutStyles_CutStyleId",
                table: "Pizzas");

            migrationBuilder.DropTable(
                name: "CutStyles");

            migrationBuilder.RenameColumn(
                name: "CutStyleId",
                table: "Pizzas",
                newName: "CrustStyleId");

            migrationBuilder.RenameIndex(
                name: "IX_Pizzas_CutStyleId",
                table: "Pizzas",
                newName: "IX_Pizzas_CrustStyleId");

            migrationBuilder.CreateTable(
                name: "CrustStyles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrustStyles", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_CrustStyles_CrustStyleId",
                table: "Pizzas",
                column: "CrustStyleId",
                principalTable: "CrustStyles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
