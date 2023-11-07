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
            builder.Property(x => x.ProjectId).IsRequired().HasColumnName("project_id");
            builder.HasOne(a => a.KnowledgeCategory).WithMany(b => b.Knowledges).HasForeignKey(c => c.KnowledgeCategoryId);
            builder.HasIndex(b => new{b.Id, b.ProjectId}).IsUnique();
            
             builder.HasData(new { Id = new Guid("072c5d14-24e9-497b-a46c-26a29d9348e8"), ProjectId=new Guid("85532c07-d62b-458a-94a8-b3c2f7bd3086"), Name = "CSS", KnowledgeCategoryId = new Guid("8580b13d-3013-4ecb-937c-22c218195d9f"), Created = DateTime.UtcNow, Modified = DateTime.UtcNow });
             builder.HasData(new { Id = new Guid("195a2c50-1490-4982-a757-3cf882c46fea"), ProjectId=new Guid("85532c07-d62b-458a-94a8-b3c2f7bd3086"), Name = "HTML", KnowledgeCategoryId = new Guid("de40dd39-63b4-45c4-baef-601395f2afa8"), Created = DateTime.UtcNow, Modified = DateTime.UtcNow });
        }
    }
}