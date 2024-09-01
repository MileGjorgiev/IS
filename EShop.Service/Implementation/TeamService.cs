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
    public class TeamService : ITeamService
    {
        private readonly IRepository<Team> _teamRepo;

        public TeamService(IRepository<Team> teamRepo)
        {
            _teamRepo = teamRepo;
        }
        public void CreateNewTeam(Team p)
        {
            _teamRepo.Insert(p);
        }

        public void DeleteTeam(Guid id)
        {
            Team team=_teamRepo.Get(id);
            _teamRepo.Delete(team);
        }

        public List<Team> GetAllTeams()
        {
            return _teamRepo.GetAll().ToList();
        }

        public Team GetDetailsForTeam(Guid? id)
        {
            return _teamRepo.Get(id);
        }

        public void UpdateExistingTeam(Team p)
        {
            _teamRepo.Update(p);
        }
    }
}
