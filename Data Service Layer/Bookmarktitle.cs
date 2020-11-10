﻿using System.ComponentModel.DataAnnotations;
using System;
 

namespace DataServiceLayer.DBObjects
{
    public class Bookmarktitle
    {
        [Key]
        public string Userid { get; set; }
        public string Tconst { get; set; }

        public override string ToString()
        {
            return $"Userid = {Userid}, Tconst = {Tconst}";
        }

    }
}
