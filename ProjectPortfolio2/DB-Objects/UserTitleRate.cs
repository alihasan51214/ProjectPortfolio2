using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectPortfolio2
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