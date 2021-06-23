using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CookingApi.Models
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Contest> Contests { get; set; }
        public virtual DbSet<FeedBack> FeedBacks { get; set; }
        public virtual DbSet<MemberShip> MemberShips { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<RecipeContest> RecipeContests { get; set; }
        public virtual DbSet<ResHistory> ResHistories { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Type> Types { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=.;Database=JameCooking;user id=sa;password=123456");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.IdAcc)
                    .HasName("PK__Account__0E2BA47A33B1D76B");

                entity.ToTable("Account");

                entity.Property(e => e.Avt).IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("FK_Account_Role");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.HasKey(e => e.IdCom)
                    .HasName("PK__Comment__0FA7F294CC8B475F");

                entity.ToTable("Comment");

                entity.Property(e => e.Content)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAccNavigation)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.IdAcc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comment_Account");

                entity.HasOne(d => d.IdRecNavigation)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.IdRec)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comment_Recipe");
            });

            modelBuilder.Entity<Contest>(entity =>
            {
                entity.HasKey(e => e.IdCon)
                    .HasName("PK__Contest__0FA7F29505D524CE");

                entity.ToTable("Contest");

                entity.Property(e => e.ConEndDate).HasColumnType("date");

                entity.Property(e => e.ConStartDate).HasColumnType("date");

                entity.Property(e => e.NameCon)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FeedBack>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FeedBack");

                entity.Property(e => e.Content)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(10);
            });

            modelBuilder.Entity<MemberShip>(entity =>
            {
                entity.HasKey(e => e.IdMem)
                    .HasName("PK__MemberSh__0D1357C63BA99728");

                entity.ToTable("MemberShip");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Recipe>(entity =>
            {
                entity.HasKey(e => e.IdRec)
                    .HasName("PK__Recipe__2A4A4C1407E6529F");

                entity.ToTable("Recipe");

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Fof).HasColumnName("FOF");

                entity.Property(e => e.Photo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTypeNavigation)
                    .WithMany(p => p.Recipes)
                    .HasForeignKey(d => d.IdType)
                    .HasConstraintName("FK_Recipe_Type");
            });

            modelBuilder.Entity<RecipeContest>(entity =>
            {
                entity.HasKey(e => e.IdRc)
                    .HasName("PK__Rank__8F064AABF97FB134");

                entity.ToTable("Recipe_Contest");

                entity.Property(e => e.IdRc).HasColumnName("IdRC");

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.NameFile)
                    .IsRequired()
                    .HasColumnType("text");

                entity.HasOne(d => d.IdAccNavigation)
                    .WithMany(p => p.RecipeContests)
                    .HasForeignKey(d => d.IdAcc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Recipe_Contest_Account");

                entity.HasOne(d => d.IdConNavigation)
                    .WithMany(p => p.RecipeContests)
                    .HasForeignKey(d => d.IdCon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Recipe_Contest_Contest");
            });

            modelBuilder.Entity<ResHistory>(entity =>
            {
                entity.HasKey(e => e.IdRh)
                    .HasName("PK__ResHisto__B7702AF92C0FDCD1");

                entity.ToTable("ResHistory");

                entity.Property(e => e.IdRh).HasColumnName("IdRH");

                entity.Property(e => e.ResEndDate).HasColumnType("date");

                entity.Property(e => e.ResStartDate).HasColumnType("date");

                entity.HasOne(d => d.IdAccNavigation)
                    .WithMany(p => p.ResHistories)
                    .HasForeignKey(d => d.IdAcc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResHistory_Account");

                entity.HasOne(d => d.IdMemNavigation)
                    .WithMany(p => p.ResHistories)
                    .HasForeignKey(d => d.IdMem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResHistory_MemberShip");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRole);

                entity.ToTable("Role");

                entity.Property(e => e.IdRole)
                    .ValueGeneratedNever()
                    .HasColumnName("idRole");

                entity.Property(e => e.Role1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Role");
            });

            modelBuilder.Entity<Type>(entity =>
            {
                entity.HasKey(e => e.IdType)
                    .HasName("PK__Type__9A39EABC12C53FE3");

                entity.ToTable("Type");

                entity.Property(e => e.NameType)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
