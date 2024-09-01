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
    public class SportsEventsService : ISportsEventsService
    {
        private readonly IRepository<SportsEvents> _sportsEventRepo;

        public SportsEventsService(IRepository<SportsEvents> sportEventRepo)
        {
            _sportsEventRepo = sportEventRepo;
        }
        public void CreateNewSportsEvent(SportsEvents p)
        {
            _sportsEventRepo.Insert(p);
        }

        public void DeleteSportsEvent(Guid id)
        {
            SportsEvents se=_sportsEventRepo.Get(id);
            _sportsEventRepo.Delete(se);
        }

        public List<SportsEvents> GetAllSportsEvents()
        {
            return _sportsEventRepo.GetAll().ToList();
        }

        public SportsEvents GetDetailsForSportsEvent(Guid? id)
        {
            return _sportsEventRepo.Get(id);
        }

        public void UpdateExistingSportsEvent(SportsEvents p)
        {
            _sportsEventRepo.Update(p);
        }
    }
}
