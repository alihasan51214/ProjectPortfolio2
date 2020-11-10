using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServiceLayer
{
    public class Writer
    {
        [Key]
        public string Tconst { get; set; }
        public string Writers { get; set; }


        public override string ToString()
        {
            return $"Tconst = {Tconst}, Writers= {Writers} ";
        }
    }
}