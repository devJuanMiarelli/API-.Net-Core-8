using backEndTest.Models;
using Microsoft.EntityFrameworkCore;

namespace backEndTest.Data.Map
{
    public class ResultadoMap : IEntityTypeConfiguration<Resultado>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Resultado> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.Total).IsRequired();
            builder.Property(x => x.Juros).IsRequired();
        }
    }
}
