using System.ComponentModel.DataAnnotations;
 
namespace ProjectPortfolio2
{
    public class WordSearch
    {            
             [Key]
    public string Tconst { get; set; }
        public string Word { get; set; }
        public string Field { get; set; }
        public string Lexeme { get; set; }
    }
}