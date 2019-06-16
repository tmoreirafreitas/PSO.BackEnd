﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PSO.BackEnd.Domain.Entities;

namespace Pso.BackEnd.Infra.Data.EFCore.Mappings
{
    public class LenteMap : IEntityTypeConfiguration<Lente>
    {
        public void Configure(EntityTypeBuilder<Lente> builder)
        {
            builder.Ignore(e => e.Valid);
            builder.Ignore(e => e.ValidationResult);
            builder.Ignore(e => e.Invalid);
            builder.HasKey(l => l.LenteId).HasName("PK_Lente");
            builder.Property(l => l.Cyl)
                .HasColumnType("float");

            builder.Property(l => l.Eixo)
                .HasColumnType("smallint");

            builder.Property(l => l.Grau)
                .HasColumnType("float")
                .IsRequired();

            //var converter = new EnumToStringConverter<LenteType>();
            builder.Property(l => l.LenteType)
                .HasColumnType("varchar(2)")
                .HasMaxLength(2)
                .IsRequired();
        }
    }
}