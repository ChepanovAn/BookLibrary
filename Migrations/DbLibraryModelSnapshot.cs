﻿// <auto-generated />
using BookLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookLibrary.Migrations
{
    [DbContext(typeof(DbLibrary))]
    partial class DbLibraryModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookLibrary.BookLibrary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Autor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BookTitle")
                        .HasColumnType("int");

                    b.Property<int>("Rest")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("BookLibraries");
                });

            modelBuilder.Entity("BookLibrary.DataReader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DataReaders");
                });

            modelBuilder.Entity("BookLibrary.Reader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookLibraryId")
                        .HasColumnType("int");

                    b.Property<int>("DataReaderId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StorageTime")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BookLibraryId");

                    b.HasIndex("DataReaderId");

                    b.ToTable("Readers");
                });

            modelBuilder.Entity("BookLibrary.Reader", b =>
                {
                    b.HasOne("BookLibrary.BookLibrary", "BookLibrary")
                        .WithMany("Readers")
                        .HasForeignKey("BookLibraryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookLibrary.DataReader", "DataReader")
                        .WithMany("Readers")
                        .HasForeignKey("DataReaderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookLibrary");

                    b.Navigation("DataReader");
                });

            modelBuilder.Entity("BookLibrary.BookLibrary", b =>
                {
                    b.Navigation("Readers");
                });

            modelBuilder.Entity("BookLibrary.DataReader", b =>
                {
                    b.Navigation("Readers");
                });
#pragma warning restore 612, 618
        }
    }
}
