﻿using System.ComponentModel.DataAnnotations;

namespace ProjectPortfolio2
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Language { get; set; }
        public string Mail { get; set; }
    }
}