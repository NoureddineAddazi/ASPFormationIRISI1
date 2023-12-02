using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionStagaires.Data.Migrations
{
    /// <inheritdoc />
    public partial class ModelsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stagiaires",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prénom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Téléphone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Entreprise = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sujet = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stagiaires", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stagiaires");
        }
    }
}
