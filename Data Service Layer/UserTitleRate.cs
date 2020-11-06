using System;
using System.ComponentModel.DataAnnotations;

namespace DataServiceLayer
{
    public class UserTitleRate
    {
        [Key]
        public int UserId { get; set; }
        public int TitleIndividRating { get; set; }
        public string Tconst { get; set; }
        public DateTime UserTitleRateDate { get; set; }
    }
}