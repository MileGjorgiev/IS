using EShop.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Service.Interface
{
    public interface IPlayerService
    {
        List<Player> GetAllPlayers();
        Player GetDetailsForPlayer(Guid? id);
        void CreateNewPlayer(Player p);
        void UpdateExistingPlayer(Player p);
        void DeletePlayer(Guid id);
        PlayerOnTeam AddPlayerToTeam(Guid playerId, Guid teamId);

        List<PlayerOnTeam> GetPlayersOnTeam();
    }
}
