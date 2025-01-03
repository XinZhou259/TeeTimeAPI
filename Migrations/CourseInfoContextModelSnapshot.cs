﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeeTimeAPI.DbContexts;

#nullable disable

namespace TeeTimeAPI.Migrations
{
    [DbContext(typeof(CourseInfoContext))]
    partial class CourseInfoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("TeeTimeAPI.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("CourseURL")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseName = "The Links at Terranea",
                            CourseURL = "https://www.terranea.com/golf"
                        },
                        new
                        {
                            Id = 2,
                            CourseName = "Trump National Golf Club",
                            CourseURL = "https://www.trumpnationallosangeles.com/"
                        },
                        new
                        {
                            Id = 3,
                            CourseName = "Northview Golf Club",
                            CourseURL = "https://www.northviewgolfclub.com/"
                        },
                        new
                        {
                            Id = 4,
                            CourseName = "Red Woods Golf Club",
                            CourseURL = "https://www.redwoodsgolfclub.com/"
                        },
                        new
                        {
                            Id = 5,
                            CourseName = "Hazelmere Golf Club",
                            CourseURL = "https://www.hazelmeregolfclub.com/"
                        },
                        new
                        {
                            Id = 6,
                            CourseName = "Morgan Creek Golf Club",
                            CourseURL = "https://www.morgancreekgolfclub.com/"
                        });
                });

            modelBuilder.Entity("TeeTimeAPI.Entities.TeeTime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CourseId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("NumberOfPlayer")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<TimeSpan>("Time")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("TeeTimes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            Date = new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 4,
                            Price = 200.0,
                            Time = new TimeSpan(0, 10, 30, 0, 0)
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 1,
                            Date = new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 3,
                            Price = 200.0,
                            Time = new TimeSpan(0, 10, 50, 0, 0)
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 1,
                            Date = new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 4,
                            Price = 180.0,
                            Time = new TimeSpan(0, 12, 30, 0, 0)
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 1,
                            Date = new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 4,
                            Price = 180.0,
                            Time = new TimeSpan(0, 12, 40, 0, 0)
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 1,
                            Date = new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 3,
                            Price = 150.0,
                            Time = new TimeSpan(0, 14, 10, 0, 0)
                        },
                        new
                        {
                            Id = 6,
                            CourseId = 1,
                            Date = new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 4,
                            Price = 150.0,
                            Time = new TimeSpan(0, 14, 30, 0, 0)
                        },
                        new
                        {
                            Id = 7,
                            CourseId = 2,
                            Date = new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 4,
                            Price = 150.0,
                            Time = new TimeSpan(0, 11, 20, 0, 0)
                        },
                        new
                        {
                            Id = 8,
                            CourseId = 2,
                            Date = new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 4,
                            Price = 120.0,
                            Time = new TimeSpan(0, 14, 0, 0, 0)
                        },
                        new
                        {
                            Id = 9,
                            CourseId = 2,
                            Date = new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 2,
                            Price = 100.0,
                            Time = new TimeSpan(0, 15, 50, 0, 0)
                        },
                        new
                        {
                            Id = 10,
                            CourseId = 2,
                            Date = new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 4,
                            Price = 150.0,
                            Time = new TimeSpan(0, 11, 40, 0, 0)
                        },
                        new
                        {
                            Id = 11,
                            CourseId = 2,
                            Date = new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 3,
                            Price = 120.0,
                            Time = new TimeSpan(0, 14, 20, 0, 0)
                        },
                        new
                        {
                            Id = 12,
                            CourseId = 2,
                            Date = new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 4,
                            Price = 100.0,
                            Time = new TimeSpan(0, 16, 0, 0, 0)
                        },
                        new
                        {
                            Id = 13,
                            CourseId = 3,
                            Date = new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 4,
                            Price = 200.0,
                            Time = new TimeSpan(0, 10, 20, 0, 0)
                        },
                        new
                        {
                            Id = 14,
                            CourseId = 3,
                            Date = new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 4,
                            Price = 180.0,
                            Time = new TimeSpan(0, 13, 30, 0, 0)
                        },
                        new
                        {
                            Id = 15,
                            CourseId = 3,
                            Date = new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 2,
                            Price = 130.0,
                            Time = new TimeSpan(0, 15, 40, 0, 0)
                        },
                        new
                        {
                            Id = 16,
                            CourseId = 3,
                            Date = new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 4,
                            Price = 200.0,
                            Time = new TimeSpan(0, 10, 40, 0, 0)
                        },
                        new
                        {
                            Id = 17,
                            CourseId = 3,
                            Date = new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 4,
                            Price = 180.0,
                            Time = new TimeSpan(0, 14, 0, 0, 0)
                        },
                        new
                        {
                            Id = 18,
                            CourseId = 3,
                            Date = new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 4,
                            Price = 130.0,
                            Time = new TimeSpan(0, 16, 0, 0, 0)
                        },
                        new
                        {
                            Id = 19,
                            CourseId = 1,
                            Date = new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 4,
                            Price = 200.0,
                            Time = new TimeSpan(0, 10, 30, 0, 0)
                        },
                        new
                        {
                            Id = 20,
                            CourseId = 1,
                            Date = new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 3,
                            Price = 200.0,
                            Time = new TimeSpan(0, 10, 50, 0, 0)
                        },
                        new
                        {
                            Id = 21,
                            CourseId = 1,
                            Date = new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 4,
                            Price = 180.0,
                            Time = new TimeSpan(0, 12, 30, 0, 0)
                        },
                        new
                        {
                            Id = 22,
                            CourseId = 1,
                            Date = new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 4,
                            Price = 200.0,
                            Time = new TimeSpan(0, 10, 40, 0, 0)
                        },
                        new
                        {
                            Id = 23,
                            CourseId = 1,
                            Date = new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 4,
                            Price = 200.0,
                            Time = new TimeSpan(0, 11, 20, 0, 0)
                        },
                        new
                        {
                            Id = 24,
                            CourseId = 1,
                            Date = new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 2,
                            Price = 180.0,
                            Time = new TimeSpan(0, 12, 40, 0, 0)
                        },
                        new
                        {
                            Id = 25,
                            CourseId = 2,
                            Date = new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 4,
                            Price = 150.0,
                            Time = new TimeSpan(0, 11, 20, 0, 0)
                        },
                        new
                        {
                            Id = 26,
                            CourseId = 2,
                            Date = new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 4,
                            Price = 120.0,
                            Time = new TimeSpan(0, 14, 0, 0, 0)
                        },
                        new
                        {
                            Id = 27,
                            CourseId = 2,
                            Date = new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 2,
                            Price = 100.0,
                            Time = new TimeSpan(0, 15, 50, 0, 0)
                        },
                        new
                        {
                            Id = 28,
                            CourseId = 2,
                            Date = new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 4,
                            Price = 150.0,
                            Time = new TimeSpan(0, 12, 0, 0, 0)
                        },
                        new
                        {
                            Id = 29,
                            CourseId = 2,
                            Date = new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 4,
                            Price = 120.0,
                            Time = new TimeSpan(0, 14, 20, 0, 0)
                        },
                        new
                        {
                            Id = 30,
                            CourseId = 2,
                            Date = new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 2,
                            Price = 100.0,
                            Time = new TimeSpan(0, 16, 10, 0, 0)
                        },
                        new
                        {
                            Id = 31,
                            CourseId = 3,
                            Date = new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 4,
                            Price = 200.0,
                            Time = new TimeSpan(0, 10, 20, 0, 0)
                        },
                        new
                        {
                            Id = 32,
                            CourseId = 3,
                            Date = new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 4,
                            Price = 150.0,
                            Time = new TimeSpan(0, 13, 30, 0, 0)
                        },
                        new
                        {
                            Id = 33,
                            CourseId = 3,
                            Date = new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 2,
                            Price = 130.0,
                            Time = new TimeSpan(0, 15, 40, 0, 0)
                        },
                        new
                        {
                            Id = 34,
                            CourseId = 3,
                            Date = new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 3,
                            Price = 200.0,
                            Time = new TimeSpan(0, 10, 30, 0, 0)
                        },
                        new
                        {
                            Id = 35,
                            CourseId = 3,
                            Date = new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 4,
                            Price = 150.0,
                            Time = new TimeSpan(0, 13, 10, 0, 0)
                        },
                        new
                        {
                            Id = 36,
                            CourseId = 3,
                            Date = new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfPlayer = 1,
                            Price = 130.0,
                            Time = new TimeSpan(0, 16, 10, 0, 0)
                        });
                });

            modelBuilder.Entity("TeeTimeAPI.Entities.TeeTime", b =>
                {
                    b.HasOne("TeeTimeAPI.Entities.Course", "Course")
                        .WithMany("TeeTimes")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("TeeTimeAPI.Entities.Course", b =>
                {
                    b.Navigation("TeeTimes");
                });
#pragma warning restore 612, 618
        }
    }
}
