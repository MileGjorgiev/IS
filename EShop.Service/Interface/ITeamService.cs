using EShop.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Service.Interface
{
    public interface ITeamService
    {
        List<Team> GetAllTeams();
        Team GetDetailsForTeam(Guid? id);
        void CreateNewTeam(Team p);
        void UpdateExistingTeam(Team p);
        void DeleteTeam(Guid id);
    }
}
