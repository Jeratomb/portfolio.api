using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace portfolio.api.Persistence.migrations
{
    /// <inheritdoc />
    public partial class initialmigration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "scale",
                schema: "portfolio",
                table: "knowledges",
                newName: "name");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                schema: "portfolio",
                table: "knowledges",
                newName: "scale");

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledgecategories",
                keyColumn: "id",
                keyValue: new Guid("6e9e16a3-5883-455c-b489-f06e6b20cdf1"),
                column: "created",
                value: new DateTime(2023, 11, 4, 23, 53, 38, 314, DateTimeKind.Utc).AddTicks(2139));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledgecategories",
                keyColumn: "id",
                keyValue: new Guid("7c723b03-565e-4596-ba65-d67ebada473f"),
                column: "created",
                value: new DateTime(2023, 11, 4, 23, 53, 38, 314, DateTimeKind.Utc).AddTicks(1543));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledgecategories",
                keyColumn: "id",
                keyValue: new Guid("8580b13d-3013-4ecb-937c-22c218195d9f"),
                column: "created",
                value: new DateTime(2023, 11, 4, 23, 53, 38, 314, DateTimeKind.Utc).AddTicks(2056));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledgecategories",
                keyColumn: "id",
                keyValue: new Guid("9674b5b1-bf64-4a7e-b886-97f4f3a882be"),
                column: "created",
                value: new DateTime(2023, 11, 4, 23, 53, 38, 314, DateTimeKind.Utc).AddTicks(2094));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledgecategories",
                keyColumn: "id",
                keyValue: new Guid("b3f7eb7a-8528-4cc0-9f65-5b8b133d5ca0"),
                column: "created",
                value: new DateTime(2023, 11, 4, 23, 53, 38, 314, DateTimeKind.Utc).AddTicks(2107));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledgecategories",
                keyColumn: "id",
                keyValue: new Guid("de40dd39-63b4-45c4-baef-601395f2afa8"),
                column: "created",
                value: new DateTime(2023, 11, 4, 23, 53, 38, 314, DateTimeKind.Utc).AddTicks(2119));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("025f38f1-36b4-4c0d-80ba-82b204fffbac"),
                column: "created",
                value: new DateTime(2023, 11, 4, 23, 53, 38, 315, DateTimeKind.Utc).AddTicks(3435));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("072c5d14-24e9-497b-a46c-26a29d9348e8"),
                column: "created",
                value: new DateTime(2023, 11, 4, 23, 53, 38, 315, DateTimeKind.Utc).AddTicks(3329));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("1476fe13-37cc-41ff-be3f-c7926a041303"),
                column: "created",
                value: new DateTime(2023, 11, 4, 23, 53, 38, 315, DateTimeKind.Utc).AddTicks(3397));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("195a2c50-1490-4982-a757-3cf882c46fea"),
                column: "created",
                value: new DateTime(2023, 11, 4, 23, 53, 38, 315, DateTimeKind.Utc).AddTicks(3359));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("1aed1b62-16d4-4fcb-a12d-3254e4e50da2"),
                column: "created",
                value: new DateTime(2023, 11, 4, 23, 53, 38, 315, DateTimeKind.Utc).AddTicks(3375));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("21d365f4-bbaa-41cf-8e54-5431deb9f6ba"),
                column: "created",
                value: new DateTime(2023, 11, 4, 23, 53, 38, 315, DateTimeKind.Utc).AddTicks(3406));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("2c983279-ddab-46c1-9a40-6779c73e6eaa"),
                column: "created",
                value: new DateTime(2023, 11, 4, 23, 53, 38, 315, DateTimeKind.Utc).AddTicks(3441));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("3293507b-fe11-4326-842f-57657fd34c97"),
                column: "created",
                value: new DateTime(2023, 11, 4, 23, 53, 38, 315, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("8f81787c-662c-487e-aabf-7c1d03319103"),
                column: "created",
                value: new DateTime(2023, 11, 4, 23, 53, 38, 315, DateTimeKind.Utc).AddTicks(3429));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("8f973d13-8f90-4179-abf2-2724dc394252"),
                column: "created",
                value: new DateTime(2023, 11, 4, 23, 53, 38, 315, DateTimeKind.Utc).AddTicks(3402));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("aba33b35-4760-425a-9155-ba45515308f7"),
                column: "created",
                value: new DateTime(2023, 11, 4, 23, 53, 38, 315, DateTimeKind.Utc).AddTicks(3415));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("d344acbb-f0f4-4bcf-9d85-5270025bc2d4"),
                column: "created",
                value: new DateTime(2023, 11, 4, 23, 53, 38, 315, DateTimeKind.Utc).AddTicks(3383));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("da9234d6-42c5-45a0-8e69-f5efabd17d83"),
                column: "created",
                value: new DateTime(2023, 11, 4, 23, 53, 38, 315, DateTimeKind.Utc).AddTicks(3367));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "knowledges",
                keyColumn: "id",
                keyValue: new Guid("df4d59ef-a050-4e06-aab1-ceeb805452f3"),
                column: "created",
                value: new DateTime(2023, 11, 4, 23, 53, 38, 315, DateTimeKind.Utc).AddTicks(3422));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("072c5d14-24e9-497b-a46c-26a29d9348e8"),
                column: "created",
                value: new DateTime(2023, 11, 4, 23, 53, 38, 316, DateTimeKind.Utc).AddTicks(864));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("195a2c50-1490-4982-a757-3cf882c46fea"),
                column: "created",
                value: new DateTime(2023, 11, 4, 23, 53, 38, 316, DateTimeKind.Utc).AddTicks(896));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("1aed1b62-16d4-4fcb-a12d-3254e4e50da2"),
                column: "created",
                value: new DateTime(2023, 11, 4, 23, 53, 38, 316, DateTimeKind.Utc).AddTicks(908));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("55931d72-9376-4dfd-8232-6a21d31148f4"),
                column: "created",
                value: new DateTime(2023, 11, 4, 23, 53, 38, 316, DateTimeKind.Utc).AddTicks(924));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("75dcaf24-eb4e-4b8c-a4f1-f179ff1c780d"),
                column: "created",
                value: new DateTime(2023, 11, 4, 23, 53, 38, 316, DateTimeKind.Utc).AddTicks(929));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("d344acbb-f0f4-4bcf-9d85-5270025bc2d4"),
                column: "created",
                value: new DateTime(2023, 11, 4, 23, 53, 38, 316, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("da9234d6-42c5-45a0-8e69-f5efabd17d83"),
                column: "created",
                value: new DateTime(2023, 11, 4, 23, 53, 38, 316, DateTimeKind.Utc).AddTicks(902));

            migrationBuilder.UpdateData(
                schema: "portfolio",
                table: "projects",
                keyColumn: "id",
                keyValue: new Guid("eb9836d2-752a-4cf1-b348-1fc1a8291bc8"),
                column: "created",
                value: new DateTime(2023, 11, 4, 23, 53, 38, 316, DateTimeKind.Utc).AddTicks(935));
        }
    }
}
