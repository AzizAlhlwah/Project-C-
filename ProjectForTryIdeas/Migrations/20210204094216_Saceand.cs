using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectForTryIdeas.Migrations
{
    public partial class Saceand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Person_personId",
                table: "Car");

            migrationBuilder.AlterColumn<int>(
                name: "personId",
                table: "Car",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Person_personId",
                table: "Car",
                column: "personId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Person_personId",
                table: "Car");

            migrationBuilder.AlterColumn<int>(
                name: "personId",
                table: "Car",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Person_personId",
                table: "Car",
                column: "personId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
