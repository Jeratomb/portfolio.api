using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using portfolio.api.Persistence.Entities;

namespace portfolio.api.Persistence.Configurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("projects", DbDefaults.Schema);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().HasColumnName("id").HasValueGenerator(typeof(GuidValueGenerator)).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasColumnName("name").HasMaxLength(128);
            builder.Property(x => x.Description).HasColumnName("description");
            builder.HasMany(p => p.Knowledges).WithOne(p => p.Project).HasForeignKey(p => p.ProjectId).HasPrincipalKey(p => p.Id);
            builder.HasAudits();

             builder.HasData(new { Id = new Guid("85532c07-d62b-458a-94a8-b3c2f7bd3086"), Name = "Project 1", Description = "Test Project with css and html" , Created = DateTime.UtcNow });
             builder.HasData(new { Id = new Guid("700c0ec5-1e0f-41b4-bfed-e97e32ab7366"), Name = "Project 2", Description = "Test Project 2 description 2", Created = DateTime.UtcNow});
            // builder.HasData(new { Id = new Guid("da9234d6-42c5-45a0-8e69-f5efabd17d83"), KnowledgeId = new Guid("1aed1b62-16d4-4fcb-a12d-3254e4e50da2"), Name = "Project 3", Description = "Test Project 3 with mvc description 3", Created = DateTime.UtcNow});
            // builder.HasData(new { Id = new Guid("1aed1b62-16d4-4fcb-a12d-3254e4e50da2"), KnowledgeId = new Guid("025f38f1-36b4-4c0d-80ba-82b204fffbac"), Name = "Project 4", Description = "Test Project 4 docker description 4", Created = DateTime.UtcNow});
            // builder.HasData(new { Id = new Guid("d344acbb-f0f4-4bcf-9d85-5270025bc2d4"), KnowledgeId = new Guid("2c983279-ddab-46c1-9a40-6779c73e6eaa"), Name = "Project 5", Description = "Test Project 5 helm description 5", Created = DateTime.UtcNow});
            // builder.HasData(new { Id = new Guid("55931d72-9376-4dfd-8232-6a21d31148f4"), KnowledgeId = new Guid("025f38f1-36b4-4c0d-80ba-82b204fffbac"), Name = "Project 5", Description = "Test Project 5 helm description 5", Created = DateTime.UtcNow});
            // builder.HasData(new { Id = new Guid("75dcaf24-eb4e-4b8c-a4f1-f179ff1c780d"), KnowledgeId = new Guid("1aed1b62-16d4-4fcb-a12d-3254e4e50da2"), Name = "Project 5", Description = "Test Project 5 helm description 5", Created = DateTime.UtcNow});
            // builder.HasData(new { Id = new Guid("eb9836d2-752a-4cf1-b348-1fc1a8291bc8"), KnowledgeId = new Guid("072c5d14-24e9-497b-a46c-26a29d9348e8"), Name = "Project 5", Description = "Test Project 5 helm description 5", Created = DateTime.UtcNow});
        }
    }
}