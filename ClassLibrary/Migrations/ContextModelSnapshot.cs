﻿// <auto-generated />
using ClassLibrary.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClassLibrary.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ClassLibrary.Models.Alkalmazottak", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Bevetel")
                        .HasColumnType("int");

                    b.Property<int>("Kor")
                        .HasColumnType("int");

                    b.Property<string>("Munka")
                        .HasColumnType("longtext");

                    b.Property<string>("Nev")
                        .HasColumnType("longtext");

                    b.Property<string>("Varos")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Alkalmazottak");
                });
#pragma warning restore 612, 618
        }
    }
}
