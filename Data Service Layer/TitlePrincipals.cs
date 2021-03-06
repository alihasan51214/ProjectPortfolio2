﻿using System.ComponentModel.DataAnnotations;

namespace DataServiceLayer
{
    public class TitlePrincipals
    {
        [Key]
        public string Tconst { get; set; }
        public int Ordering { get; set; }
        public string Nconst { get; set; }
        public string Category { get; set; }
        public string Job { get; set; }
        public string Characters { get; set; }

        public override string ToString()
        {
            return $"Tconst = {Tconst}, Ordering= {Ordering},Nconst= {Nconst}, Category= {Category}, Job= {Job}, Characters= {Characters} ";
        }
    }    
}