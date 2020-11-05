using System.ComponentModel.DataAnnotations;
  using System;

namespace ProjectPortfolio2
{
    public class UserNameRate
    {          
             [Key]
    public int UserId { get; set; }
        public int NameIndividRating { get; set; }
        public string Nconst { get; set; }
        public DateTime DateTime { get; set; }
    }
}