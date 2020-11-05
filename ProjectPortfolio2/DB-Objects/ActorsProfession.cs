using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Collections;
namespace ProjectPortfolio2
{
    public class ActorsProfession
    {
        [Key]
        public string Nconst { get; set; }
        public string PrimaryProfession { get; set; }
    }
}