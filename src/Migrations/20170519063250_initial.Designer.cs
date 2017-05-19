using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TimeTracker051617.Models;

namespace TimeTracker051617.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170519063250_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("TimeTracker051617.Models.TimeSlice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<string>("DataSource");

                    b.Property<TimeSpan>("Duration");

                    b.Property<DateTime>("Start");

                    b.Property<string>("SubCategory");

                    b.HasKey("Id");

                    b.ToTable("TimeSlices");
                });
        }
    }
}
