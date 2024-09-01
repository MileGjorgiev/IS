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
    public class MatchScheduleService : IMatchScheduleService
    {

        private readonly IRepository<MatchSchedules> _matchSchedulesRepo;

        public MatchScheduleService(IRepository<MatchSchedules> matchSchedulesRepo)
        {
            _matchSchedulesRepo = matchSchedulesRepo;
        }


        public void CreateNewMatchSchedule(MatchSchedules p)
        {
            _matchSchedulesRepo.Insert(p);
        }

        public void DeleteMatchSchedule(Guid id)
        {
            MatchSchedules ms = _matchSchedulesRepo.Get(id);
            _matchSchedulesRepo.Delete(ms);
        }

        public List<MatchSchedules> GetAllMatchSchedules()
        {
            return _matchSchedulesRepo.GetAll().ToList();
        }

        public MatchSchedules GetDetailsForMatchSchedule(Guid? id)
        {
            return _matchSchedulesRepo.Get(id);
        }

        public void UpdateExistingMatchSchedule(MatchSchedules p)
        {
           _matchSchedulesRepo.Update(p);
        }
    }
}
