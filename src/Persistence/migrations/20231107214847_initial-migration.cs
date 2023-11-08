using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace portfolio.api.Persistence.migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "portfolio");

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
                    name = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    project_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_knowledges", x => x.id);
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
                table: "projects",
                columns: new[] { "id", "created", "description", "name" },
                values: new object[,]
                {
                    { new Guid("700c0ec5-1e0f-41b4-bfed-e97e32ab7366"), new DateTime(2023, 11, 7, 21, 48, 46, 687, DateTimeKind.Utc).AddTicks(7311), "Test Project 2 description 2", "Project 2" },
                    { new Guid("85532c07-d62b-458a-94a8-b3c2f7bd3086"), new DateTime(2023, 11, 7, 21, 48, 46, 687, DateTimeKind.Utc).AddTicks(7289), "Test Project with css and html", "Project 1" }
                });

            migrationBuilder.InsertData(
                schema: "portfolio",
                table: "knowledges",
                columns: new[] { "id", "created", "name", "project_id" },
                values: new object[,]
                {
                    { new Guid("072c5d14-24e9-497b-a46c-26a29d9348e8"), new DateTime(2023, 11, 7, 21, 48, 46, 687, DateTimeKind.Utc).AddTicks(1603), "CSS", new Guid("85532c07-d62b-458a-94a8-b3c2f7bd3086") },
                    { new Guid("195a2c50-1490-4982-a757-3cf882c46fea"), new DateTime(2023, 11, 7, 21, 48, 46, 687, DateTimeKind.Utc).AddTicks(1637), "HTML", new Guid("85532c07-d62b-458a-94a8-b3c2f7bd3086") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_knowledges_id_project_id",
                schema: "portfolio",
                table: "knowledges",
                columns: new[] { "id", "project_id" },
                unique: true);

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
                name: "projects",
                schema: "portfolio");
        }
    }
}
