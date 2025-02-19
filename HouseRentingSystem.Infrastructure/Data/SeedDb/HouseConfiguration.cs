﻿using HouseRentingSystem.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouseRentingSystem.Infrastructure.Data.SeedDb
{
    internal class HouseConfiguration : IEntityTypeConfiguration<House>
    {
        public void Configure(EntityTypeBuilder<House> builder)
        {
            builder
                .HasOne(h => h.Category)
                .WithMany(c => c.Houses)
                .HasForeignKey(h => h.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
               .HasOne(h => h.Agent)
               .WithMany(a => a.Houses)
               .HasForeignKey(h => h.AgentId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasKey(h => h.Id);
            builder.Property(h => h.Id)
                .ValueGeneratedOnAdd();

            var data = new SeedData();
            builder.HasData(new House[] { data.ThirdHouse, data.FirstHouse, data.SecondHouse });
        }
    }
}
