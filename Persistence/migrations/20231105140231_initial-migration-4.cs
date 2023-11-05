using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace portfolio.api.Persistence.migrations
{
    /// <inheritdoc />
    public partial class initialmigration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_projects_knowledges_KnowledgeId",
                schema: "portfolio",
                table: "projects");

            migrationBuilder.DropIndex(
                name: "IX_projects_KnowledgeId",
                schema: "portfolio",
                table: "projects");

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledgecategories",
                keyColumn: "id",
                keyValue: new Guid("6e9e16a3-5883-455c-b489-f06e6b20cdf1"),
                column: "created",
                value: new DateTime(2023, 11, 5, 14, 2, 31, 332, DateTimeKind.Utc).AddTicks(8747));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledgecategories",
                keyColumn: "id",
                keyValue: new Guid("7c723b03-565e-4596-ba65-d67ebada473f"),
                column: "created",
                value: new DateTime(2023, 11, 5, 14, 2, 31, 332, DateTimeKind.Utc).AddTicks(8517));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledgecategories",
                keyColumn: "id",
                keyValue: new Guid("8580b13d-3013-4ecb-937c-22c218195d9f"),
                column: "created",
                value: new DateTime(2023, 11, 5, 14, 2, 31, 332, DateTimeKind.Utc).AddTicks(8715));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledgecategories",
                keyColumn: "id",
                keyValue: new Guid("9674b5b1-bf64-4a7e-b886-97f4f3a882be"),
                column: "created",
                value: new DateTime(2023, 11, 5, 14, 2, 31, 332, DateTimeKind.Utc).AddTicks(8730));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledgecategories",
                keyColumn: "id",
                keyValue: new Guid("b3f7eb7a-8528-4cc0-9f65-5b8b133d5ca0"),
                column: "created",
                value: new DateTime(2023, 11, 5, 14, 2, 31, 332, DateTimeKind.Utc).AddTicks(8735));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledgecategories",
                keyColumn: "id",
                keyValue: new Guid("de40dd39-63b4-45c4-baef-601395f2afa8"),
                column: "created",
                value: new DateTime(2023, 11, 5, 14, 2, 31, 332, DateTimeKind.Utc).AddTicks(8740));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("025f38f1-36b4-4c0d-80ba-82b204fffbac"),
                column: "created",
                value: new DateTime(2023, 11, 5, 14, 2, 31, 333, DateTimeKind.Utc).AddTicks(7816));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("072c5d14-24e9-497b-a46c-26a29d9348e8"),
                column: "created",
                value: new DateTime(2023, 11, 5, 14, 2, 31, 333, DateTimeKind.Utc).AddTicks(7716));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("1476fe13-37cc-41ff-be3f-c7926a041303"),
                column: "created",
                value: new DateTime(2023, 11, 5, 14, 2, 31, 333, DateTimeKind.Utc).AddTicks(7774));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("195a2c50-1490-4982-a757-3cf882c46fea"),
                column: "created",
                value: new DateTime(2023, 11, 5, 14, 2, 31, 333, DateTimeKind.Utc).AddTicks(7741));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("1aed1b62-16d4-4fcb-a12d-3254e4e50da2"),
                column: "created",
                value: new DateTime(2023, 11, 5, 14, 2, 31, 333, DateTimeKind.Utc).AddTicks(7755));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("21d365f4-bbaa-41cf-8e54-5431deb9f6ba"),
                column: "created",
                value: new DateTime(2023, 11, 5, 14, 2, 31, 333, DateTimeKind.Utc).AddTicks(7787));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("2c983279-ddab-46c1-9a40-6779c73e6eaa"),
                column: "created",
                value: new DateTime(2023, 11, 5, 14, 2, 31, 333, DateTimeKind.Utc).AddTicks(7821));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("3293507b-fe11-4326-842f-57657fd34c97"),
                column: "created",
                value: new DateTime(2023, 11, 5, 14, 2, 31, 333, DateTimeKind.Utc).AddTicks(7768));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("8f81787c-662c-487e-aabf-7c1d03319103"),
                column: "created",
                value: new DateTime(2023, 11, 5, 14, 2, 31, 333, DateTimeKind.Utc).AddTicks(7810));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("8f973d13-8f90-4179-abf2-2724dc394252"),
                column: "created",
                value: new DateTime(2023, 11, 5, 14, 2, 31, 333, DateTimeKind.Utc).AddTicks(7780));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("aba33b35-4760-425a-9155-ba45515308f7"),
                column: "created",
                value: new DateTime(2023, 11, 5, 14, 2, 31, 333, DateTimeKind.Utc).AddTicks(7795));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("d344acbb-f0f4-4bcf-9d85-5270025bc2d4"),
                column: "created",
                value: new DateTime(2023, 11, 5, 14, 2, 31, 333, DateTimeKind.Utc).AddTicks(7761));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("da9234d6-42c5-45a0-8e69-f5efabd17d83"),
                column: "created",
                value: new DateTime(2023, 11, 5, 14, 2, 31, 333, DateTimeKind.Utc).AddTicks(7748));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("df4d59ef-a050-4e06-aab1-ceeb805452f3"),
                column: "created",
                value: new DateTime(2023, 11, 5, 14, 2, 31, 333, DateTimeKind.Utc).AddTicks(7801));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("072c5d14-24e9-497b-a46c-26a29d9348e8"),
                column: "created",
                value: new DateTime(2023, 11, 5, 14, 2, 31, 334, DateTimeKind.Utc).AddTicks(3904));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("195a2c50-1490-4982-a757-3cf882c46fea"),
                column: "created",
                value: new DateTime(2023, 11, 5, 14, 2, 31, 334, DateTimeKind.Utc).AddTicks(3928));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("1aed1b62-16d4-4fcb-a12d-3254e4e50da2"),
                column: "created",
                value: new DateTime(2023, 11, 5, 14, 2, 31, 334, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("55931d72-9376-4dfd-8232-6a21d31148f4"),
                column: "created",
                value: new DateTime(2023, 11, 5, 14, 2, 31, 334, DateTimeKind.Utc).AddTicks(3953));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("75dcaf24-eb4e-4b8c-a4f1-f179ff1c780d"),
                column: "created",
                value: new DateTime(2023, 11, 5, 14, 2, 31, 334, DateTimeKind.Utc).AddTicks(3958));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("d344acbb-f0f4-4bcf-9d85-5270025bc2d4"),
                column: "created",
                value: new DateTime(2023, 11, 5, 14, 2, 31, 334, DateTimeKind.Utc).AddTicks(3944));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("da9234d6-42c5-45a0-8e69-f5efabd17d83"),
                column: "created",
                value: new DateTime(2023, 11, 5, 14, 2, 31, 334, DateTimeKind.Utc).AddTicks(3934));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("eb9836d2-752a-4cf1-b348-1fc1a8291bc8"),
                column: "created",
                value: new DateTime(2023, 11, 5, 14, 2, 31, 334, DateTimeKind.Utc).AddTicks(3964));

            migrationBuilder.AddForeignKey(
                name: "FK_knowledges_projects_id",
                schema: "portfolio",
                table: "knowledges",
                column: "id",
                principalSchema: "portfolio",
                principalTable: "projects",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_knowledges_projects_id",
                schema: "portfolio",
                table: "knowledges");

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledgecategories",
                keyColumn: "id",
                keyValue: new Guid("6e9e16a3-5883-455c-b489-f06e6b20cdf1"),
                column: "created",
                value: new DateTime(2023, 11, 5, 12, 47, 50, 922, DateTimeKind.Utc).AddTicks(8051));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledgecategories",
                keyColumn: "id",
                keyValue: new Guid("7c723b03-565e-4596-ba65-d67ebada473f"),
                column: "created",
                value: new DateTime(2023, 11, 5, 12, 47, 50, 922, DateTimeKind.Utc).AddTicks(7836));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledgecategories",
                keyColumn: "id",
                keyValue: new Guid("8580b13d-3013-4ecb-937c-22c218195d9f"),
                column: "created",
                value: new DateTime(2023, 11, 5, 12, 47, 50, 922, DateTimeKind.Utc).AddTicks(8020));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledgecategories",
                keyColumn: "id",
                keyValue: new Guid("9674b5b1-bf64-4a7e-b886-97f4f3a882be"),
                column: "created",
                value: new DateTime(2023, 11, 5, 12, 47, 50, 922, DateTimeKind.Utc).AddTicks(8033));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledgecategories",
                keyColumn: "id",
                keyValue: new Guid("b3f7eb7a-8528-4cc0-9f65-5b8b133d5ca0"),
                column: "created",
                value: new DateTime(2023, 11, 5, 12, 47, 50, 922, DateTimeKind.Utc).AddTicks(8038));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledgecategories",
                keyColumn: "id",
                keyValue: new Guid("de40dd39-63b4-45c4-baef-601395f2afa8"),
                column: "created",
                value: new DateTime(2023, 11, 5, 12, 47, 50, 922, DateTimeKind.Utc).AddTicks(8042));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("025f38f1-36b4-4c0d-80ba-82b204fffbac"),
                column: "created",
                value: new DateTime(2023, 11, 5, 12, 47, 50, 923, DateTimeKind.Utc).AddTicks(4628));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("072c5d14-24e9-497b-a46c-26a29d9348e8"),
                column: "created",
                value: new DateTime(2023, 11, 5, 12, 47, 50, 923, DateTimeKind.Utc).AddTicks(4473));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("1476fe13-37cc-41ff-be3f-c7926a041303"),
                column: "created",
                value: new DateTime(2023, 11, 5, 12, 47, 50, 923, DateTimeKind.Utc).AddTicks(4529));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("195a2c50-1490-4982-a757-3cf882c46fea"),
                column: "created",
                value: new DateTime(2023, 11, 5, 12, 47, 50, 923, DateTimeKind.Utc).AddTicks(4494));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("1aed1b62-16d4-4fcb-a12d-3254e4e50da2"),
                column: "created",
                value: new DateTime(2023, 11, 5, 12, 47, 50, 923, DateTimeKind.Utc).AddTicks(4507));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("21d365f4-bbaa-41cf-8e54-5431deb9f6ba"),
                column: "created",
                value: new DateTime(2023, 11, 5, 12, 47, 50, 923, DateTimeKind.Utc).AddTicks(4540));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("2c983279-ddab-46c1-9a40-6779c73e6eaa"),
                column: "created",
                value: new DateTime(2023, 11, 5, 12, 47, 50, 923, DateTimeKind.Utc).AddTicks(4633));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("3293507b-fe11-4326-842f-57657fd34c97"),
                column: "created",
                value: new DateTime(2023, 11, 5, 12, 47, 50, 923, DateTimeKind.Utc).AddTicks(4524));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("8f81787c-662c-487e-aabf-7c1d03319103"),
                column: "created",
                value: new DateTime(2023, 11, 5, 12, 47, 50, 923, DateTimeKind.Utc).AddTicks(4622));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("8f973d13-8f90-4179-abf2-2724dc394252"),
                column: "created",
                value: new DateTime(2023, 11, 5, 12, 47, 50, 923, DateTimeKind.Utc).AddTicks(4535));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("aba33b35-4760-425a-9155-ba45515308f7"),
                column: "created",
                value: new DateTime(2023, 11, 5, 12, 47, 50, 923, DateTimeKind.Utc).AddTicks(4546));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("d344acbb-f0f4-4bcf-9d85-5270025bc2d4"),
                column: "created",
                value: new DateTime(2023, 11, 5, 12, 47, 50, 923, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("da9234d6-42c5-45a0-8e69-f5efabd17d83"),
                column: "created",
                value: new DateTime(2023, 11, 5, 12, 47, 50, 923, DateTimeKind.Utc).AddTicks(4501));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("df4d59ef-a050-4e06-aab1-ceeb805452f3"),
                column: "created",
                value: new DateTime(2023, 11, 5, 12, 47, 50, 923, DateTimeKind.Utc).AddTicks(4617));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("072c5d14-24e9-497b-a46c-26a29d9348e8"),
                column: "created",
                value: new DateTime(2023, 11, 5, 12, 47, 50, 924, DateTimeKind.Utc).AddTicks(1325));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("195a2c50-1490-4982-a757-3cf882c46fea"),
                column: "created",
                value: new DateTime(2023, 11, 5, 12, 47, 50, 924, DateTimeKind.Utc).AddTicks(1349));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("1aed1b62-16d4-4fcb-a12d-3254e4e50da2"),
                column: "created",
                value: new DateTime(2023, 11, 5, 12, 47, 50, 924, DateTimeKind.Utc).AddTicks(1359));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("55931d72-9376-4dfd-8232-6a21d31148f4"),
                column: "created",
                value: new DateTime(2023, 11, 5, 12, 47, 50, 924, DateTimeKind.Utc).AddTicks(1375));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("75dcaf24-eb4e-4b8c-a4f1-f179ff1c780d"),
                column: "created",
                value: new DateTime(2023, 11, 5, 12, 47, 50, 924, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("d344acbb-f0f4-4bcf-9d85-5270025bc2d4"),
                column: "created",
                value: new DateTime(2023, 11, 5, 12, 47, 50, 924, DateTimeKind.Utc).AddTicks(1364));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("da9234d6-42c5-45a0-8e69-f5efabd17d83"),
                column: "created",
                value: new DateTime(2023, 11, 5, 12, 47, 50, 924, DateTimeKind.Utc).AddTicks(1354));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("eb9836d2-752a-4cf1-b348-1fc1a8291bc8"),
                column: "created",
                value: new DateTime(2023, 11, 5, 12, 47, 50, 924, DateTimeKind.Utc).AddTicks(1384));

            migrationBuilder.CreateIndex(
                name: "IX_projects_KnowledgeId",
                schema: "portfolio",
                table: "projects",
                column: "KnowledgeId");

            migrationBuilder.AddForeignKey(
                name: "FK_projects_knowledges_KnowledgeId",
                schema: "portfolio",
                table: "projects",
                column: "KnowledgeId",
                principalSchema: "portfolio",
                principalTable: "knowledges",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
