﻿// <auto-generated />
using System;
using EFCoreChess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreChess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCoreChess.Entities.ChessGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BlackPlayerId")
                        .HasColumnType("int");

                    b.Property<int?>("ChessTournamentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<int>("WhitePlayerId")
                        .HasColumnType("int");

                    b.Property<int>("WinnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BlackPlayerId");

                    b.HasIndex("ChessTournamentId");

                    b.HasIndex("WhitePlayerId");

                    b.ToTable("ChessGames");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BlackPlayerId = 3,
                            Date = new DateTime(2012, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WhitePlayerId = 1,
                            WinnerId = 1
                        },
                        new
                        {
                            Id = 2,
                            BlackPlayerId = 1,
                            Date = new DateTime(2013, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WhitePlayerId = 3,
                            WinnerId = 3
                        },
                        new
                        {
                            Id = 3,
                            BlackPlayerId = 4,
                            Date = new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WhitePlayerId = 3,
                            WinnerId = 3
                        },
                        new
                        {
                            Id = 4,
                            BlackPlayerId = 1,
                            Date = new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WhitePlayerId = 2,
                            WinnerId = 1
                        },
                        new
                        {
                            Id = 5,
                            BlackPlayerId = 3,
                            ChessTournamentId = 1,
                            Date = new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WhitePlayerId = 2,
                            WinnerId = 2
                        },
                        new
                        {
                            Id = 6,
                            BlackPlayerId = 2,
                            ChessTournamentId = 1,
                            Date = new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WhitePlayerId = 1,
                            WinnerId = 1
                        },
                        new
                        {
                            Id = 7,
                            BlackPlayerId = 2,
                            ChessTournamentId = 1,
                            Date = new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WhitePlayerId = 3,
                            WinnerId = 3
                        },
                        new
                        {
                            Id = 8,
                            BlackPlayerId = 1,
                            ChessTournamentId = 1,
                            Date = new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WhitePlayerId = 3,
                            WinnerId = 1
                        });
                });

            modelBuilder.Entity("EFCoreChess.Entities.ChessTournament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TournamentName")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("Id");

                    b.ToTable("ChessTournaments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TournamentName = "Goodman Chess Tournament"
                        });
                });

            modelBuilder.Entity("EFCoreChess.Entities.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("Id");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Country = "Norway",
                            Name = "Magnus Carlsen"
                        },
                        new
                        {
                            Id = 2,
                            Country = "USA",
                            Name = "Fabiano Caruana"
                        },
                        new
                        {
                            Id = 3,
                            Country = "USA",
                            Name = "Hikaru Nakamura"
                        },
                        new
                        {
                            Id = 4,
                            Country = "USA",
                            Name = "Levy Rozman"
                        });
                });

            modelBuilder.Entity("EFCoreChess.Entities.PlayerChessTournament", b =>
                {
                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("ChessTournamentId")
                        .HasColumnType("int");

                    b.Property<int>("Place")
                        .HasColumnType("int");

                    b.HasKey("PlayerId", "ChessTournamentId");

                    b.HasIndex("ChessTournamentId");

                    b.ToTable("PlayerChessTournaments");

                    b.HasData(
                        new
                        {
                            PlayerId = 1,
                            ChessTournamentId = 1,
                            Place = 1
                        },
                        new
                        {
                            PlayerId = 3,
                            ChessTournamentId = 1,
                            Place = 2
                        },
                        new
                        {
                            PlayerId = 2,
                            ChessTournamentId = 1,
                            Place = 3
                        });
                });

            modelBuilder.Entity("EFCoreChess.Entities.PlayerDetail", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Bio")
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<string>("MostPLayedOpening")
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<int?>("Rating")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Players", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Rating = 2870
                        },
                        new
                        {
                            Id = 2,
                            Rating = 2775
                        },
                        new
                        {
                            Id = 3,
                            Rating = 2747
                        },
                        new
                        {
                            Id = 4,
                            Rating = 2322
                        });
                });

            modelBuilder.Entity("EFCoreChess.Entities.ChessGame", b =>
                {
                    b.HasOne("EFCoreChess.Entities.Player", "BlackPlayer")
                        .WithMany("BlackGames")
                        .HasForeignKey("BlackPlayerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EFCoreChess.Entities.ChessTournament", "ChessTournament")
                        .WithMany("Games")
                        .HasForeignKey("ChessTournamentId");

                    b.HasOne("EFCoreChess.Entities.Player", "WhitePlayer")
                        .WithMany("WhiteGames")
                        .HasForeignKey("WhitePlayerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("BlackPlayer");

                    b.Navigation("ChessTournament");

                    b.Navigation("WhitePlayer");
                });

            modelBuilder.Entity("EFCoreChess.Entities.PlayerChessTournament", b =>
                {
                    b.HasOne("EFCoreChess.Entities.ChessTournament", "ChessTournament")
                        .WithMany("PlayerChessTournaments")
                        .HasForeignKey("ChessTournamentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreChess.Entities.Player", "Player")
                        .WithMany("PlayerChessTournaments")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChessTournament");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("EFCoreChess.Entities.PlayerDetail", b =>
                {
                    b.HasOne("EFCoreChess.Entities.Player", "Player")
                        .WithOne("PlayerDetail")
                        .HasForeignKey("EFCoreChess.Entities.PlayerDetail", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("EFCoreChess.Entities.ChessTournament", b =>
                {
                    b.Navigation("Games");

                    b.Navigation("PlayerChessTournaments");
                });

            modelBuilder.Entity("EFCoreChess.Entities.Player", b =>
                {
                    b.Navigation("BlackGames");

                    b.Navigation("PlayerChessTournaments");

                    b.Navigation("PlayerDetail")
                        .IsRequired();

                    b.Navigation("WhiteGames");
                });
#pragma warning restore 612, 618
        }
    }
}
