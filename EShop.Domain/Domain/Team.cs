using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Domain
{
    public class Team : BaseEntity
    {
        public string Name { get; set; }
        public string City { get; set; }
        public virtual ICollection<PlayerOnTeam>? PlayerOnTeams { get; set; }
    }
}
