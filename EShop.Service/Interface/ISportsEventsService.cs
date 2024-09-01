using EShop.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Service.Interface
{
    public interface ISportsEventsService
    {
        List<SportsEvents> GetAllSportsEvents();
        SportsEvents GetDetailsForSportsEvent(Guid? id);
        void CreateNewSportsEvent(SportsEvents p);
        void UpdateExistingSportsEvent(SportsEvents p);
        void DeleteSportsEvent(Guid id);
    }
}
