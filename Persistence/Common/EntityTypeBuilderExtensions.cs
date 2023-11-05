using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace portfolio.api.Persistence.Common
{
    public static class EntityTypeBuilderExtensions {
        public static IndexBuilder<T> WithName<T>(this IndexBuilder<T> indexBuilder) {
            var isUnique = indexBuilder.Metadata.IsUnique;
            var isFiltered = !string.IsNullOrEmpty(indexBuilder.Metadata.GetFilter());
            var fields = indexBuilder.Metadata.Properties.Select(x => x.Name);
            var sb = new StringBuilder().Append("ix_");
            if (isUnique) sb.Append("uq_");
            if (isFiltered) sb.Append("ft_");
            sb.Append(ToLowerCase(typeof(T).Name));
            foreach (var field in fields)
                sb.Append("_" + ToLowerCase(field));
            return indexBuilder;
        }

        private static string ToLowerCase(string input) {
            return string.Concat(input.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x : x.ToString()));
        }
    }
}