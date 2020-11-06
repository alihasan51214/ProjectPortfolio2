using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataServiceLayer
{
    public class NameBasics
    {
        [Key]
        public string Nconst { get; set; }
        public string PrimaryName { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
    }
}