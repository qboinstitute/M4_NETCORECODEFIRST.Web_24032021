﻿// <auto-generated />
using System;
using M4_NETCORECODEFIRST.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace M4_NETCORECODEFIRST.Web.Migrations
{
    [DbContext(typeof(EurocopaDBContext))]
    [Migration("20210325023046_Player-Email")]
    partial class PlayerEmail
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("M4_NETCORECODEFIRST.Web.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DoB")
                        .HasColumnType("date");

                    b.Property<int>("Dorsal")
                        .HasColumnType("int");

                    b.Property<string>("EmailPlayer")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("SoccerPositionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SoccerPositionId");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("M4_NETCORECODEFIRST.Web.Models.SoccerPosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("SoccerPosition");
                });

            modelBuilder.Entity("M4_NETCORECODEFIRST.Web.Models.Player", b =>
                {
                    b.HasOne("M4_NETCORECODEFIRST.Web.Models.SoccerPosition", "SoccerPosition")
                        .WithMany("Player")
                        .HasForeignKey("SoccerPositionId");

                    b.Navigation("SoccerPosition");
                });

            modelBuilder.Entity("M4_NETCORECODEFIRST.Web.Models.SoccerPosition", b =>
                {
                    b.Navigation("Player");
                });
#pragma warning restore 612, 618
        }
    }
}
