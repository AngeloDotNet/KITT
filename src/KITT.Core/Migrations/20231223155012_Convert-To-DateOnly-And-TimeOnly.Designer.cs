﻿// <auto-generated />
using System;
using KITT.Core.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KITT.Core.Migrations
{
    [DbContext(typeof(KittDbContext))]
    [Migration("20231223155012_Convert-To-DateOnly-And-TimeOnly")]
    partial class ConvertToDateOnlyAndTimeOnly
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KITT.Core.Models.Content", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Abstract")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("PublicationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.HasKey("Id");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.HasIndex("Title");

                    b.HasIndex("UserId");

                    b.ToTable("KITT_Contents", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("KITT.Core.Models.Expense", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("ExpenseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Method")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentInfo")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("TotalAmount")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.ToTable("KITT_Expenses", (string)null);
                });

            modelBuilder.Entity("KITT.Core.Models.Proposal", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AuthorNickname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Moderating");

                    b.Property<DateTime>("SubmittedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("KITT_Proposals", (string)null);
                });

            modelBuilder.Entity("KITT.Core.Models.Rating", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("NumberOfDislikes")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfLikes")
                        .HasColumnType("int");

                    b.Property<string>("PageUrl")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("KITT_Ratings", (string)null);
                });

            modelBuilder.Entity("KITT.Core.Models.Settings", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TwitchChannel")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.HasKey("Id");

                    b.HasIndex("TwitchChannel");

                    b.HasIndex("UserId");

                    b.ToTable("KITT_Settings", (string)null);
                });

            modelBuilder.Entity("KITT.Core.Models.StreamingStats", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("StreamingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Subscribers")
                        .HasColumnType("int");

                    b.Property<int>("UserJoinedNumber")
                        .HasColumnType("int");

                    b.Property<int>("UserLeftNumber")
                        .HasColumnType("int");

                    b.Property<int>("Viewers")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StreamingId");

                    b.ToTable("KITT_StreamingStats", (string)null);
                });

            modelBuilder.Entity("KITT.Core.Models.Streaming", b =>
                {
                    b.HasBaseType("KITT.Core.Models.Content");

                    b.Property<TimeOnly>("EndingTime")
                        .HasColumnType("time");

                    b.Property<string>("HostingChannelUrl")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateOnly>("ScheduleDate")
                        .HasColumnType("date");

                    b.Property<TimeOnly>("StartingTime")
                        .HasColumnType("time");

                    b.Property<string>("TwitchChannel")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("YouTubeVideoUrl")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasIndex("TwitchChannel");

                    b.ToTable("KITT_Streamings", (string)null);
                });

            modelBuilder.Entity("KITT.Core.Models.Content", b =>
                {
                    b.OwnsOne("KITT.Core.Models.Content+SeoData", "Seo", b1 =>
                        {
                            b1.Property<Guid>("ContentId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Description")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Keywords")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Title")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("ContentId");

                            b1.ToTable("KITT_Contents");

                            b1.WithOwner()
                                .HasForeignKey("ContentId");
                        });

                    b.Navigation("Seo");
                });

            modelBuilder.Entity("KITT.Core.Models.StreamingStats", b =>
                {
                    b.HasOne("KITT.Core.Models.Streaming", "Streaming")
                        .WithMany()
                        .HasForeignKey("StreamingId");

                    b.Navigation("Streaming");
                });

            modelBuilder.Entity("KITT.Core.Models.Streaming", b =>
                {
                    b.HasOne("KITT.Core.Models.Content", null)
                        .WithOne()
                        .HasForeignKey("KITT.Core.Models.Streaming", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
