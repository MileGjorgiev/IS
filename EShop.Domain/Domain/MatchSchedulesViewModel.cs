using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Domain
{
    public class MatchSchedulesViewModel
    {
        public IEnumerable<Team> Teams { get; set; }
        public SportsEvents Events { get; set; }
        
    }
}
