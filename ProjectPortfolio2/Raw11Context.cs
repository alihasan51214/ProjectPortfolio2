using Microsoft.EntityFrameworkCore;

namespace ProjectPortfolio2
{
    public class Raw11Context : DbContext
    {
        public DbSet<ActorsKnownForTitles> ActorsKnownForTitles { get; set; }
        public DbSet<ActorsProfession> ActorsProfessions { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<EpisodeTitle> EpisodeTitles { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<NameBasics> NameBasics { get; set; }
        public DbSet<TitleAkas> TitleAkas { get; set; }
        public DbSet<TitleBasics> TitleBasics { get; set; }
        public DbSet<TitlePrincipals> TitlePrincipals { get; set; }
        public DbSet<WordSearch> WordSearch { get; set; }
        public DbSet<Writer> Writers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("host=RAWDATA_SMALL;db=raw11;uid=raw11;pwd=rtmkak12");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActorsKnownForTitles>().Property(x => x.Nconst).HasColumnName("nconst");
            modelBuilder.Entity<ActorsKnownForTitles>().Property(x => x.KnownForTitles).HasColumnName("knownfortitles");
            
            modelBuilder.Entity<ActorsProfession>().Property(x => x.Nconst).HasColumnName("nconst");
            modelBuilder.Entity<ActorsProfession>().Property(x => x.PrimaryProfession).HasColumnName("primaryprofession");
            
            modelBuilder.Entity<Director>().Property(x => x.Tconst).HasColumnName("tconst");
            modelBuilder.Entity<Director>().Property(x => x.Nconst).HasColumnName("nconst");
            
            modelBuilder.Entity<EpisodeTitle>().Property(x => x.Tconst).HasColumnName("tconst");
            modelBuilder.Entity<EpisodeTitle>().Property(x => x.ParentTconst).HasColumnName("parenttconst");
            modelBuilder.Entity<EpisodeTitle>().Property(x => x.SeasonNumber).HasColumnName("seasonnumber");
            modelBuilder.Entity<EpisodeTitle>().Property(x => x.EpisodeNumber).HasColumnName("episodenumber");
            
            modelBuilder.Entity<Genre>().Property(x => x.Tconst).HasColumnName("tconst");
            modelBuilder.Entity<Genre>().Property(x => x.Genres).HasColumnName("genres");
            
            modelBuilder.Entity<NameBasics>().Property(x => x.Nconst).HasColumnName("nconst");
            modelBuilder.Entity<NameBasics>().Property(x => x.PrimaryName).HasColumnName("primaryname");
            modelBuilder.Entity<NameBasics>().Property(x => x.BirthYear).HasColumnName("birthyear");
            modelBuilder.Entity<NameBasics>().Property(x => x.DeathYear).HasColumnName("deathyear");
            
            modelBuilder.Entity<TitleAkas>().Property(x => x.TitleID).HasColumnName("titleid");
            modelBuilder.Entity<TitleAkas>().Property(x => x.Ordering).HasColumnName("ordering");
            modelBuilder.Entity<TitleAkas>().Property(x => x.Title).HasColumnName("title");
            modelBuilder.Entity<TitleAkas>().Property(x => x.Region).HasColumnName("region");
            modelBuilder.Entity<TitleAkas>().Property(x => x.Language).HasColumnName("language");
            modelBuilder.Entity<TitleAkas>().Property(x => x.Types).HasColumnName("types");
            modelBuilder.Entity<TitleAkas>().Property(x => x.Attributes).HasColumnName("attributes");
            modelBuilder.Entity<TitleAkas>().Property(x => x.IsOriginalTitle).HasColumnName("isoriginaltitle");
            
            modelBuilder.Entity<TitleBasics>().Property(x => x.Tconst).HasColumnName("tconst");
            modelBuilder.Entity<TitleBasics>().Property(x => x.TitleType).HasColumnName("titletype");
            modelBuilder.Entity<TitleBasics>().Property(x => x.PrimaryTitle).HasColumnName("primarytitle");
            modelBuilder.Entity<TitleBasics>().Property(x => x.OriginalTitle).HasColumnName("oritinaltitle");
            modelBuilder.Entity<TitleBasics>().Property(x => x.IsAdult).HasColumnName("isadult");
            modelBuilder.Entity<TitleBasics>().Property(x => x.StartYear).HasColumnName("startyear");
            modelBuilder.Entity<TitleBasics>().Property(x => x.EndYear).HasColumnName("endyear");
            modelBuilder.Entity<TitleBasics>().Property(x => x.RunTimeMinutes).HasColumnName("runtimeminutes");
            modelBuilder.Entity<TitleBasics>().Property(x => x.Poster).HasColumnName("poster");
            modelBuilder.Entity<TitleBasics>().Property(x => x.Awards).HasColumnName("awards");
            modelBuilder.Entity<TitleBasics>().Property(x => x.Plot).HasColumnName("plot");
            modelBuilder.Entity<TitleBasics>().Property(x => x.AvarageRating).HasColumnName("averagerating");
            modelBuilder.Entity<TitleBasics>().Property(x => x.NumVotes).HasColumnName("numvotes");
            
            modelBuilder.Entity<TitlePrincipals>().Property(x => x.Tconst).HasColumnName("tconst");
            modelBuilder.Entity<TitlePrincipals>().Property(x => x.Ordering).HasColumnName("ordering");
            modelBuilder.Entity<TitlePrincipals>().Property(x => x.Nconst).HasColumnName("nconst");
            modelBuilder.Entity<TitlePrincipals>().Property(x => x.Category).HasColumnName("category");
            modelBuilder.Entity<TitlePrincipals>().Property(x => x.Job).HasColumnName("job");
            modelBuilder.Entity<TitlePrincipals>().Property(x => x.Characters).HasColumnName("characters");
            
            modelBuilder.Entity<WordSearch>().Property(x => x.Tconst).HasColumnName("tconst");
            modelBuilder.Entity<WordSearch>().Property(x => x.Word).HasColumnName("word");
            modelBuilder.Entity<WordSearch>().Property(x => x.Field).HasColumnName("field");
            modelBuilder.Entity<WordSearch>().Property(x => x.Lexeme).HasColumnName("lexeme");
            
            modelBuilder.Entity<Writer>().Property(x => x.Tconst).HasColumnName("tconst");
            modelBuilder.Entity<Writer>().Property(x => x.Writers).HasColumnName("writers");
        }
    }
}