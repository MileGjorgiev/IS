using EShop.Domain.Domain;
using EShop.Repository.Interface;
using EShop.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Service.Implementation
{
    public class PlayerService : IPlayerService
    {
        private readonly IRepository<Player> _playerRepo;
        private readonly IRepository<Team> _teamRepo;
        private readonly IRepository<PlayerOnTeam> _playTeam;

        public PlayerService(IRepository<Player> playerRepo, IRepository<Team> teamRepo, IRepository<PlayerOnTeam> playTeam)
        {
            _playerRepo = playerRepo;
            _teamRepo = teamRepo;
            _playTeam = playTeam;
        }

        public void CreateNewPlayer(Player p)
        {
            _playerRepo.Insert(p);
        }

        public void DeletePlayer(Guid id)
        {
            Player ms = _playerRepo.Get(id);
            _playerRepo.Delete(ms);
        }

        public List<Player> GetAllPlayers()
        {
            return _playerRepo.GetAll().ToList();
        }

        public Player GetDetailsForPlayer(Guid? id)
        {
            return _playerRepo.Get(id);
        }

        public void UpdateExistingPlayer(Player p)
        {
            _playerRepo.Update(p);
        }

        public PlayerOnTeam AddPlayerToTeam(Guid playerId,Guid teamId)
        {
            Player ms = _playerRepo.Get(playerId);
            Team team = _teamRepo.Get(teamId);

            PlayerOnTeam player = new PlayerOnTeam
            {
                PlayerId = playerId,
                TeamId = teamId
            };

            _playTeam.Insert(player);
            team.PlayerOnTeams.Add(player);
            _teamRepo.Update(team);

            return player;
        }

        public List<PlayerOnTeam> GetPlayersOnTeam()
        {
            return _playTeam.GetAll().ToList();
        }
    }
}
