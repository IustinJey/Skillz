﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using skillz_backend.data;

#nullable disable

namespace skillz_backend.Migrations
{
    [DbContext(typeof(SkillzDbContext))]
    partial class SkillzDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("skillz_backend.models.Badge", b =>
                {
                    b.Property<int>("BadgeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BadgeId"));

                    b.Property<string>("BadgeType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BadgeId");

                    b.ToTable("Badges");
                });

            modelBuilder.Entity("skillz_backend.models.CertificatUser", b =>
                {
                    b.Property<int>("IdCertificatUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCertificatUser"));

                    b.Property<string>("CertificateImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCertificate")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.HasKey("IdCertificatUser");

                    b.HasIndex("IdCertificate");

                    b.HasIndex("IdUser");

                    b.ToTable("CertificatsUser");
                });

            modelBuilder.Entity("skillz_backend.models.Certificate", b =>
                {
                    b.Property<int>("IdCertificate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCertificate"));

                    b.Property<string>("CertificateType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCertificate");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("skillz_backend.models.Job", b =>
                {
                    b.Property<int>("IdJob")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdJob"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExperiencedYears")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<string>("JobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdJob");

                    b.HasIndex("IdUser");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("skillz_backend.models.JobImage", b =>
                {
                    b.Property<int>("IdImage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdImage"));

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.HasKey("IdImage");

                    b.HasIndex("JobId");

                    b.ToTable("JobImages");
                });

            modelBuilder.Entity("skillz_backend.models.ReviewJob", b =>
                {
                    b.Property<int>("IdReviewJ")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdReviewJ"));

                    b.Property<int>("IdJob")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("IdReviewJ");

                    b.HasIndex("IdJob");

                    b.ToTable("ReviewsJob");
                });

            modelBuilder.Entity("skillz_backend.models.ReviewUser", b =>
                {
                    b.Property<int>("IdReviewU")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdReviewU"));

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("IdReviewU");

                    b.HasIndex("IdUser");

                    b.ToTable("ReviewsUser");
                });

            modelBuilder.Entity("skillz_backend.models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Verified")
                        .HasColumnType("bit");

                    b.HasKey("UserId");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("skillz_backend.models.UserBadge", b =>
                {
                    b.Property<int>("UserBadgeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserBadgeId"));

                    b.Property<int>("IdBadge")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.HasKey("UserBadgeId");

                    b.HasIndex("IdBadge");

                    b.HasIndex("IdUser");

                    b.ToTable("UserBadges");
                });

            modelBuilder.Entity("skillz_backend.models.CertificatUser", b =>
                {
                    b.HasOne("skillz_backend.models.Certificate", "Certificate")
                        .WithMany("UserCertificates")
                        .HasForeignKey("IdCertificate")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("skillz_backend.models.User", "User")
                        .WithMany("UserCertificates")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Certificate");

                    b.Navigation("User");
                });

            modelBuilder.Entity("skillz_backend.models.Job", b =>
                {
                    b.HasOne("skillz_backend.models.User", "User")
                        .WithMany("Jobs")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("skillz_backend.models.JobImage", b =>
                {
                    b.HasOne("skillz_backend.models.Job", "Job")
                        .WithMany("Images")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Job");
                });

            modelBuilder.Entity("skillz_backend.models.ReviewJob", b =>
                {
                    b.HasOne("skillz_backend.models.Job", "Job")
                        .WithMany("ReviewsJob")
                        .HasForeignKey("IdJob")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Job");
                });

            modelBuilder.Entity("skillz_backend.models.ReviewUser", b =>
                {
                    b.HasOne("skillz_backend.models.User", "User")
                        .WithMany("ReviewsUser")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("skillz_backend.models.UserBadge", b =>
                {
                    b.HasOne("skillz_backend.models.Badge", "Badge")
                        .WithMany("UserBadges")
                        .HasForeignKey("IdBadge")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("skillz_backend.models.User", "User")
                        .WithMany("UserBadges")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Badge");

                    b.Navigation("User");
                });

            modelBuilder.Entity("skillz_backend.models.Badge", b =>
                {
                    b.Navigation("UserBadges");
                });

            modelBuilder.Entity("skillz_backend.models.Certificate", b =>
                {
                    b.Navigation("UserCertificates");
                });

            modelBuilder.Entity("skillz_backend.models.Job", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("ReviewsJob");
                });

            modelBuilder.Entity("skillz_backend.models.User", b =>
                {
                    b.Navigation("Jobs");

                    b.Navigation("ReviewsUser");

                    b.Navigation("UserBadges");

                    b.Navigation("UserCertificates");
                });
#pragma warning restore 612, 618
        }
    }
}
