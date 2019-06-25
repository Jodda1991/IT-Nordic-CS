﻿// <auto-generated />
using System;
using HW_34.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HW_34.Migrations
{
    [DbContext(typeof(СorrespondenceContext))]
    [Migration("20190625090808_Correspondence2")]
    partial class Correspondence2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HW_34.Domain.Adress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Adresses");
                });

            modelBuilder.Entity("HW_34.Domain.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("HW_34.Domain.Contractor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("PositionId");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.ToTable("Contractors");
                });

            modelBuilder.Entity("HW_34.Domain.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("HW_34.Domain.PostalItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("NumberOfPages");

                    b.HasKey("Id");

                    b.ToTable("PostalItems");
                });

            modelBuilder.Entity("HW_34.Domain.SendingStatus", b =>
                {
                    b.Property<DateTimeOffset>("UpdateStatusDateTime");

                    b.Property<int?>("PostalItemId");

                    b.Property<int?>("ReceivingAddressId");

                    b.Property<int?>("ReceivingContractorId");

                    b.Property<int?>("SendingAddressId");

                    b.Property<int?>("SendingContractorId");

                    b.Property<int?>("StatusId");

                    b.HasKey("UpdateStatusDateTime");

                    b.HasIndex("PostalItemId");

                    b.HasIndex("ReceivingAddressId");

                    b.HasIndex("ReceivingContractorId");

                    b.HasIndex("SendingAddressId");

                    b.HasIndex("SendingContractorId");

                    b.HasIndex("StatusId");

                    b.ToTable("SendingStatuses");
                });

            modelBuilder.Entity("HW_34.Domain.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("HW_34.Domain.Adress", b =>
                {
                    b.HasOne("HW_34.Domain.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HW_34.Domain.Contractor", b =>
                {
                    b.HasOne("HW_34.Domain.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HW_34.Domain.SendingStatus", b =>
                {
                    b.HasOne("HW_34.Domain.PostalItem", "PostalItem")
                        .WithMany()
                        .HasForeignKey("PostalItemId");

                    b.HasOne("HW_34.Domain.Adress", "ReceivingAddress")
                        .WithMany()
                        .HasForeignKey("ReceivingAddressId");

                    b.HasOne("HW_34.Domain.Contractor", "ReceivingContractor")
                        .WithMany()
                        .HasForeignKey("ReceivingContractorId");

                    b.HasOne("HW_34.Domain.Adress", "SendingAddress")
                        .WithMany()
                        .HasForeignKey("SendingAddressId");

                    b.HasOne("HW_34.Domain.Contractor", "SendingContractor")
                        .WithMany()
                        .HasForeignKey("SendingContractorId");

                    b.HasOne("HW_34.Domain.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");
                });
#pragma warning restore 612, 618
        }
    }
}
