﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProvaWeek6.EF.Repository;

namespace ProvaWeek6.Migrations
{
    [DbContext(typeof(PolizzaContext))]
    partial class PolizzaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProvaWeek6.Core.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodiceFiscale")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("Cognome")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(30)");

                    b.HasKey("ClienteId");

                    b.ToTable("Clienti");
                });

            modelBuilder.Entity("ProvaWeek6.Core.Models.Polizza", b =>
                {
                    b.Property<int>("PolizzaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataScadenza")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumeroPolizza")
                        .HasColumnType("int");

                    b.Property<decimal>("RataMensile")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("PolizzaId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Polizze");
                });

            modelBuilder.Entity("ProvaWeek6.Core.Models.Polizza", b =>
                {
                    b.HasOne("ProvaWeek6.Core.Models.Cliente", "Cliente")
                        .WithMany("Polizze")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("ProvaWeek6.Core.Models.Cliente", b =>
                {
                    b.Navigation("Polizze");
                });
#pragma warning restore 612, 618
        }
    }
}
