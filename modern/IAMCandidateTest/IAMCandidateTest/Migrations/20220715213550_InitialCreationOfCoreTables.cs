using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IAMCandidateTest.Migrations
{
    public partial class InitialCreationOfCoreTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mineral",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mineral", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxClass", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxFamily",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxFamily", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxGenus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxGenus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxOrder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxOrder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxPhylum",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxPhylum", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxSpecies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxSpecies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vegetable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vegetable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Animal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LegCount = table.Column<int>(type: "int", nullable: false),
                    WingCount = table.Column<int>(type: "int", nullable: false),
                    CanFly = table.Column<bool>(type: "bit", nullable: false),
                    TaxPhylumId = table.Column<int>(type: "int", nullable: false),
                    TaxClassId = table.Column<int>(type: "int", nullable: false),
                    TaxOrderId = table.Column<int>(type: "int", nullable: false),
                    TaxFamilyId = table.Column<int>(type: "int", nullable: false),
                    TaxGenusId = table.Column<int>(type: "int", nullable: false),
                    TaxSpeciesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animal_TaxClass_TaxClassId",
                        column: x => x.TaxClassId,
                        principalTable: "TaxClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Animal_TaxFamily_TaxFamilyId",
                        column: x => x.TaxFamilyId,
                        principalTable: "TaxFamily",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Animal_TaxGenus_TaxGenusId",
                        column: x => x.TaxGenusId,
                        principalTable: "TaxGenus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Animal_TaxOrder_TaxOrderId",
                        column: x => x.TaxOrderId,
                        principalTable: "TaxOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Animal_TaxPhylum_TaxPhylumId",
                        column: x => x.TaxPhylumId,
                        principalTable: "TaxPhylum",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Animal_TaxSpecies_TaxSpeciesId",
                        column: x => x.TaxSpeciesId,
                        principalTable: "TaxSpecies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animal_TaxClassId",
                table: "Animal",
                column: "TaxClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Animal_TaxFamilyId",
                table: "Animal",
                column: "TaxFamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_Animal_TaxGenusId",
                table: "Animal",
                column: "TaxGenusId");

            migrationBuilder.CreateIndex(
                name: "IX_Animal_TaxOrderId",
                table: "Animal",
                column: "TaxOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Animal_TaxPhylumId",
                table: "Animal",
                column: "TaxPhylumId");

            migrationBuilder.CreateIndex(
                name: "IX_Animal_TaxSpeciesId",
                table: "Animal",
                column: "TaxSpeciesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animal");

            migrationBuilder.DropTable(
                name: "CategoryType");

            migrationBuilder.DropTable(
                name: "Mineral");

            migrationBuilder.DropTable(
                name: "Vegetable");

            migrationBuilder.DropTable(
                name: "TaxClass");

            migrationBuilder.DropTable(
                name: "TaxFamily");

            migrationBuilder.DropTable(
                name: "TaxGenus");

            migrationBuilder.DropTable(
                name: "TaxOrder");

            migrationBuilder.DropTable(
                name: "TaxPhylum");

            migrationBuilder.DropTable(
                name: "TaxSpecies");
        }
    }
}
