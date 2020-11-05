using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectPortfolio2.DBObjects
{
    public class Bookmarktitle
    {
        [Key]
        public string Userid { get; set; }
        public string Tconst { get; set; }

    }
}
