﻿// <auto-generated />
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(InventarioContext))]
    partial class InventarioContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.Entities.Estado", b =>
                {
                    b.Property<string>("codEstado")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("codPais")
                        .HasColumnType("varchar(3)");

                    b.Property<string>("nombreEstado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("codEstado");

                    b.HasIndex("codPais");

                    b.ToTable("Estado", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Pais", b =>
                {
                    b.Property<string>("codPais")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombrePais")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("codPais");

                    b.ToTable("Pais", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Region", b =>
                {
                    b.Property<string>("codRegion")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("codEstado")
                        .IsRequired()
                        .HasColumnType("varchar(3)");

                    b.Property<string>("nombreRegion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("codRegion");

                    b.HasIndex("codEstado");

                    b.ToTable("Region", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Estado", b =>
                {
                    b.HasOne("Core.Entities.Pais", "Pais")
                        .WithMany("Estados")
                        .HasForeignKey("codPais");

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("Core.Entities.Region", b =>
                {
                    b.HasOne("Core.Entities.Estado", "Estado")
                        .WithMany("Regiones")
                        .HasForeignKey("codEstado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("Core.Entities.Estado", b =>
                {
                    b.Navigation("Regiones");
                });

            modelBuilder.Entity("Core.Entities.Pais", b =>
                {
                    b.Navigation("Estados");
                });
#pragma warning restore 612, 618
        }
    }
}
