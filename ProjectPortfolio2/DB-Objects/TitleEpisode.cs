using System.ComponentModel.DataAnnotations;

namespace ProjectPortfolio2
{
    public class TitleEpisode
    {
        [Key]
        public string Tconst { get; set; }
        public string ParentTconst { get; set; }
        public int SeasonNumber { get; set; }
        public int EpisodeNumber { get; set; }

    }
}