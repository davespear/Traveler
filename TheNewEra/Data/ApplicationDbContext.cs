﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TheNewEra.Models.FireFusionSteel.SmallArms;
using static System.Net.Mime.MediaTypeNames;

namespace TheNewEra.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<SmallArmsAmmoTypeDropdownModel> SmallArmsAmmoTypeDropdown { get; set; }
    public DbSet<SmallArmsAmmoManufacturingModifierDropdownModel> SmallArmsAmmoManufacturingModifierDropdown { get; set; }
    public DbSet<SmallArmsAmmoTLModifierDropdownModel> SmallArmsAmmoTLModifierDropdown { get; set; }
    public DbSet<SmallArmsAmmoSpecialModifierDropdownModel> SmallArmsAmmoSpecialModifierDropdown { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        MapSmallArmsTables(modelBuilder);
        SmallArmsSeed(modelBuilder);       
    }

    // Maps for modelBuilders
    private static void MapSmallArmsTables(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SmallArmsAmmoTypeDropdownModel>().ToTable("SmallArmsAmmoTypeDropdown");
        modelBuilder.Entity<SmallArmsAmmoManufacturingModifierDropdownModel>().ToTable("SmallArmsAmmoManufacturingModifierDropdown");
        modelBuilder.Entity<SmallArmsAmmoTLModifierDropdownModel>().ToTable("SmallArmsTLTypeAmmoDropdown");
        modelBuilder.Entity<SmallArmsAmmoSpecialModifierDropdownModel>().ToTable("SmallArmsAmmoSpecialModifierDropdown");
    }

    // Seed data for modelBuilders
    public static void SmallArmsSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SmallArmsAmmoTypeDropdownModel>().HasData(
            new SmallArmsAmmoTypeDropdownModel { Id = 1, Text = "Straight", Modifier = 0.003 },
            new SmallArmsAmmoTypeDropdownModel { Id = 2, Text = "Necked", Modifier = 0.008 },
            new SmallArmsAmmoTypeDropdownModel { Id = 3, Text = "Shotgun", Modifier = 0.01 }
        );
        modelBuilder.Entity<SmallArmsAmmoManufacturingModifierDropdownModel>().HasData(
           new SmallArmsAmmoManufacturingModifierDropdownModel { Id = 1, Text = "Shotgun", Modifier = .01 },
           new SmallArmsAmmoManufacturingModifierDropdownModel { Id = 2, Text = "Mass-produced", Modifier = .02 },
           new SmallArmsAmmoManufacturingModifierDropdownModel { Id = 3, Text = "Conventional", Modifier = .04 },
           new SmallArmsAmmoManufacturingModifierDropdownModel { Id = 4, Text = "High-powered", Modifier = .05 }
        );
        modelBuilder.Entity<SmallArmsAmmoTLModifierDropdownModel>().HasData(
            new SmallArmsAmmoTLModifierDropdownModel { Id = 1, Text = "3", Modifier = 0.6 },
            new SmallArmsAmmoTLModifierDropdownModel { Id = 2, Text = "4", Modifier = 0.7 },
            new SmallArmsAmmoTLModifierDropdownModel { Id = 3, Text = "5", Modifier = 0.8 },
            new SmallArmsAmmoTLModifierDropdownModel { Id = 4, Text = "6", Modifier = 0.9 },
            new SmallArmsAmmoTLModifierDropdownModel { Id = 5, Text = "7", Modifier = 1.0 },
            new SmallArmsAmmoTLModifierDropdownModel { Id = 6, Text = "8", Modifier = 1.1 },
            new SmallArmsAmmoTLModifierDropdownModel { Id = 7, Text = "9+", Modifier = 1.3 }
        );

        modelBuilder.Entity<SmallArmsAmmoSpecialModifierDropdownModel>().HasData(
           new SmallArmsAmmoSpecialModifierDropdownModel { Id = 1, Text = "None", Modifier = 2.0 },
           new SmallArmsAmmoSpecialModifierDropdownModel { Id = 2, Text = "HE", Modifier = 2.0 },
           new SmallArmsAmmoSpecialModifierDropdownModel { Id = 3, Text = "DS", Modifier = 2.0 },
           new SmallArmsAmmoSpecialModifierDropdownModel { Id = 5, Text = "HEAP", Modifier = 3.0 },
           new SmallArmsAmmoSpecialModifierDropdownModel { Id = 6, Text = "Traq", Modifier = 2.0 }
        );
    }
}