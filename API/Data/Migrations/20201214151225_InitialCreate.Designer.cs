﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201214151225_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-rc.2.20475.6");

            modelBuilder.Entity("API.Entities.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Discount")
                        .HasColumnType("TEXT");

                    b.Property<string>("Line")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("TicketPrice")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("TransportCardId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("destination")
                        .HasColumnType("TEXT");

                    b.Property<string>("origin")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("TransportCardId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("API.Entities.TransportCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardType")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Load")
                        .HasColumnType("TEXT");

                    b.Property<int>("MyProperty")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("TransportCard");
                });

            modelBuilder.Entity("API.Entities.Transaction", b =>
                {
                    b.HasOne("API.Entities.TransportCard", "TransportCard")
                        .WithMany("Transactions")
                        .HasForeignKey("TransportCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TransportCard");
                });

            modelBuilder.Entity("API.Entities.TransportCard", b =>
                {
                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
