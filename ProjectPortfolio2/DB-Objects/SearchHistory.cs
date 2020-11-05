using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectPortfolio2
{
    public class SearchHistory
    {
        [Key]
        public int UserId { get; set; }
        public string SearchInput { get; set; }
        public DateTime DateTime { get; set; }   
    }
}