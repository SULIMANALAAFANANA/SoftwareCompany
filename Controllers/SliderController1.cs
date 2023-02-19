using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SoftwareCompany.Data;
using SoftwareCompany.Models;



namespace SoftwareCompany.Controllers
{
    public class SlidersController : Controller
    {
        private readonly ApplicationDbContext _context;



        public SlidersController(ApplicationDbContext context)
        {
            _context = context;
        }



        // GET: Slider
        public async Task<IActionResult> Index()
        {
            return View(await _context.Slider.ToListAsync());
        }



        // GET: Sliders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }



            var student = await _context.Slider
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }



            return View(student);
        }



        // GET: Sliders/Create
        public IActionResult Create()
        {
            return View();
        }



        // POST: Sliders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Mainaddress,Subaddress,Text")] Slider Slider)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Slider);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Slider);
        }



        // GET: Sliders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }



            var Slider = await _context.Slider.FindAsync(id);
            if (Slider == null)
            {
                return NotFound();
            }
            return View(Slider);
        }



        // POST: Sliders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Mainaddress,Subaddress,Text")] Slider Slider)
        {
            if (id != Slider.Id)
            {
                return NotFound();
            }



            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Slider);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SliderExists(Slider.Id))
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
            return View(Slider);
        }



        // GET: Sliders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }



            var Slider = await _context.Slider
                .FirstOrDefaultAsync(m => m.Id == id);
            if (Slider == null)
            {
                return NotFound();
            }



            return View(Slider);
        }



        // POST: Sliders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var Slider = await _context.Slider.FindAsync(id);
            _context.Slider.Remove(Slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



        private bool SliderExists(int id)
        {
            return _context.Slider.Any(e => e.Id == id);
        }
    }
}