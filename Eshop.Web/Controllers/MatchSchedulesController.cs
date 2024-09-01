using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EShop.Domain.Domain;
using EShop.Repository;
using EShop.Service.Interface;
using System.Dynamic;

namespace EShop.Web.Controllers
{
    public class MatchSchedulesController : Controller
    {
        private readonly IMatchScheduleService _matchScheduleService;
        private readonly ITeamService _teamService;
        private readonly ISportsEventsService _sportEvents;

        public MatchSchedulesController(IMatchScheduleService matchScheduleService, ITeamService teamService, ISportsEventsService sportEvents)
        {
            _matchScheduleService = matchScheduleService;
            _teamService = teamService;
            _sportEvents = sportEvents;
        }


        // GET: MatchSchedules/Create
        public IActionResult Create(Guid id)
        {
            var teams = _teamService.GetAllTeams();
            var events = _sportEvents.GetDetailsForSportsEvent(id);

            ViewData["Teams"] = teams;
            ViewData["Events"] = events;


            return View();
        }

        // POST: MatchSchedules/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Date,TeamId1,TeamId2,SportEventsId,Id")] MatchSchedules matchSchedules)
        {
            var teams = _teamService.GetAllTeams();
            var events = _sportEvents.GetDetailsForSportsEvent(matchSchedules.SportEventsId);

            ViewData["Teams"] = teams;
            ViewData["Events"] = events;

            if (matchSchedules.TeamId1 != matchSchedules.TeamId2)
            { 
                matchSchedules.Id = Guid.NewGuid();
                _matchScheduleService.CreateNewMatchSchedule(matchSchedules);
                return RedirectToAction("Index", "SportsEvents");
                
            }


            ModelState.AddModelError("TeamId2", "The two teams must be different.");

            return View(matchSchedules);

        }

        // GET: MatchSchedules/Edit/5
        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matchSchedules = _matchScheduleService.GetDetailsForMatchSchedule(id);
            if (matchSchedules == null)
            {
                return NotFound();
            }
            return View(matchSchedules);
        }

        // POST: MatchSchedules/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, [Bind("Date,TeamId1,TeamId2,SportEventsId,Id")] MatchSchedules matchSchedules)
        {
            if (id != matchSchedules.Id)
            {
                return NotFound();
            }

            
                try
                {
                    _matchScheduleService.UpdateExistingMatchSchedule(matchSchedules);
                }
                catch (DbUpdateConcurrencyException)
                {
                    
                        throw;
                }
            return RedirectToAction("Index", "SportsEvents");
        
        }

        // GET: MatchSchedules/Delete/5
        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matchSchedules = _matchScheduleService.GetDetailsForMatchSchedule(id);

            if (matchSchedules == null)
            {
                return NotFound();
            }

            return View(matchSchedules);
        }

        // POST: MatchSchedules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            _matchScheduleService.DeleteMatchSchedule(id);
            return RedirectToAction("Index", "SportsEvents");
        }

        
    }
}
