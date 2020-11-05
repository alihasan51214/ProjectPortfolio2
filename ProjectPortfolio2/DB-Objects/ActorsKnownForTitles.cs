using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPortfolio2
{
    public class ActorsKnownForTitles
    {
        [Key]
        public string Nconst { get; set; }
        public string KnownForTitles { get; set; }
    }
}