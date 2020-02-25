﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ordering.Infrastructure;

namespace Ordering.Api.Infrastructure.Migrations
{
    [DbContext(typeof(OrderContext))]
    [Migration("20200224182045_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("Ordering.Domain.Models.OrderAggregate.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("varchar(30)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("varchar(36)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Ordering.Domain.Models.ProductAggregate.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(6, 2)");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Ordering.Domain.Models.OrderAggregate.Order", b =>
                {
                    b.HasOne("Ordering.Domain.Models.ProductAggregate.Product", "OrderProduct")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
