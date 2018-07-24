﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Migrations
{
    [DbContext(typeof(PlannerContext))]
    [Migration("20180724032713_Yolotwo")]
    partial class Yolotwo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Bishopric", b =>
                {
                    b.Property<int>("BishopricID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MemberID");

                    b.Property<bool>("ReleasedFlag");

                    b.Property<int>("RoleID");

                    b.HasKey("BishopricID");

                    b.HasIndex("MemberID");

                    b.HasIndex("RoleID");

                    b.ToTable("Bishopric");
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Member", b =>
                {
                    b.Property<int>("MemberID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MemberName");

                    b.HasKey("MemberID");

                    b.ToTable("Member");
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Plans", b =>
                {
                    b.Property<int>("PlansID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("PlanDate");

                    b.Property<int>("RoleID");

                    b.HasKey("PlansID");

                    b.HasIndex("RoleID");

                    b.ToTable("Plans");
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Prayer", b =>
                {
                    b.Property<int>("PrayerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MemberID");

                    b.Property<int>("PrayerTypeID");

                    b.HasKey("PrayerID");

                    b.HasIndex("MemberID");

                    b.HasIndex("PrayerTypeID");

                    b.ToTable("Prayer");
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.PrayerToPlan", b =>
                {
                    b.Property<int>("PrayerToPlanID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MemberID");

                    b.Property<int?>("PlansID");

                    b.Property<int?>("PrayerID");

                    b.Property<int>("PrayerTypeID");

                    b.HasKey("PrayerToPlanID");

                    b.HasIndex("MemberID");

                    b.HasIndex("PlansID");

                    b.HasIndex("PrayerID");

                    b.HasIndex("PrayerTypeID");

                    b.ToTable("PrayerToPlan");
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.PrayerType", b =>
                {
                    b.Property<int>("PrayerTypeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PrayerTypeName");

                    b.HasKey("PrayerTypeID");

                    b.ToTable("PrayerType");
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleTypeName");

                    b.HasKey("RoleID");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Song", b =>
                {
                    b.Property<int>("SongID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SongName");

                    b.Property<int>("SongNumber");

                    b.HasKey("SongID");

                    b.ToTable("Song");
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.SongAssignment", b =>
                {
                    b.Property<int>("SongAssignmentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SongID");

                    b.Property<int>("SongTypeID");

                    b.HasKey("SongAssignmentID");

                    b.HasIndex("SongID");

                    b.HasIndex("SongTypeID");

                    b.ToTable("SongAssignment");
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.SongToPlan", b =>
                {
                    b.Property<int>("SongToPlanID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PlansID");

                    b.Property<int>("SongAssignmentID");

                    b.HasKey("SongToPlanID");

                    b.HasIndex("PlansID");

                    b.HasIndex("SongAssignmentID");

                    b.ToTable("SongToPlan");
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.SongType", b =>
                {
                    b.Property<int>("SongTypeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SongTypeName");

                    b.HasKey("SongTypeID");

                    b.ToTable("SongType");
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.SpeakAssignment", b =>
                {
                    b.Property<int>("SpeakAssignmentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MemberID");

                    b.Property<int>("SpeakerPlacement");

                    b.Property<int>("SubjectID");

                    b.HasKey("SpeakAssignmentID");

                    b.HasIndex("MemberID");

                    b.HasIndex("SubjectID");

                    b.ToTable("SpeakAssignment");
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.SpeakToPlan", b =>
                {
                    b.Property<int>("SpeakToPlanID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PlansID");

                    b.Property<int?>("SpeakAssignmentID");

                    b.HasKey("SpeakToPlanID");

                    b.HasIndex("PlansID");

                    b.HasIndex("SpeakAssignmentID");

                    b.ToTable("SpeakToPlan");
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Subject", b =>
                {
                    b.Property<int>("SubjectID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SubjectName");

                    b.HasKey("SubjectID");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Bishopric", b =>
                {
                    b.HasOne("SacramentMeetingPlanner.Models.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SacramentMeetingPlanner.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Plans", b =>
                {
                    b.HasOne("SacramentMeetingPlanner.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Prayer", b =>
                {
                    b.HasOne("SacramentMeetingPlanner.Models.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SacramentMeetingPlanner.Models.PrayerType", "PrayerType")
                        .WithMany()
                        .HasForeignKey("PrayerTypeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.PrayerToPlan", b =>
                {
                    b.HasOne("SacramentMeetingPlanner.Models.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SacramentMeetingPlanner.Models.Plans", "Plans")
                        .WithMany("PrayerToPlan")
                        .HasForeignKey("PlansID");

                    b.HasOne("SacramentMeetingPlanner.Models.Prayer")
                        .WithMany("PrayerToPlan")
                        .HasForeignKey("PrayerID");

                    b.HasOne("SacramentMeetingPlanner.Models.PrayerType", "PrayerType")
                        .WithMany()
                        .HasForeignKey("PrayerTypeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.SongAssignment", b =>
                {
                    b.HasOne("SacramentMeetingPlanner.Models.Song", "Song")
                        .WithMany()
                        .HasForeignKey("SongID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SacramentMeetingPlanner.Models.SongType", "SongType")
                        .WithMany()
                        .HasForeignKey("SongTypeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.SongToPlan", b =>
                {
                    b.HasOne("SacramentMeetingPlanner.Models.Plans", "Plans")
                        .WithMany("SongToPlan")
                        .HasForeignKey("PlansID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SacramentMeetingPlanner.Models.SongAssignment", "SongAssignment")
                        .WithMany("SongToPlan")
                        .HasForeignKey("SongAssignmentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.SpeakAssignment", b =>
                {
                    b.HasOne("SacramentMeetingPlanner.Models.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SacramentMeetingPlanner.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.SpeakToPlan", b =>
                {
                    b.HasOne("SacramentMeetingPlanner.Models.Plans", "Plans")
                        .WithMany("SpeakToPlan")
                        .HasForeignKey("PlansID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SacramentMeetingPlanner.Models.SpeakAssignment", "SpeakAssignment")
                        .WithMany("SpeakToPlan")
                        .HasForeignKey("SpeakAssignmentID");
                });
#pragma warning restore 612, 618
        }
    }
}