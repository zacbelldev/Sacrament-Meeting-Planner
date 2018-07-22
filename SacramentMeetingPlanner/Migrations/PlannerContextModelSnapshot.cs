﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Migrations
{
    [DbContext(typeof(PlannerContext))]
    partial class PlannerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Bishopric", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MemberID");

                    b.Property<int?>("NameID");

                    b.Property<bool?>("ReleasedFlag");

                    b.Property<int>("Role");

                    b.HasKey("ID");

                    b.HasIndex("NameID");

                    b.ToTable("Bishopric");
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Members", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MemberID");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Speakers");
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Plans", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClosingPrayerID");

                    b.Property<int?>("ConductingID");

                    b.Property<DateTime>("Date");

                    b.Property<int?>("OpeningPrayerID");

                    b.Property<int?>("OpeningSongID");

                    b.Property<int?>("OptIntermSongID");

                    b.Property<int?>("SacramentSongID");

                    b.HasKey("ID");

                    b.HasIndex("ClosingPrayerID");

                    b.HasIndex("ConductingID");

                    b.HasIndex("OpeningPrayerID");

                    b.HasIndex("OpeningSongID");

                    b.HasIndex("OptIntermSongID");

                    b.HasIndex("SacramentSongID");

                    b.ToTable("Plans");
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Songs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("Number");

                    b.HasKey("ID");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.SpeakToPlan", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PlansID");

                    b.Property<int?>("SpeakerNameID");

                    b.Property<int>("SpeakerPlacement");

                    b.Property<int>("SpeakerToPlanId");

                    b.Property<int?>("SubjectID");

                    b.HasKey("ID");

                    b.HasIndex("PlansID");

                    b.HasIndex("SpeakerNameID");

                    b.HasIndex("SubjectID");

                    b.ToTable("SpeakToPlan");
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Subjects", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SubjectName");

                    b.HasKey("ID");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Bishopric", b =>
                {
                    b.HasOne("SacramentMeetingPlanner.Models.Members", "Name")
                        .WithMany()
                        .HasForeignKey("NameID");
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Plans", b =>
                {
                    b.HasOne("SacramentMeetingPlanner.Models.Members", "ClosingPrayer")
                        .WithMany()
                        .HasForeignKey("ClosingPrayerID");

                    b.HasOne("SacramentMeetingPlanner.Models.Bishopric", "Conducting")
                        .WithMany()
                        .HasForeignKey("ConductingID");

                    b.HasOne("SacramentMeetingPlanner.Models.Members", "OpeningPrayer")
                        .WithMany()
                        .HasForeignKey("OpeningPrayerID");

                    b.HasOne("SacramentMeetingPlanner.Models.Songs", "OpeningSong")
                        .WithMany()
                        .HasForeignKey("OpeningSongID");

                    b.HasOne("SacramentMeetingPlanner.Models.Songs", "OptIntermSong")
                        .WithMany()
                        .HasForeignKey("OptIntermSongID");

                    b.HasOne("SacramentMeetingPlanner.Models.Songs", "SacramentSong")
                        .WithMany()
                        .HasForeignKey("SacramentSongID");
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.SpeakToPlan", b =>
                {
                    b.HasOne("SacramentMeetingPlanner.Models.Plans")
                        .WithMany("Speakers")
                        .HasForeignKey("PlansID");

                    b.HasOne("SacramentMeetingPlanner.Models.Members", "SpeakerName")
                        .WithMany("Plans")
                        .HasForeignKey("SpeakerNameID");

                    b.HasOne("SacramentMeetingPlanner.Models.Subjects", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectID");
                });
#pragma warning restore 612, 618
        }
    }
}
