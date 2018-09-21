﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectInfo.API.Entities;

namespace ProjectInfo.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20180921102354_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjectInfo.API.Entities.AuthorizedPlanViewProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("ppl_Code");

                    b.HasKey("Id");

                    b.ToTable("AuthorizedPlanViewProjects");
                });

            modelBuilder.Entity("ProjectInfo.API.Entities.PlanViewProject", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(200);

                    b.Property<Guid>("ProjectGuid");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("ppl_Code");

                    b.HasKey("Id");

                    b.HasIndex("ProjectGuid");

                    b.ToTable("PlanViewProjects");
                });

            modelBuilder.Entity("ProjectInfo.API.Entities.Project", b =>
                {
                    b.Property<Guid>("ProjectGuid");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ProjectGuid");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("ProjectInfo.API.Entities.PlanViewProject", b =>
                {
                    b.HasOne("ProjectInfo.API.Entities.Project", "Project")
                        .WithMany("PlanViewProjects")
                        .HasForeignKey("ProjectGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
