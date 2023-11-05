using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using portfolio.api.Persistence.Entities;


namespace portfolio.api.Persistence.Configurations
{
    internal static class DbDefaults
    {
        public const string Schema = "portfolio";

        public static void HasAudits<T>(this EntityTypeBuilder<T> builder) where T : class, IAuditEntity
        {
            builder.Property(x => x.Created).IsRequired().HasColumnName("created").HasValueGenerator<DateTimeGenerator>().ValueGeneratedOnAdd();
            builder.Property(x => x.Modified).HasColumnName("modified").HasValueGenerator<DateTimeGenerator>().ValueGeneratedOnUpdate();
        }

        public static void HasIdentifier<T>(this EntityTypeBuilder<T> builder) where T : class, IGuidIdentifier
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().HasColumnName("id").HasValueGenerator(typeof(GuidValueGenerator)).ValueGeneratedOnAdd();
        }
    }

    internal sealed class DateTimeGenerator : ValueGenerator<DateTime>
    {
        public override DateTime Next(EntityEntry entry)
        {
            return DateTime.UtcNow;
        }

        public override bool GeneratesTemporaryValues => false;
    }
}