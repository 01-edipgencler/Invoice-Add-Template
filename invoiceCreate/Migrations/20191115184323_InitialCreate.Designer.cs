﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using invoiceCreate.Models;

namespace invoiceCreate.Migrations
{
    [DbContext(typeof(CustomerContext))]
    [Migration("20191115184323_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("invoiceCreate.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress");

                    b.Property<int?>("InvoiceId");

                    b.Property<string>("Name");

                    b.Property<int>("Phone");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("invoiceCreate.Models.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("InvoiceDate");

                    b.Property<string>("InvoiceNo");

                    b.Property<string>("ProductName");

                    b.Property<int>("ProductPriceAmount");

                    b.Property<int>("ProductQuantity");

                    b.Property<int>("ProductSubAmount");

                    b.Property<int>("ProductTotalAmount");

                    b.HasKey("Id");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("invoiceCreate.Models.Customer", b =>
                {
                    b.HasOne("invoiceCreate.Models.Invoice", "Invoice")
                        .WithMany("Customer")
                        .HasForeignKey("InvoiceId");
                });
#pragma warning restore 612, 618
        }
    }
}
