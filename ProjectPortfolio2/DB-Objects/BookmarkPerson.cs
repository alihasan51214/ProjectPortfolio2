using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectPortfolio2.DBObjects
{
    public class BookmarkPerson
    {
        [Key]
        public string Nconst { get; set; }
        public int Userid { get; set; }
    }
}
