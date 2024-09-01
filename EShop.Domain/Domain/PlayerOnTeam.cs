using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Domain
{
    public class PlayerOnTeam : BaseEntity
    {
        public Guid PlayerId { get; set; }
        public Player? Player { get; set; }

        public Guid TeamId { get; set; }
        public Team? Team { get; set; }
    }
}
