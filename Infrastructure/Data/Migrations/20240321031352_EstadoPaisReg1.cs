using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class EstadoPaisReg1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estado_Pais_codEstado",
                table: "Estado");

            migrationBuilder.AlterColumn<string>(
                name: "codPais",
                table: "Estado",
                type: "varchar(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Estado_codPais",
                table: "Estado",
                column: "codPais");

            migrationBuilder.AddForeignKey(
                name: "FK_Estado_Pais_codPais",
                table: "Estado",
                column: "codPais",
                principalTable: "Pais",
                principalColumn: "codPais");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estado_Pais_codPais",
                table: "Estado");

            migrationBuilder.DropIndex(
                name: "IX_Estado_codPais",
                table: "Estado");

            migrationBuilder.AlterColumn<string>(
                name: "codPais",
                table: "Estado",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(3)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_Estado_Pais_codEstado",
                table: "Estado",
                column: "codEstado",
                principalTable: "Pais",
                principalColumn: "codPais",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
