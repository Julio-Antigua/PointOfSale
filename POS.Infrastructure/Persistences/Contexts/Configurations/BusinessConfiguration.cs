﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Infrastructure.Persistences.Contexts.Configurations
{
    public class BusinessConfiguration : IEntityTypeConfiguration<Business>
    {
        public void Configure(EntityTypeBuilder<Business> builder)
        {
            builder.HasKey(e => e.BusinessId).HasName("PK__Business__F1EAA36EB827AA8B");

            builder.ToTable("Business");

            builder.Property(e => e.Address).IsUnicode(false);
            builder.Property(e => e.BusinessName)
                .HasMaxLength(100)
                .IsUnicode(false);
            builder.Property(e => e.Code)
                .HasMaxLength(100)
                .IsUnicode(false);
            builder.Property(e => e.CreationDate).HasColumnType("datetime");
            builder.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            builder.Property(e => e.Logo).IsUnicode(false);
            builder.Property(e => e.Mision).IsUnicode(false);
            builder.Property(e => e.Phone)
                .HasMaxLength(100)
                .IsUnicode(false);
            builder.Property(e => e.Ruc)
                .HasMaxLength(11)
                .IsUnicode(false);
            builder.Property(e => e.Vision).IsUnicode(false);

            builder.HasOne(d => d.District).WithMany(p => p.Businesses)
                .HasForeignKey(d => d.DistrictId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Business__Distri__4AB81AF0");
        }
    }
}
