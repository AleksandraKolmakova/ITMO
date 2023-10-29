using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebPumpsApp.Data;
using WebPumpsApp.Models;

namespace WebPumpsApp.Controllers
{
    public class PumpsController : Controller
    {
        private readonly PumpsContext _context;

        public PumpsController(PumpsContext context)
        {
            _context = context;
        }

        // GET: Pumps
        public async Task<IActionResult> Index()
        {
              return View(await _context.Pumps.ToListAsync());
        }

        // GET: Pumps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Pumps == null)
            {
                return NotFound();
            }

            var pump = await _context.Pumps
                .FirstOrDefaultAsync(m => m.PumpId == id);
            if (pump == null)
            {
                return NotFound();
            }

            return View(pump);
        }

        // GET: Pumps/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pumps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PumpId,Head,Flow,Pressure,Power,IntDiam,OutdDiam,Weight")] Pump pump)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pump);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pump);
        }

        // GET: Pumps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Pumps == null)
            {
                return NotFound();
            }

            var pump = await _context.Pumps.FindAsync(id);
            if (pump == null)
            {
                return NotFound();
            }
            return View(pump);
        }

        // POST: Pumps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PumpId,Head,Flow,Pressure,Power,IntDiam,OutdDiam,Weight")] Pump pump)
        {
            if (id != pump.PumpId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pump);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PumpExists(pump.PumpId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(pump);
        }

        // GET: Pumps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Pumps == null)
            {
                return NotFound();
            }

            var pump = await _context.Pumps
                .FirstOrDefaultAsync(m => m.PumpId == id);
            if (pump == null)
            {
                return NotFound();
            }

            return View(pump);
        }

        // POST: Pumps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Pumps == null)
            {
                return Problem("Entity set 'PumpsContext.Pumps'  is null.");
            }
            var pump = await _context.Pumps.FindAsync(id);
            if (pump != null)
            {
                _context.Pumps.Remove(pump);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PumpExists(int id)
        {
          return _context.Pumps.Any(e => e.PumpId == id);
        }
    }
}
