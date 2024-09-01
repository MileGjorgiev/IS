using EShop.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Service.Interface
{
    public interface IMatchScheduleService
    {
        List<MatchSchedules> GetAllMatchSchedules();
        MatchSchedules GetDetailsForMatchSchedule(Guid? id);
        void CreateNewMatchSchedule(MatchSchedules p);
        void UpdateExistingMatchSchedule(MatchSchedules p);
        void DeleteMatchSchedule(Guid id);
    }
}
