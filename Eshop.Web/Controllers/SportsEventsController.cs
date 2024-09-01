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

namespace EShop.Web.Controllers
{
    public class SportsEventsController : Controller
    {
        private readonly ISportsEventsService _sportsEventsService;
        private readonly IMatchScheduleService _matchScheduleService;

        public SportsEventsController(ISportsEventsService sportsEventsService, IMatchScheduleService matchScheduleService)
        {
            _sportsEventsService = sportsEventsService;
            _matchScheduleService = matchScheduleService;
        }

        // GET: SportsEvents
        public IActionResult Index()
        {
            return View(_sportsEventsService.GetAllSportsEvents());
        }

        // GET: SportsEvents/Details/5
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sportsEvents = _sportsEventsService.GetDetailsForSportsEvent(id);
            var matches = _matchScheduleService.GetAllMatchSchedules()
                .Where(match => match.SportEventsId == id).ToList();

            

            sportsEvents.MatchSchedules = matches;


            if (sportsEvents == null)
            {
                return NotFound();
            }

            return View(sportsEvents);
        }

        // GET: SportsEvents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SportsEvents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name,Id")] SportsEvents sportsEvents)
        {
            
                sportsEvents.Id = Guid.NewGuid();
                _sportsEventsService.CreateNewSportsEvent(sportsEvents);
                return RedirectToAction(nameof(Index));
            
        }

        // GET: SportsEvents/Edit/5
        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sportsEvents = _sportsEventsService.GetDetailsForSportsEvent(id);
            if (sportsEvents == null)
            {
                return NotFound();
            }
            return View(sportsEvents);
        }

        // POST: SportsEvents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, [Bind("Name,Id")] SportsEvents sportsEvents)
        {
            if (id != sportsEvents.Id)
            {
                return NotFound();
            }

            
                try
                {
                    _sportsEventsService.UpdateExistingSportsEvent(sportsEvents);
                }
                catch (DbUpdateConcurrencyException)
                {
                   
                    
                        throw;
                    
                }
                return RedirectToAction(nameof(Index));
            
        }

        // GET: SportsEvents/Delete/5
        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sportsEvents = _sportsEventsService.GetDetailsForSportsEvent(id);

            if (sportsEvents == null)
            {
                return NotFound();
            }

            return View(sportsEvents);
        }

        // POST: SportsEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            _sportsEventsService.DeleteSportsEvent(id);
            return RedirectToAction(nameof(Index));
        }

       
    }
}
