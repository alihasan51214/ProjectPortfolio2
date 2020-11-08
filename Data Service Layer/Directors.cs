﻿using System.ComponentModel.DataAnnotations;
 
 

namespace DataServiceLayer
{
    public class Directors
    {
        public string Tconst { get; set; }
        [Key]
        public string Nconst { get; set; }

        public override string ToString()
        {
            return $"Tconst = {Tconst}, Nconst= {Nconst}";
        }
    }
}