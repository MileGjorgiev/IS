using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Domain
{
    public class MatchSchedules : BaseEntity
    {
        public DateTime Date { get; set; }

        public Guid TeamId1 { get; set; }
        public Team? Team1 { get; set; }

        public Guid TeamId2 { get; set; }
        public Team? Team2 { get; set; }

        public Guid SportEventsId { get; set; }
        public SportsEvents? SportsEvents { get; set; }
    }
}
