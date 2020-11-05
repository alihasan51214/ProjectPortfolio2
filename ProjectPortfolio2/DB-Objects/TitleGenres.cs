using System.ComponentModel.DataAnnotations;

namespace ProjectPortfolio2
{
    public class TitleGenres
    {
        [Key]
        public string Tconst { get; set; }
        public string Genres { get; set; }
    }
}