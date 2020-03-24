﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(DataDbContext))]
    partial class DataDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data.Models.FrameModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Frames");

                    b.HasData(
                        new
                        {
                            Id = new Guid("abebcd43-5718-43c4-aa3d-6c4bc7153b37"),
                            Name = "Standart"
                        },
                        new
                        {
                            Id = new Guid("d83be8ac-b1e9-4d5b-be34-ecc207a9cc34"),
                            Name = "Original"
                        });
                });

            modelBuilder.Entity("Data.Models.MaterialModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FrameModelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FrameModelId");

                    b.ToTable("Materials");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c505f2b7-01ec-4922-b062-ab8f3057b8b1"),
                            FrameModelId = new Guid("abebcd43-5718-43c4-aa3d-6c4bc7153b37"),
                            Name = "Wood",
                            Quantity = 21
                        },
                        new
                        {
                            Id = new Guid("a0085ad9-552c-4dc5-8de1-6e0e9a2e83c7"),
                            FrameModelId = new Guid("abebcd43-5718-43c4-aa3d-6c4bc7153b37"),
                            Name = "Iron",
                            Quantity = 18
                        },
                        new
                        {
                            Id = new Guid("2ce1e9ef-98fb-4c07-9016-052fba27143f"),
                            FrameModelId = new Guid("d83be8ac-b1e9-4d5b-be34-ecc207a9cc34"),
                            Name = "Black paint",
                            Quantity = 14
                        },
                        new
                        {
                            Id = new Guid("7506ae84-79d5-45d8-952c-f3807bf19ae0"),
                            FrameModelId = new Guid("d83be8ac-b1e9-4d5b-be34-ecc207a9cc34"),
                            Name = "Yellow paint",
                            Quantity = 3
                        });
                });

            modelBuilder.Entity("Data.Models.MaterialModel", b =>
                {
                    b.HasOne("Data.Models.FrameModel", "FrameModel")
                        .WithMany("Materials")
                        .HasForeignKey("FrameModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
