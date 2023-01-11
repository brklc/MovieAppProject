using Microsoft.EntityFrameworkCore;
using MovieProject.Entity.Models;

namespace MovieProject.Entity.Context
{
    public class MovieProjectContext : DbContext
    {
        public MovieProjectContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<ProductionCompany> ProductionCompanies { get; set; }
        public virtual DbSet<BelongsToCollection> BelongsToCollections { get; set; }
        public virtual DbSet<ProductionCountry> ProductionCountries { get; set; }
        public virtual DbSet<SpokenLanguage> SpokenLanguages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MovieProject;Trusted_Connection=True|");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Status);
                entity.Property(e => e.Popularity);
                entity.Property(e => e.Adult);
                entity.Property(e => e.Backdrop_path);
                entity.Property(e => e.Budget);
                entity.Property(e => e.Homepage);
                entity.Property(e => e.Imdb_id);
                entity.Property(e => e.Original_language);
                entity.Property(e => e.Original_title);
                entity.Property(e => e.Overview);
                entity.Property(e => e.Popularity);
                entity.Property(e => e.Poster_path);
                entity.Property(e => e.Release_date);
                entity.Property(e => e.Revenue);
                entity.Property(e => e.Runtime);
                entity.Property(e => e.Tagline);
                entity.Property(e => e.Title);
                entity.Property(e => e.Vote_count);
                entity.Property(e => e.Vote_average);
                entity.Property(e => e.Video);

                entity.HasOne<BelongsToCollection>(s => s.Belongs_to_collection)
                .WithOne(s => s.Movie)
                .HasForeignKey<BelongsToCollection>(s => s.MovieId);
            });

            modelBuilder.Entity<SpokenLanguage>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Iso_639_1);
                entity.Property(e => e.English_name);

                entity.HasOne(m => m.Movie)
                .WithMany(s => s.Spoken_languages)
                .HasForeignKey(s => s.MovieId)
                .HasConstraintName("FK_Spoken_languages_Movie");
            });

            modelBuilder.Entity<ProductionCompany>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Origin_country);
                entity.Property(e => e.Logo_path);
                entity.Property(e => e.Name);

                entity.HasOne(m => m.Movie)
                .WithMany(s => s.Production_companies)
                .HasForeignKey(s => s.MovieId);
            });

            modelBuilder.Entity<ProductionCountry>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Iso_3166_1);

                entity.Property(e => e.Name);

                entity.HasOne(m => m.Movie)
                .WithMany(s => s.Production_countries)
                .HasForeignKey(s => s.MovieId);
            });


            modelBuilder.Entity<Genre>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Name);

                entity.HasOne(m => m.Movie)
                .WithMany(s => s.Genres)
                .HasForeignKey(s => s.MovieId);
            });


            modelBuilder.Entity<BelongsToCollection>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Name);
                entity.Property(e => e.Poster_path);
                entity.Property(e => e.Backdrop_path);

            });



        }
    }
}
