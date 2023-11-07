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
                name: "projects",
                schema: "portfolio",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projects", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "knowledges",
                schema: "portfolio",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    KnowledgeCategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    project_id = table.Column<Guid>(type: "uuid", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_knowledges_projects_project_id",
                        column: x => x.project_id,
                        principalSchema: "portfolio",
                        principalTable: "projects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "portfolio",
                table: "knowledgecategories",
                columns: new[] { "id", "created", "name" },
                values: new object[,]
                {
                    { new Guid("8580b13d-3013-4ecb-937c-22c218195d9f"), new DateTime(2023, 11, 5, 23, 8, 50, 899, DateTimeKind.Utc).AddTicks(3588), "Frontend" },
                    { new Guid("de40dd39-63b4-45c4-baef-601395f2afa8"), new DateTime(2023, 11, 5, 23, 8, 50, 899, DateTimeKind.Utc).AddTicks(3621), "DataBases" }
                });

            migrationBuilder.InsertData(
                schema: "portfolio",
                table: "projects",
                columns: new[] { "id", "created", "description", "name" },
                values: new object[,]
                {
                    { new Guid("700c0ec5-1e0f-41b4-bfed-e97e32ab7366"), new DateTime(2023, 11, 5, 23, 8, 50, 900, DateTimeKind.Utc).AddTicks(5896), "Test Project 2 description 2", "Project 2" },
                    { new Guid("85532c07-d62b-458a-94a8-b3c2f7bd3086"), new DateTime(2023, 11, 5, 23, 8, 50, 900, DateTimeKind.Utc).AddTicks(5872), "Test Project with css and html", "Project 1" }
                });

            migrationBuilder.InsertData(
                schema: "portfolio",
                table: "knowledges",
                columns: new[] { "id", "created", "KnowledgeCategoryId", "name", "project_id" },
                values: new object[,]
                {
                    { new Guid("072c5d14-24e9-497b-a46c-26a29d9348e8"), new DateTime(2023, 11, 5, 23, 8, 50, 900, DateTimeKind.Utc).AddTicks(190), new Guid("8580b13d-3013-4ecb-937c-22c218195d9f"), "CSS", new Guid("85532c07-d62b-458a-94a8-b3c2f7bd3086") },
                    { new Guid("195a2c50-1490-4982-a757-3cf882c46fea"), new DateTime(2023, 11, 5, 23, 8, 50, 900, DateTimeKind.Utc).AddTicks(218), new Guid("de40dd39-63b4-45c4-baef-601395f2afa8"), "HTML", new Guid("85532c07-d62b-458a-94a8-b3c2f7bd3086") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_knowledges_id_project_id",
                schema: "portfolio",
                table: "knowledges",
                columns: new[] { "id", "project_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_knowledges_KnowledgeCategoryId",
                schema: "portfolio",
                table: "knowledges",
                column: "KnowledgeCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_knowledges_project_id",
                schema: "portfolio",
                table: "knowledges",
                column: "project_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "knowledges",
                schema: "portfolio");

            migrationBuilder.DropTable(
                name: "knowledgecategories",
                schema: "portfolio");

            migrationBuilder.DropTable(
                name: "projects",
                schema: "portfolio");
        }
    }
}
