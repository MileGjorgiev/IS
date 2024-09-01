using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Domain
{
    public class Player : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public int years { get; set; }

        public Team? Team { get; set; }
        public virtual IEnumerable<PlayerOnTeam> OnTeams { get; set; }
    }
}
