using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using portfolio.api.Persistence.Entities;

namespace portfolio.api.Persistence.Configurations
{
    public class KnowledgeCategorieConfiguration : IEntityTypeConfiguration<KnowledgeCategory>
    {
        public void Configure(EntityTypeBuilder<KnowledgeCategory> builder)
        {
            builder.ToTable("knowledgecategories", DbDefaults.Schema);
            builder.HasIdentifier();
            // builder.HasAudits();
            builder.Property(x => x.Name).IsRequired().HasColumnName("name").HasMaxLength(128);
            builder.HasAudits();
            builder.HasMany(x => x.Knowledges).WithOne(x => x.KnowledgeCategory).HasForeignKey(x => x.KnowledgeCategoryId);
            

            //Add some initial data
            // builder.HasData(new KnowledgeCategory { Id = new Guid("7c723b03-565e-4596-ba65-d67ebada473f"), Name = "DotNetCore", Created = DateTime.UtcNow, Modified = DateTime.UtcNow });
             builder.HasData(new { Id = new Guid("8580b13d-3013-4ecb-937c-22c218195d9f"), Name = "Frontend", Created = DateTime.UtcNow, Modified = DateTime.UtcNow });
            // builder.HasData(new { Id = new Guid("9674b5b1-bf64-4a7e-b886-97f4f3a882be"), Name = "Backend", Created = DateTime.UtcNow, Modified = DateTime.UtcNow });
            // builder.HasData(new { Id = new Guid("b3f7eb7a-8528-4cc0-9f65-5b8b133d5ca0"), Name = "DevOps", Created = DateTime.UtcNow, Modified = DateTime.UtcNow });
             builder.HasData(new { Id = new Guid("de40dd39-63b4-45c4-baef-601395f2afa8"), Name = "DataBases", Created = DateTime.UtcNow, Modified = DateTime.UtcNow });
            // builder.HasData(new { Id = new Guid("6e9e16a3-5883-455c-b489-f06e6b20cdf1"), Name = "Languages", Created = DateTime.UtcNow, Modified = DateTime.UtcNow });
        }
    }
}