using System.ComponentModel.DataAnnotations;

namespace ProjectPortfolio2
{
    public class TitleAkas
    {
        [Key]
        public string TitleID { get; set; }
        public int Ordering { get; set; }
        public string Title { get; set; }
        public string Region { get; set; }
        public string Language { get; set; }
        public string Types { get; set; }
        public string Attributes { get; set; }
        public string IsOriginalTitle { get; set; }


    }
}