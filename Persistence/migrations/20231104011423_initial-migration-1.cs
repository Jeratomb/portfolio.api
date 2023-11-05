using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace portfolio.api.Persistence.migrations
{
    /// <inheritdoc />
    public partial class initialmigration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "portfolio");

            migrationBuilder.CreateTable(
                name: "knowledgecategories",
                schema: "portfolio",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_knowledgecategories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "knowledges",
                schema: "portfolio",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    KnowledgeCategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    scale = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_knowledges", x => x.id);
                    table.ForeignKey(
                        name: "FK_knowledges_knowledgecategories_KnowledgeCategoryId",
                        column: x => x.KnowledgeCategoryId,
                        principalSchema: "portfolio",
                        principalTable: "knowledgecategories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "projects",
                schema: "portfolio",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    KnowledgeId = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projects", x => x.id);
                    table.ForeignKey(
                        name: "FK_projects_knowledges_KnowledgeId",
                        column: x => x.KnowledgeId,
                        principalSchema: "portfolio",
                        principalTable: "knowledges",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "portfolio",
                table: "knowledgecategories",
                columns: new[] { "id", "created", "name" },
                values: new object[,]
                {
                    { new Guid("6e9e16a3-5883-455c-b489-f06e6b20cdf1"), new DateTime(2023, 11, 4, 1, 14, 23, 203, DateTimeKind.Utc).AddTicks(9012), "Languages" },
                    { new Guid("7c723b03-565e-4596-ba65-d67ebada473f"), new DateTime(2023, 11, 4, 1, 14, 23, 203, DateTimeKind.Utc).AddTicks(8723), "DotNetCore" },
                    { new Guid("8580b13d-3013-4ecb-937c-22c218195d9f"), new DateTime(2023, 11, 4, 1, 14, 23, 203, DateTimeKind.Utc).AddTicks(8916), "Frontend" },
                    { new Guid("9674b5b1-bf64-4a7e-b886-97f4f3a882be"), new DateTime(2023, 11, 4, 1, 14, 23, 203, DateTimeKind.Utc).AddTicks(8993), "Backend" },
                    { new Guid("b3f7eb7a-8528-4cc0-9f65-5b8b133d5ca0"), new DateTime(2023, 11, 4, 1, 14, 23, 203, DateTimeKind.Utc).AddTicks(9000), "DevOps" },
                    { new Guid("de40dd39-63b4-45c4-baef-601395f2afa8"), new DateTime(2023, 11, 4, 1, 14, 23, 203, DateTimeKind.Utc).AddTicks(9005), "DataBases" }
                });

            migrationBuilder.InsertData(
                schema: "portfolio",
                table: "knowledges",
                columns: new[] { "id", "created", "KnowledgeCategoryId", "scale" },
                values: new object[,]
                {
                    { new Guid("025f38f1-36b4-4c0d-80ba-82b204fffbac"), new DateTime(2023, 11, 4, 1, 14, 23, 204, DateTimeKind.Utc).AddTicks(5067), new Guid("b3f7eb7a-8528-4cc0-9f65-5b8b133d5ca0"), "Docker" },
                    { new Guid("072c5d14-24e9-497b-a46c-26a29d9348e8"), new DateTime(2023, 11, 4, 1, 14, 23, 204, DateTimeKind.Utc).AddTicks(4913), new Guid("8580b13d-3013-4ecb-937c-22c218195d9f"), "CSS" },
                    { new Guid("1476fe13-37cc-41ff-be3f-c7926a041303"), new DateTime(2023, 11, 4, 1, 14, 23, 204, DateTimeKind.Utc).AddTicks(5038), new Guid("6e9e16a3-5883-455c-b489-f06e6b20cdf1"), "Java" },
                    { new Guid("195a2c50-1490-4982-a757-3cf882c46fea"), new DateTime(2023, 11, 4, 1, 14, 23, 204, DateTimeKind.Utc).AddTicks(5003), new Guid("de40dd39-63b4-45c4-baef-601395f2afa8"), "SQL" },
                    { new Guid("1aed1b62-16d4-4fcb-a12d-3254e4e50da2"), new DateTime(2023, 11, 4, 1, 14, 23, 204, DateTimeKind.Utc).AddTicks(5018), new Guid("9674b5b1-bf64-4a7e-b886-97f4f3a882be"), "MVC" },
                    { new Guid("21d365f4-bbaa-41cf-8e54-5431deb9f6ba"), new DateTime(2023, 11, 4, 1, 14, 23, 204, DateTimeKind.Utc).AddTicks(5048), new Guid("6e9e16a3-5883-455c-b489-f06e6b20cdf1"), "ABAP" },
                    { new Guid("2c983279-ddab-46c1-9a40-6779c73e6eaa"), new DateTime(2023, 11, 4, 1, 14, 23, 204, DateTimeKind.Utc).AddTicks(5071), new Guid("b3f7eb7a-8528-4cc0-9f65-5b8b133d5ca0"), "Helm" },
                    { new Guid("3293507b-fe11-4326-842f-57657fd34c97"), new DateTime(2023, 11, 4, 1, 14, 23, 204, DateTimeKind.Utc).AddTicks(5033), new Guid("6e9e16a3-5883-455c-b489-f06e6b20cdf1"), "C#" },
                    { new Guid("8f81787c-662c-487e-aabf-7c1d03319103"), new DateTime(2023, 11, 4, 1, 14, 23, 204, DateTimeKind.Utc).AddTicks(5063), new Guid("de40dd39-63b4-45c4-baef-601395f2afa8"), "MongoDB" },
                    { new Guid("8f973d13-8f90-4179-abf2-2724dc394252"), new DateTime(2023, 11, 4, 1, 14, 23, 204, DateTimeKind.Utc).AddTicks(5044), new Guid("6e9e16a3-5883-455c-b489-f06e6b20cdf1"), "Python" },
                    { new Guid("aba33b35-4760-425a-9155-ba45515308f7"), new DateTime(2023, 11, 4, 1, 14, 23, 204, DateTimeKind.Utc).AddTicks(5054), new Guid("6e9e16a3-5883-455c-b489-f06e6b20cdf1"), "Javascript" },
                    { new Guid("d344acbb-f0f4-4bcf-9d85-5270025bc2d4"), new DateTime(2023, 11, 4, 1, 14, 23, 204, DateTimeKind.Utc).AddTicks(5024), new Guid("9674b5b1-bf64-4a7e-b886-97f4f3a882be"), "API" },
                    { new Guid("da9234d6-42c5-45a0-8e69-f5efabd17d83"), new DateTime(2023, 11, 4, 1, 14, 23, 204, DateTimeKind.Utc).AddTicks(5011), new Guid("8580b13d-3013-4ecb-937c-22c218195d9f"), "CSS" },
                    { new Guid("df4d59ef-a050-4e06-aab1-ceeb805452f3"), new DateTime(2023, 11, 4, 1, 14, 23, 204, DateTimeKind.Utc).AddTicks(5059), new Guid("de40dd39-63b4-45c4-baef-601395f2afa8"), "PostgreSQL" }
                });

            migrationBuilder.InsertData(
                schema: "portfolio",
                table: "projects",
                columns: new[] { "id", "created", "description", "KnowledgeId", "name" },
                values: new object[,]
                {
                    { new Guid("072c5d14-24e9-497b-a46c-26a29d9348e8"), new DateTime(2023, 11, 4, 1, 14, 23, 205, DateTimeKind.Utc).AddTicks(1202), "Test Project with css and html", new Guid("072c5d14-24e9-497b-a46c-26a29d9348e8"), "Project 1" },
                    { new Guid("195a2c50-1490-4982-a757-3cf882c46fea"), new DateTime(2023, 11, 4, 1, 14, 23, 205, DateTimeKind.Utc).AddTicks(1225), "Test Project 2 description 2", new Guid("072c5d14-24e9-497b-a46c-26a29d9348e8"), "Project 2" },
                    { new Guid("1aed1b62-16d4-4fcb-a12d-3254e4e50da2"), new DateTime(2023, 11, 4, 1, 14, 23, 205, DateTimeKind.Utc).AddTicks(1235), "Test Project 4 docker description 4", new Guid("025f38f1-36b4-4c0d-80ba-82b204fffbac"), "Project 4" },
                    { new Guid("d344acbb-f0f4-4bcf-9d85-5270025bc2d4"), new DateTime(2023, 11, 4, 1, 14, 23, 205, DateTimeKind.Utc).AddTicks(1239), "Test Project 5 helm description 5", new Guid("2c983279-ddab-46c1-9a40-6779c73e6eaa"), "Project 5" },
                    { new Guid("da9234d6-42c5-45a0-8e69-f5efabd17d83"), new DateTime(2023, 11, 4, 1, 14, 23, 205, DateTimeKind.Utc).AddTicks(1230), "Test Project 3 with mvc description 3", new Guid("1aed1b62-16d4-4fcb-a12d-3254e4e50da2"), "Project 3" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_knowledges_KnowledgeCategoryId",
                schema: "portfolio",
                table: "knowledges",
                column: "KnowledgeCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_projects_KnowledgeId",
                schema: "portfolio",
                table: "projects",
                column: "KnowledgeId");

            migrationBuilder.CreateIndex(
                name: "IX_projects_name_KnowledgeId",
                schema: "portfolio",
                table: "projects",
                columns: new[] { "name", "KnowledgeId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "projects",
                schema: "portfolio");

            migrationBuilder.DropTable(
                name: "knowledges",
                schema: "portfolio");

            migrationBuilder.DropTable(
                name: "knowledgecategories",
                schema: "portfolio");
        }
    }
}
