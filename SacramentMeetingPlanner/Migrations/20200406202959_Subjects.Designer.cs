﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SacramentMeetingPlanner.Data;

namespace SacramentMeetingPlanner.Migrations
{
    [DbContext(typeof(SacramentMeetingPlannerContext))]
    [Migration("20200406202959_Subjects")]
    partial class Subjects
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Meeting", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("EssentialAnnouncements")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstHymn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstMessagePerson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstPrayer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastHymn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastPrayer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Leading")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MusicDirector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pianist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Presiding")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SacramentHymn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondMessagePerson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Speakersubjects")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StakeAuthority")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThirdMessagePerson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WardAnnouncements")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Meeting");
                });
#pragma warning restore 612, 618
        }
    }
}
