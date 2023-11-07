﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using portfolio.api.Persistence.Context;

#nullable disable

namespace portfolio.api.Persistence.migrations
{
    [DbContext(typeof(PortfolioDbContext))]
    [Migration("20231105230851_initial-migration-1")]
    partial class initialmigration1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("portfolio.api.Persistence.Entities.Knowledge", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created");

                    b.Property<Guid>("KnowledgeCategoryId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Modified")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("modified");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("name");

                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uuid")
                        .HasColumnName("project_id");

                    b.HasKey("Id");

                    b.HasIndex("KnowledgeCategoryId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("Id", "ProjectId")
                        .IsUnique();

                    b.ToTable("knowledges", "portfolio");

                    b.HasData(
                        new
                        {
                            Id = new Guid("072c5d14-24e9-497b-a46c-26a29d9348e8"),
                            Created = new DateTime(2023, 11, 5, 23, 8, 50, 900, DateTimeKind.Utc).AddTicks(190),
                            KnowledgeCategoryId = new Guid("8580b13d-3013-4ecb-937c-22c218195d9f"),
                            Modified = new DateTime(2023, 11, 5, 23, 8, 50, 900, DateTimeKind.Utc).AddTicks(191),
                            Name = "CSS",
                            ProjectId = new Guid("85532c07-d62b-458a-94a8-b3c2f7bd3086")
                        },
                        new
                        {
                            Id = new Guid("195a2c50-1490-4982-a757-3cf882c46fea"),
                            Created = new DateTime(2023, 11, 5, 23, 8, 50, 900, DateTimeKind.Utc).AddTicks(218),
                            KnowledgeCategoryId = new Guid("de40dd39-63b4-45c4-baef-601395f2afa8"),
                            Modified = new DateTime(2023, 11, 5, 23, 8, 50, 900, DateTimeKind.Utc).AddTicks(218),
                            Name = "HTML",
                            ProjectId = new Guid("85532c07-d62b-458a-94a8-b3c2f7bd3086")
                        });
                });

            modelBuilder.Entity("portfolio.api.Persistence.Entities.KnowledgeCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created");

                    b.Property<DateTime?>("Modified")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("modified");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("knowledgecategories", "portfolio");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8580b13d-3013-4ecb-937c-22c218195d9f"),
                            Created = new DateTime(2023, 11, 5, 23, 8, 50, 899, DateTimeKind.Utc).AddTicks(3588),
                            Modified = new DateTime(2023, 11, 5, 23, 8, 50, 899, DateTimeKind.Utc).AddTicks(3591),
                            Name = "Frontend"
                        },
                        new
                        {
                            Id = new Guid("de40dd39-63b4-45c4-baef-601395f2afa8"),
                            Created = new DateTime(2023, 11, 5, 23, 8, 50, 899, DateTimeKind.Utc).AddTicks(3621),
                            Modified = new DateTime(2023, 11, 5, 23, 8, 50, 899, DateTimeKind.Utc).AddTicks(3622),
                            Name = "DataBases"
                        });
                });

            modelBuilder.Entity("portfolio.api.Persistence.Entities.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<DateTime?>("Modified")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("modified");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("projects", "portfolio");

                    b.HasData(
                        new
                        {
                            Id = new Guid("85532c07-d62b-458a-94a8-b3c2f7bd3086"),
                            Created = new DateTime(2023, 11, 5, 23, 8, 50, 900, DateTimeKind.Utc).AddTicks(5872),
                            Description = "Test Project with css and html",
                            Name = "Project 1"
                        },
                        new
                        {
                            Id = new Guid("700c0ec5-1e0f-41b4-bfed-e97e32ab7366"),
                            Created = new DateTime(2023, 11, 5, 23, 8, 50, 900, DateTimeKind.Utc).AddTicks(5896),
                            Description = "Test Project 2 description 2",
                            Name = "Project 2"
                        });
                });

            modelBuilder.Entity("portfolio.api.Persistence.Entities.Knowledge", b =>
                {
                    b.HasOne("portfolio.api.Persistence.Entities.KnowledgeCategory", "KnowledgeCategory")
                        .WithMany("Knowledges")
                        .HasForeignKey("KnowledgeCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("portfolio.api.Persistence.Entities.Project", "Project")
                        .WithMany("Knowledges")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KnowledgeCategory");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("portfolio.api.Persistence.Entities.KnowledgeCategory", b =>
                {
                    b.Navigation("Knowledges");
                });

            modelBuilder.Entity("portfolio.api.Persistence.Entities.Project", b =>
                {
                    b.Navigation("Knowledges");
                });
#pragma warning restore 612, 618
        }
    }
}
