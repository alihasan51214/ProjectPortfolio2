using System.Collections.Generic;
using System.Linq;

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