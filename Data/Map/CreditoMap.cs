using backEndTest.Models;
using Microsoft.EntityFrameworkCore;

namespace backEndTest.Data.Map
{
    public class CreditoMap : IEntityTypeConfiguration<Credito>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Credito> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Valor).IsRequired();
            builder.Property(x => x.Tipo).IsRequired();
            builder.Property(x => x.Parcelas).IsRequired();
            builder.Property(x => x.Vencimento).IsRequired();
        }
    }
}
