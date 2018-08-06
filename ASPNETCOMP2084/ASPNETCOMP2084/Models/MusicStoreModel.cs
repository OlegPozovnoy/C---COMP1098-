namespace ASPNETCOMP2084.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MusicStoreModel : DbContext
    {
        public MusicStoreModel()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>()
                .Property(e => e.AlbumName)
                .IsUnicode(false);

            modelBuilder.Entity<Album>()
                .Property(e => e.price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Album>()
                .Property(e => e.AlbumArtistUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Artist>()
                .Property(e => e.Artist1)
                .IsUnicode(false);

            modelBuilder.Entity<Artist>()
                .HasMany(e => e.Albums)
                .WithRequired(e => e.Artist)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Genre>()
                .HasMany(e => e.Albums)
                .WithRequired(e => e.Genre)
                .WillCascadeOnDelete(false);
        }
    }
}
