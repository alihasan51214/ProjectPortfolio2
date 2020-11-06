using System.ComponentModel.DataAnnotations;

namespace DataServiceLayer
{
    public class TitleGenres
    {
        [Key]
        public string Tconst { get; set; }
        public string Genres { get; set; }
    }
}