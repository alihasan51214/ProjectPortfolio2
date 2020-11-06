using System;
using System.ComponentModel.DataAnnotations;

namespace DataServiceLayer.DBObjects
{
    public class BookmarkPerson
    {
        [Key]
        public string Nconst { get; set; }
        public int Userid { get; set; }
    }
}
