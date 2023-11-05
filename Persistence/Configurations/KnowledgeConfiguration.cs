using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using portfolio.api.Persistence.Entities;

namespace portfolio.api.Persistence.Configurations
{
    public class KnowledgeConfiguration : IEntityTypeConfiguration<Knowledge>
    {
        public void Configure(EntityTypeBuilder<Knowledge> builder)
        {
            builder.ToTable("knowledges", DbDefaults.Schema);
            builder.HasIdentifier();
            builder.HasAudits();
            builder.Property(x => x.Name).IsRequired().HasColumnName("name").HasMaxLength(128);
            builder.HasOne(a => a.KnowledgeCategory).WithMany(b => b.Knowledges).HasForeignKey(c => c.KnowledgeCategoryId);
            builder.HasOne(x => x.Project).WithMany(x => x.Knowledges).HasForeignKey(x => x.Id);
            
            builder.HasData(new { Id = new Guid("072c5d14-24e9-497b-a46c-26a29d9348e8"), Name = "CSS", KnowledgeCategoryId = new Guid("8580b13d-3013-4ecb-937c-22c218195d9f"), Created = DateTime.UtcNow, Modified = DateTime.UtcNow });
            builder.HasData(new { Id = new Guid("195a2c50-1490-4982-a757-3cf882c46fea"), Name = "SQL", KnowledgeCategoryId = new Guid("de40dd39-63b4-45c4-baef-601395f2afa8"), Created = DateTime.UtcNow, Modified = DateTime.UtcNow });
            builder.HasData(new { Id = new Guid("da9234d6-42c5-45a0-8e69-f5efabd17d83"), Name = "CSS", KnowledgeCategoryId = new Guid("8580b13d-3013-4ecb-937c-22c218195d9f"), Created = DateTime.UtcNow, Modified = DateTime.UtcNow });
            builder.HasData(new { Id = new Guid("1aed1b62-16d4-4fcb-a12d-3254e4e50da2"), Name = "MVC", KnowledgeCategoryId = new Guid("9674b5b1-bf64-4a7e-b886-97f4f3a882be"), Created = DateTime.UtcNow, Modified = DateTime.UtcNow });
            builder.HasData(new { Id = new Guid("d344acbb-f0f4-4bcf-9d85-5270025bc2d4"), Name = "API", KnowledgeCategoryId = new Guid("9674b5b1-bf64-4a7e-b886-97f4f3a882be"), Created = DateTime.UtcNow, Modified = DateTime.UtcNow });
            builder.HasData(new { Id = new Guid("3293507b-fe11-4326-842f-57657fd34c97"), Name = "C#", KnowledgeCategoryId = new Guid("6e9e16a3-5883-455c-b489-f06e6b20cdf1"), Created = DateTime.UtcNow, Modified = DateTime.UtcNow });
            builder.HasData(new { Id = new Guid("1476fe13-37cc-41ff-be3f-c7926a041303"), Name = "Java", KnowledgeCategoryId = new Guid("6e9e16a3-5883-455c-b489-f06e6b20cdf1"), Created = DateTime.UtcNow, Modified = DateTime.UtcNow });
            builder.HasData(new { Id = new Guid("8f973d13-8f90-4179-abf2-2724dc394252"), Name = "Python", KnowledgeCategoryId = new Guid("6e9e16a3-5883-455c-b489-f06e6b20cdf1"), Created = DateTime.UtcNow, Modified = DateTime.UtcNow });
            builder.HasData(new { Id = new Guid("21d365f4-bbaa-41cf-8e54-5431deb9f6ba"), Name = "ABAP", KnowledgeCategoryId = new Guid("6e9e16a3-5883-455c-b489-f06e6b20cdf1"), Created = DateTime.UtcNow, Modified = DateTime.UtcNow });
            builder.HasData(new { Id = new Guid("aba33b35-4760-425a-9155-ba45515308f7"), Name = "Javascript", KnowledgeCategoryId = new Guid("6e9e16a3-5883-455c-b489-f06e6b20cdf1"), Created = DateTime.UtcNow, Modified = DateTime.UtcNow });
            builder.HasData(new { Id = new Guid("df4d59ef-a050-4e06-aab1-ceeb805452f3"), Name = "PostgreSQL", KnowledgeCategoryId = new Guid("de40dd39-63b4-45c4-baef-601395f2afa8"), Created = DateTime.UtcNow, Modified = DateTime.UtcNow });
            builder.HasData(new { Id = new Guid("8f81787c-662c-487e-aabf-7c1d03319103"), Name = "MongoDB", KnowledgeCategoryId = new Guid("de40dd39-63b4-45c4-baef-601395f2afa8"), Created = DateTime.UtcNow, Modified = DateTime.UtcNow });
            builder.HasData(new { Id = new Guid("025f38f1-36b4-4c0d-80ba-82b204fffbac"), Name = "Docker", KnowledgeCategoryId = new Guid("b3f7eb7a-8528-4cc0-9f65-5b8b133d5ca0"), Created = DateTime.UtcNow, Modified = DateTime.UtcNow });
            builder.HasData(new { Id = new Guid("2c983279-ddab-46c1-9a40-6779c73e6eaa"), Name = "Helm", KnowledgeCategoryId = new Guid("b3f7eb7a-8528-4cc0-9f65-5b8b133d5ca0"), Created = DateTime.UtcNow, Modified = DateTime.UtcNow });
        }
    }
}