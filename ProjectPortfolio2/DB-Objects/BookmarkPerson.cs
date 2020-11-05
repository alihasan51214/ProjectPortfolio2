using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Collections;

 
namespace ProjectPortfolio2.DBObjects
{
    public class BookmarkPerson
    {   
        public string Nconst { get; set; }
        [Key]
        public int Userid { get; set; }
    }
}
