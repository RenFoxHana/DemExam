using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WpfApp1.Models
{
    public partial class Bochagova_ExamHotelContext : DbContext
    {
        public Bochagova_ExamHotelContext()
        {
        }

        public Bochagova_ExamHotelContext(DbContextOptions<Bochagova_ExamHotelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BonusCard> BonusCard { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<RoomHotel> RoomHotel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=hqvla3302s01\\KITP;Initial Catalog=Bochagova_ExamHotel;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BonusCard>(entity =>
            {
                entity.HasKey(e => e.IdCard);

                entity.ToTable("Bonus_Card");

                entity.Property(e => e.IdCard).HasColumnName("ID_Card");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.IdClient);

                entity.Property(e => e.IdClient).HasColumnName("ID_Client");

                entity.Property(e => e.Apartment)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Articul)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BirthDate)
                    .HasColumnName("Birth_Date")
                    .HasColumnType("date");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("First_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.House)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCard).HasColumnName("ID_Card");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Passport)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Patronymic)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ArticulNavigation)
                    .WithMany(p => p.Client)
                    .HasForeignKey(d => d.Articul)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Client_Room_Hotel");

                entity.HasOne(d => d.IdCardNavigation)
                    .WithMany(p => p.Client)
                    .HasForeignKey(d => d.IdCard)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Client_Bonus_Card");
            });

            modelBuilder.Entity<Contract>(entity =>
            {
                entity.HasKey(e => e.IdContract);

                entity.Property(e => e.IdContract).HasColumnName("ID_Contract");

                entity.Property(e => e.DateContract)
                    .HasColumnName("Date_Contract")
                    .HasColumnType("date");

                entity.Property(e => e.DateIn)
                    .HasColumnName("Date_In")
                    .HasColumnType("date");

                entity.Property(e => e.DateOut)
                    .HasColumnName("Date_Out")
                    .HasColumnType("date");

                entity.Property(e => e.IdClient).HasColumnName("ID_Client");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Contract)
                    .HasForeignKey(d => d.IdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contract_Client");
            });

            modelBuilder.Entity<RoomHotel>(entity =>
            {
                entity.HasKey(e => e.Articul);

                entity.ToTable("Room_Hotel");

                entity.Property(e => e.Articul)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CostPerNight).HasColumnName("Cost_Per_Night");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
