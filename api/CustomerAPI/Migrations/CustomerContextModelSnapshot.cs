﻿// <auto-generated />
using System;
using CustomerAPI.DBContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CustomerAPI.Migrations
{
    [DbContext(typeof(CustomerContext))]
    partial class CustomerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CustomerAPI.Entities.Address", b =>
                {
                    b.Property<Guid>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int")
                        .HasMaxLength(5);

                    b.HasKey("AddressId");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            AddressId = new Guid("78cebe6c-6dac-403e-82bd-43f3142ea805"),
                            Country = "Sweden",
                            CustomerId = new Guid("e2c46906-2ea4-4672-a81f-bd69890c9b16"),
                            ZipCode = 15132
                        },
                        new
                        {
                            AddressId = new Guid("a02b03b7-36cb-4839-911c-f782bb3009e9"),
                            Country = "Denmark",
                            CustomerId = new Guid("21d937d1-f020-4e4f-9f26-add9801b6e75"),
                            ZipCode = 4268
                        },
                        new
                        {
                            AddressId = new Guid("5c3ac12f-ec83-449e-a37e-de7442cde7da"),
                            Country = "Norway",
                            CustomerId = new Guid("5cee819a-f78d-49a9-866e-b69aba44c4f4"),
                            ZipCode = 30415
                        },
                        new
                        {
                            AddressId = new Guid("b84178a0-b0ff-4721-96cc-5d271d93f6b9"),
                            Country = "Finland",
                            CustomerId = new Guid("fbf6dc01-93f9-4772-891f-46e5a79d6e2a"),
                            ZipCode = 55603
                        });
                });

            modelBuilder.Entity("CustomerAPI.Entities.Country", b =>
                {
                    b.Property<Guid>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CountryCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = new Guid("991e0c2f-a768-40b9-9eaa-b7c31eb3fcc4"),
                            CountryCode = "+46",
                            CountryName = "Sweden"
                        },
                        new
                        {
                            CountryId = new Guid("ba2dc307-32bf-4d24-8cd2-45f070975889"),
                            CountryCode = "+45",
                            CountryName = "Denmark"
                        },
                        new
                        {
                            CountryId = new Guid("0f72123d-6095-490e-a051-6bb7fbcbc010"),
                            CountryCode = "+47",
                            CountryName = "Norway"
                        },
                        new
                        {
                            CountryId = new Guid("01d942ed-522e-4e5f-908b-cae029c820d7"),
                            CountryCode = "+358",
                            CountryName = "Finland"
                        });
                });

            modelBuilder.Entity("CustomerAPI.Entities.Customer", b =>
                {
                    b.Property<Guid>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = new Guid("e2c46906-2ea4-4672-a81f-bd69890c9b16"),
                            Email = "user1@domain.com",
                            PersonalNumber = "199205251045",
                            PhoneNumber = "+467455535"
                        },
                        new
                        {
                            CustomerId = new Guid("21d937d1-f020-4e4f-9f26-add9801b6e75"),
                            Email = "user2@domain.com",
                            PersonalNumber = "199307121428",
                            PhoneNumber = "+4560555269"
                        },
                        new
                        {
                            CustomerId = new Guid("5cee819a-f78d-49a9-866e-b69aba44c4f4"),
                            Email = "user3@domain.com",
                            PersonalNumber = "198904208493",
                            PhoneNumber = "+4795552843"
                        },
                        new
                        {
                            CustomerId = new Guid("fbf6dc01-93f9-4772-891f-46e5a79d6e2a"),
                            Email = "user4@domain.com",
                            PersonalNumber = "198602182748",
                            PhoneNumber = "+3585005557352"
                        });
                });

            modelBuilder.Entity("CustomerAPI.Entities.Address", b =>
                {
                    b.HasOne("CustomerAPI.Entities.Customer", null)
                        .WithOne("Address")
                        .HasForeignKey("CustomerAPI.Entities.Address", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}