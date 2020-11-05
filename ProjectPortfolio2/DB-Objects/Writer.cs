using System.ComponentModel.DataAnnotations;

namespace ProjectPortfolio2
{
    public class Writer
    {
        [Key]
        public string Tconst { get; set; }
        public string Writers { get; set; }
    }
}