﻿using System.ComponentModel.DataAnnotations;

namespace DataServiceLayer
{
    public class WordSearch
    {
        [Key]
        public string Tconst { get; set; }
        public string Word { get; set; }
        public string Field { get; set; }
        public string Lexeme { get; set; }


        public override string ToString()
        {
            return $"Tconst = {Tconst}, Word= {Word},Field= {Field}, Lexeme= {Lexeme} ";
        }

    }
}