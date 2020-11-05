
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Immutable;

namespace ProjectPortfolio2
{
    public class DataService
    {
        public IList<ActorsKnownForTitles> GetActorsKnownForTitles()
        {
            using var ctx = new Raw11Context();
            return ctx.ActorsKnownForTitles.ToList();
        }
    }
}