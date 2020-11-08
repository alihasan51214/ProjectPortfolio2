using System.ComponentModel.DataAnnotations;

namespace DataServiceLayer
{
    public class ActorsKnownForTitles
    {
        [Key]
        public string Nconst { get; set; }
        public string KnownForTitles { get; set; }

        public override string ToString()
        {
            return $"Nconst = {Nconst}, KnownForTitles = {KnownForTitles}";
        }
    }
}