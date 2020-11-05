using System.ComponentModel.DataAnnotations;
 
using System.ComponentModel.DataAnnotations;

namespace ProjectPortfolio2
{
    public class Directors
    {
        public string Tconst { get; set; }
        [Key]
        public string Nconst { get; set; }
    }
}