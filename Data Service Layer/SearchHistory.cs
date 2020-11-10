using System;
using System.ComponentModel.DataAnnotations;

namespace DataServiceLayer
{
    public class SearchHistory
    {
        [Key]
        public int UserId { get; set; }
        public string SearchInput { get; set; }
        public DateTime DateTime { get; set; }

        public override string ToString()
        {
            return $"UserId = {UserId}, SearchInput = {SearchInput}, DateTime ={ DateTime}";
        }
    }
}