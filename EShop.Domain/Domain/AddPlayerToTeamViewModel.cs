using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Domain
{
    public class AddPlayerToTeamViewModel
    {
        public List<Player> Players { get; set; } = new List<Player>();
        public Team Team { get; set; } = new Team();
        public Guid SelectedPlayerId { get; set; }
    }
}
