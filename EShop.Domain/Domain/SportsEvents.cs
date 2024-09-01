using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Domain
{
    public class SportsEvents : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<MatchSchedules>? MatchSchedules { get; set; }
        public virtual ICollection<Ticket>? Tickets { get; set; }
    }
}
