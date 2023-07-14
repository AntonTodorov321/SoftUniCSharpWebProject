﻿// <auto-generated />
using System;
using FitnessSite.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FitnessSite.Data.Migrations
{
    [DbContext(typeof(FitnessSiteDbContext))]
    partial class FitnessSiteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FitnessSite.Data.Models.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrainerId")
                        .HasColumnType("int");

                    b.Property<Guid?>("TrainingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("TrainerId");

                    b.HasIndex("TrainingId");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("FitnessSite.Data.Models.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<int?>("Kilogram")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Reps")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sets")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Exercises");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "An exercise in which a person, keeping a prone position with thehandspalms down under the shoulders",
                            ImageUrl = "https://blog.nasm.org/hubfs/power-pushups.jpg",
                            Name = "Push-Ups",
                            Reps = "10",
                            Sets = "4",
                            TypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Start in a tabletop position on your hands and knees, then lower down toyour forearms with your elbows stacked beneath your shoulders. Step yo  feet back until your body makes a line from shoulders to heels.",
                            ImageUrl = "https://blog-images-1.pharmeasy.in/blog/production/wp-content/uploads/2021/01/06152556/3.jpg",
                            Name = "Plank",
                            Reps = "8",
                            Sets = "3",
                            TypeId = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "Pullup is a challenging upper body exercise where you grip an overhead bar  and lift your body until your chin is above that bar.",
                            ImageUrl = "https://calisthenicsworldwide.com/wp-content/uploads/2023/02/152-CWW_20-pull-ups.jpg",
                            Name = "Pull-Ups",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 4,
                            Description = "Cycling, also, when on a two-wheeled bicycle, called bicycling or biking  is the use of cycles for transport, recreation, exercise or sport. People engaged in cycling are referred to as cyclists,bicyclists, or bikers.",
                            ImageUrl = "https://images.immediate.co.uk/production/volatile/sites/21/2022/05/Cube-Axial-WS-12-45369da.jpg?quality=90&resize=620%2C413",
                            Name = "Cycling",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 5,
                            Description = "The bench press is a compound exercise that targets the muscles of the upper body. It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells.",
                            ImageUrl = "https://cdn.muscleandstrength.com/sites/default/files/barbell-bench-press_0.jpg",
                            Name = "Bench Press",
                            Reps = "10 - 12",
                            Sets = "4",
                            TypeId = 3
                        },
                        new
                        {
                            Id = 6,
                            Description = "A squat is a strength exercise in which the trainee lowers their hips from a standing position and then stands back up. During the descent, the hip and knee joints flex while the ankle joint dorsiflexes",
                            ImageUrl = "https://www.muscleandfitness.com/wp-content/uploads/2019/02/1109-Barbell-Back-Squat-GettyImages-614107160.jpg?quality=86&strip=all",
                            Name = "Squat",
                            Reps = "8 - 10",
                            Sets = "3-4",
                            TypeId = 3
                        });
                });

            modelBuilder.Entity("FitnessSite.Data.Models.Muscle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Muscles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Biceps"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Triceps"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Shoulder"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Legs"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Chest"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Abs"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Back"
                        });
                });

            modelBuilder.Entity("FitnessSite.Data.Models.MuscleExercise", b =>
                {
                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<int>("MuscleId")
                        .HasColumnType("int");

                    b.HasKey("ExerciseId", "MuscleId");

                    b.HasIndex("MuscleId");

                    b.ToTable("MuscleExercises");

                    b.HasData(
                        new
                        {
                            ExerciseId = 1,
                            MuscleId = 7
                        },
                        new
                        {
                            ExerciseId = 1,
                            MuscleId = 2
                        },
                        new
                        {
                            ExerciseId = 2,
                            MuscleId = 6
                        },
                        new
                        {
                            ExerciseId = 2,
                            MuscleId = 7
                        },
                        new
                        {
                            ExerciseId = 2,
                            MuscleId = 3
                        },
                        new
                        {
                            ExerciseId = 3,
                            MuscleId = 1
                        },
                        new
                        {
                            ExerciseId = 3,
                            MuscleId = 2
                        },
                        new
                        {
                            ExerciseId = 3,
                            MuscleId = 5
                        },
                        new
                        {
                            ExerciseId = 4,
                            MuscleId = 4
                        },
                        new
                        {
                            ExerciseId = 5,
                            MuscleId = 2
                        },
                        new
                        {
                            ExerciseId = 5,
                            MuscleId = 5
                        },
                        new
                        {
                            ExerciseId = 6,
                            MuscleId = 4
                        },
                        new
                        {
                            ExerciseId = 6,
                            MuscleId = 6
                        });
                });

            modelBuilder.Entity("FitnessSite.Data.Models.Trainer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(747)
                        .HasColumnType("nvarchar(747)");

                    b.Property<decimal>("PricePerMonth")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("StartedAt")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Trainers");
                });

            modelBuilder.Entity("FitnessSite.Data.Models.Training", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApplicationUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Trainings");
                });

            modelBuilder.Entity("FitnessSite.Data.Models.TrainingExercise", b =>
                {
                    b.Property<Guid?>("TrainingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.HasKey("TrainingId", "ExerciseId");

                    b.HasIndex("ExerciseId");

                    b.ToTable("TrainingExercises");
                });

            modelBuilder.Entity("FitnessSite.Data.Models.TypeExercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("TypeExercises");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "In Home"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Outside"
                        },
                        new
                        {
                            Id = 3,
                            Name = "In the gym"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("FitnessSite.Data.Models.ApplicationUser", b =>
                {
                    b.HasOne("FitnessSite.Data.Models.Trainer", "Trainer")
                        .WithMany("ApllicationUsers")
                        .HasForeignKey("TrainerId");

                    b.HasOne("FitnessSite.Data.Models.Training", "Training")
                        .WithMany()
                        .HasForeignKey("TrainingId");

                    b.Navigation("Trainer");

                    b.Navigation("Training");
                });

            modelBuilder.Entity("FitnessSite.Data.Models.Exercise", b =>
                {
                    b.HasOne("FitnessSite.Data.Models.TypeExercise", "Type")
                        .WithMany("Exercises")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type");
                });

            modelBuilder.Entity("FitnessSite.Data.Models.MuscleExercise", b =>
                {
                    b.HasOne("FitnessSite.Data.Models.Exercise", "Exercise")
                        .WithMany("MuscleExercises")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitnessSite.Data.Models.Muscle", "Muscle")
                        .WithMany("MuscleExercises")
                        .HasForeignKey("MuscleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("Muscle");
                });

            modelBuilder.Entity("FitnessSite.Data.Models.Training", b =>
                {
                    b.HasOne("FitnessSite.Data.Models.ApplicationUser", "ApllicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApllicationUser");
                });

            modelBuilder.Entity("FitnessSite.Data.Models.TrainingExercise", b =>
                {
                    b.HasOne("FitnessSite.Data.Models.Exercise", "Exercise")
                        .WithMany("TrainingExercises")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FitnessSite.Data.Models.Training", "Training")
                        .WithMany("TrainingExercises")
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("Training");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("FitnessSite.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("FitnessSite.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitnessSite.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("FitnessSite.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FitnessSite.Data.Models.Exercise", b =>
                {
                    b.Navigation("MuscleExercises");

                    b.Navigation("TrainingExercises");
                });

            modelBuilder.Entity("FitnessSite.Data.Models.Muscle", b =>
                {
                    b.Navigation("MuscleExercises");
                });

            modelBuilder.Entity("FitnessSite.Data.Models.Trainer", b =>
                {
                    b.Navigation("ApllicationUsers");
                });

            modelBuilder.Entity("FitnessSite.Data.Models.Training", b =>
                {
                    b.Navigation("TrainingExercises");
                });

            modelBuilder.Entity("FitnessSite.Data.Models.TypeExercise", b =>
                {
                    b.Navigation("Exercises");
                });
#pragma warning restore 612, 618
        }
    }
}
