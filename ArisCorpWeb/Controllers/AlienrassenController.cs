﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ArisCorpWeb.Data;
using ArisCorpWeb.Models;

namespace ArisCorpWeb.Controllers
{
    public class AlienrassenController : Controller
    {
        private readonly AlienrassenContext _context;

        public AlienrassenController(AlienrassenContext context)
        {
            _context = context;
        }

        // GET: Alienrassen
        public async Task<IActionResult> Index()
        {
            return View(await _context.Alienrassen.ToListAsync());
        }

        // GET: Alienrassen/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alienrassen = await _context.Alienrassen
                .FirstOrDefaultAsync(m => m.Id == id);
            if (alienrassen == null)
            {
                return NotFound();
            }

            return View(alienrassen);
        }

        // GET: Alienrassen/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Alienrassen/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Rasse,Extra1,Extra2,Extra3,Extra4,Extra5,Picture1,Picture2,Picture3,Picture4,Picture5,Picture6,Picture7,Picture8,Picture9,Picture10,Content1,Content2,Content3,Content4,Content5,Content6,Content7,Content8,Content9,Content10,Content11,Content12,Content13,Content14,Content15,Content16,Content17,Content18,Content19,Content20,Content21,Content22,Content23,Content24,Content25,Content26,Content27,Content28,Content29,Content30")] Alienrassen alienrassen)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alienrassen);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(alienrassen);
        }

        // GET: Alienrassen/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alienrassen = await _context.Alienrassen.FindAsync(id);
            if (alienrassen == null)
            {
                return NotFound();
            }
            return View(alienrassen);
        }

        // POST: Alienrassen/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Rasse,Extra1,Extra2,Extra3,Extra4,Extra5,Picture1,Picture2,Picture3,Picture4,Picture5,Picture6,Picture7,Picture8,Picture9,Picture10,Content1,Content2,Content3,Content4,Content5,Content6,Content7,Content8,Content9,Content10,Content11,Content12,Content13,Content14,Content15,Content16,Content17,Content18,Content19,Content20,Content21,Content22,Content23,Content24,Content25,Content26,Content27,Content28,Content29,Content30")] Alienrassen alienrassen)
        {
            if (id != alienrassen.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alienrassen);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlienrassenExists(alienrassen.Id))
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
            return View(alienrassen);
        }

        // GET: Alienrassen/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alienrassen = await _context.Alienrassen
                .FirstOrDefaultAsync(m => m.Id == id);
            if (alienrassen == null)
            {
                return NotFound();
            }

            return View(alienrassen);
        }

        // POST: Alienrassen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var alienrassen = await _context.Alienrassen.FindAsync(id);
            _context.Alienrassen.Remove(alienrassen);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlienrassenExists(string id)
        {
            return _context.Alienrassen.Any(e => e.Id == id);
        }
    }
}