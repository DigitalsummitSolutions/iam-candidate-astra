using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IAMCandidateTest.Migrations
{
    public partial class AddSeveralLookupTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EdiblePartId",
                table: "Vegetable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsBotanicalFruit",
                table: "Vegetable",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "Mineral",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DiaphaneityId",
                table: "Mineral",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Hardness",
                table: "Mineral",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "LusterId",
                table: "Mineral",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "SpecificGravity",
                table: "Mineral",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "StreakId",
                table: "Mineral",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Diaphaneity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Streak", x => x.Id);
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
                    { 2, "Psittaciformes" },
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
                name: "IX_Vegetable_EdiblePartId",
                table: "Vegetable",
                column: "EdiblePartId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Mineral_Diaphaneity_DiaphaneityId",
                table: "Mineral",
                column: "DiaphaneityId",
                principalTable: "Diaphaneity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mineral_Luster_LusterId",
                table: "Mineral",
                column: "LusterId",
                principalTable: "Luster",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mineral_MineralColor_ColorId",
                table: "Mineral",
                column: "ColorId",
                principalTable: "MineralColor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mineral_Streak_StreakId",
                table: "Mineral",
                column: "StreakId",
                principalTable: "Streak",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vegetable_EdibleParts_EdiblePartId",
                table: "Vegetable",
                column: "EdiblePartId",
                principalTable: "EdibleParts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mineral_Diaphaneity_DiaphaneityId",
                table: "Mineral");

            migrationBuilder.DropForeignKey(
                name: "FK_Mineral_Luster_LusterId",
                table: "Mineral");

            migrationBuilder.DropForeignKey(
                name: "FK_Mineral_MineralColor_ColorId",
                table: "Mineral");

            migrationBuilder.DropForeignKey(
                name: "FK_Mineral_Streak_StreakId",
                table: "Mineral");

            migrationBuilder.DropForeignKey(
                name: "FK_Vegetable_EdibleParts_EdiblePartId",
                table: "Vegetable");

            migrationBuilder.DropTable(
                name: "Diaphaneity");

            migrationBuilder.DropTable(
                name: "EdibleParts");

            migrationBuilder.DropTable(
                name: "Luster");

            migrationBuilder.DropTable(
                name: "MineralColor");

            migrationBuilder.DropTable(
                name: "Streak");

            migrationBuilder.DropIndex(
                name: "IX_Vegetable_EdiblePartId",
                table: "Vegetable");

            migrationBuilder.DropIndex(
                name: "IX_Mineral_ColorId",
                table: "Mineral");

            migrationBuilder.DropIndex(
                name: "IX_Mineral_DiaphaneityId",
                table: "Mineral");

            migrationBuilder.DropIndex(
                name: "IX_Mineral_LusterId",
                table: "Mineral");

            migrationBuilder.DropIndex(
                name: "IX_Mineral_StreakId",
                table: "Mineral");

            migrationBuilder.DeleteData(
                table: "TaxClass",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TaxClass",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TaxClass",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TaxClass",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TaxFamily",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TaxFamily",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TaxFamily",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TaxFamily",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TaxFamily",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TaxFamily",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TaxGenus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TaxGenus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TaxGenus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TaxGenus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TaxGenus",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TaxGenus",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TaxOrder",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TaxOrder",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TaxOrder",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TaxOrder",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TaxOrder",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TaxPhylum",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TaxPhylum",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TaxSpecies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TaxSpecies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TaxSpecies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TaxSpecies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TaxSpecies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TaxSpecies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "EdiblePartId",
                table: "Vegetable");

            migrationBuilder.DropColumn(
                name: "IsBotanicalFruit",
                table: "Vegetable");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "Mineral");

            migrationBuilder.DropColumn(
                name: "DiaphaneityId",
                table: "Mineral");

            migrationBuilder.DropColumn(
                name: "Hardness",
                table: "Mineral");

            migrationBuilder.DropColumn(
                name: "LusterId",
                table: "Mineral");

            migrationBuilder.DropColumn(
                name: "SpecificGravity",
                table: "Mineral");

            migrationBuilder.DropColumn(
                name: "StreakId",
                table: "Mineral");
        }
    }
}
