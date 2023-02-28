﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleBookingSystem.DataAccess.EntityFramework;

#nullable disable

namespace SimpleBookingSystem.DataAccess.Migrations
{
    [DbContext(typeof(SimpleBookingSystemDbContext))]
    partial class SimpleBookingSystemDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("SimpleBookingSystem.Domain.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookedQuantity")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateFrom")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateTo")
                        .HasColumnType("TEXT");

                    b.Property<int>("ResourceId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ResourceId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("SimpleBookingSystem.Domain.Models.Resource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Resources");
                });

            modelBuilder.Entity("SimpleBookingSystem.Domain.Models.Booking", b =>
                {
                    b.HasOne("SimpleBookingSystem.Domain.Models.Resource", "Resource")
                        .WithMany()
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Resource");
                });
#pragma warning restore 612, 618
        }
    }
}
