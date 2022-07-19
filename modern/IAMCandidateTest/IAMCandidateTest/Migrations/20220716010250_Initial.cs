using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IAMCandidateTest.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diaphaneity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diaphaneity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EdibleParts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EdibleParts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Luster",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Luster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MineralColor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MineralColor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Streak",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Streak", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EdiblePartId = table.Column<int>(type: "int", nullable: false),
                    IsBotanicalFruit = table.Column<bool>(type: "bit", nullable: true),
                    CategoryTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vegetable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vegetable_CategoryType_CategoryTypeId",
                        column: x => x.CategoryTypeId,
                        principalTable: "CategoryType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vegetable_EdibleParts_EdiblePartId",
                        column: x => x.EdiblePartId,
                        principalTable: "EdibleParts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mineral",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Hardness = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    CategoryTypeId = table.Column<int>(type: "int", nullable: false),
                    LusterId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    StreakId = table.Column<int>(type: "int", nullable: false),
                    SpecificGravity = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    DiaphaneityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mineral", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mineral_CategoryType_CategoryTypeId",
                        column: x => x.CategoryTypeId,
                        principalTable: "CategoryType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mineral_Diaphaneity_DiaphaneityId",
                        column: x => x.DiaphaneityId,
                        principalTable: "Diaphaneity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mineral_Luster_LusterId",
                        column: x => x.LusterId,
                        principalTable: "Luster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mineral_MineralColor_ColorId",
                        column: x => x.ColorId,
                        principalTable: "MineralColor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mineral_Streak_StreakId",
                        column: x => x.StreakId,
                        principalTable: "Streak",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Animal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LegCount = table.Column<int>(type: "int", nullable: false),
                    WingCount = table.Column<int>(type: "int", nullable: false),
                    CanFly = table.Column<bool>(type: "bit", nullable: true),
                    CategoryTypeId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_Animal_CategoryType_CategoryTypeId",
                        column: x => x.CategoryTypeId,
                        principalTable: "CategoryType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.InsertData(
                table: "CategoryType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Animal" },
                    { 2, "Mineral" },
                    { 3, "Vegetable" }
                });

            migrationBuilder.InsertData(
                table: "Diaphaneity",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Opaque" },
                    { 2, "Transparent" }
                });

            migrationBuilder.InsertData(
                table: "EdibleParts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Root" },
                    { 2, "Fruit" },
                    { 3, "Leaf" },
                    { 4, "Seed" },
                    { 5, "Tuber" }
                });

            migrationBuilder.InsertData(
                table: "Luster",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Metallic" },
                    { 2, "Adamantine" },
                    { 3, "Dull" },
                    { 4, "Vitreous" }
                });

            migrationBuilder.InsertData(
                table: "MineralColor",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Dull Brown" },
                    { 2, "Varied" },
                    { 3, "Golden, yellow" },
                    { 4, "Reddish Brown" },
                    { 5, "Clear" }
                });

            migrationBuilder.InsertData(
                table: "Streak",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Metallic copper red" },
                    { 2, "None" },
                    { 3, "Golden, yellow" },
                    { 4, "Red" },
                    { 5, "Colorless" }
                });

            migrationBuilder.InsertData(
                table: "TaxClass",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mammalia" },
                    { 2, "Aves" },
                    { 3, "Insecta" },
                    { 4, "Reptilia" }
                });

            migrationBuilder.InsertData(
                table: "TaxFamily",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Felidae" },
                    { 2, "Cacatuidae" },
                    { 3, "Struthionidae" },
                    { 4, "Caniformia" },
                    { 5, "Nymphalidae" },
                    { 6, "Colubridae" }
                });

            migrationBuilder.InsertData(
                table: "TaxGenus",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Felis" },
                    { 2, "Nymphicus" },
                    { 3, "Struthio" },
                    { 4, "Canis" },
                    { 5, "Danaus" },
                    { 6, "Thamnophis" }
                });

            migrationBuilder.InsertData(
                table: "TaxOrder",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Carnivora" },
                    { 2, "Psittaciformes" }
                });

            migrationBuilder.InsertData(
                table: "TaxOrder",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "Struthioniformes" },
                    { 4, "Lepidoptera" },
                    { 5, "Squamata" }
                });

            migrationBuilder.InsertData(
                table: "TaxPhylum",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Chordata" },
                    { 2, "Arthropoda" }
                });

            migrationBuilder.InsertData(
                table: "TaxSpecies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Catus" },
                    { 2, "Hollandicus" },
                    { 3, "Camelus" },
                    { 4, "Familiaris" },
                    { 5, "Plexippus" },
                    { 6, "Brachystoma" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animal_CategoryTypeId",
                table: "Animal",
                column: "CategoryTypeId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Mineral_CategoryTypeId",
                table: "Mineral",
                column: "CategoryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Mineral_ColorId",
                table: "Mineral",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Mineral_DiaphaneityId",
                table: "Mineral",
                column: "DiaphaneityId");

            migrationBuilder.CreateIndex(
                name: "IX_Mineral_LusterId",
                table: "Mineral",
                column: "LusterId");

            migrationBuilder.CreateIndex(
                name: "IX_Mineral_StreakId",
                table: "Mineral",
                column: "StreakId");

            migrationBuilder.CreateIndex(
                name: "IX_Vegetable_CategoryTypeId",
                table: "Vegetable",
                column: "CategoryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vegetable_EdiblePartId",
                table: "Vegetable",
                column: "EdiblePartId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animal");

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

            migrationBuilder.DropTable(
                name: "Diaphaneity");

            migrationBuilder.DropTable(
                name: "Luster");

            migrationBuilder.DropTable(
                name: "MineralColor");

            migrationBuilder.DropTable(
                name: "Streak");

            migrationBuilder.DropTable(
                name: "CategoryType");

            migrationBuilder.DropTable(
                name: "EdibleParts");
        }
    }
}
