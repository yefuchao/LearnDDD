﻿// <auto-generated />
using DDDExample.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DDDExample.Migrations
{
    [DbContext(typeof(OrderContext))]
    [Migration("20200416034800_add_distributor")]
    partial class add_distributor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("Relational:Sequence:ordering.orderseq", "'orderseq', 'ordering', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DDDExample.Entity.Distributor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Distributor");
                });

            modelBuilder.Entity("DDDExample.Entity.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:HiLoSequenceName", "orderseq")
                        .HasAnnotation("SqlServer:HiLoSequenceSchema", "ordering")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.HasKey("Id");

                    b.ToTable("orders","ordering");
                });

            modelBuilder.Entity("DDDExample.Entity.Distributor", b =>
                {
                    b.OwnsMany("DDDExample.Entity.StreetAddress", "ShippingAddress", b1 =>
                        {
                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("City")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("OwnerId")
                                .HasColumnType("int");

                            b1.Property<string>("Street")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("Id");

                            b1.HasIndex("OwnerId");

                            b1.ToTable("StreetAddress");

                            b1.WithOwner()
                                .HasForeignKey("OwnerId");
                        });
                });

            modelBuilder.Entity("DDDExample.Entity.Order", b =>
                {
                    b.OwnsOne("DDDExample.Entity.Address", "Address", b1 =>
                        {
                            b1.Property<int>("OrderId")
                                .HasColumnType("int");

                            b1.Property<string>("City")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Country")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("State")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Street")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("ZipCode")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("OrderId");

                            b1.ToTable("orders");

                            b1.WithOwner()
                                .HasForeignKey("OrderId");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}