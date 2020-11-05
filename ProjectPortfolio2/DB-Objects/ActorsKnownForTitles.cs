using System.ComponentModel.DataAnnotations;

namespace ProjectPortfolio2
{
    public class ActorsKnownForTitles
    {
        [Key]
        public string Nconst { get; set; }
        public string KnownForTitles { get; set; }
    }
}