#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TRY.Data;
using TRY.Models;

namespace TRY.Controllers
{
    public class Clarify_donationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Clarify_donationController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Clarify_donation
        public async Task<IActionResult> Index()
        {
            return View(await _context.Donate.ToListAsync());
        }

        // GET: Clarify_donation/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donate = await _context.Donate
                .FirstOrDefaultAsync(m => m.ID == id);
            if (donate == null)
            {
                return NotFound();
            }

            return View(donate);
        }

        // GET: Clarify_donation/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clarify_donation/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Email,PhoneNo,TrnDate,TrnId,Donation_Reason,Donation_Medium,Amount")] Donate donate)
        {
            if (ModelState.IsValid)
            {
                _context.Add(donate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(donate);
        }

        // GET: Clarify_donation/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donate = await _context.Donate.FindAsync(id);
            if (donate == null)
            {
                return NotFound();
            }
            return View(donate);
        }

        // POST: Clarify_donation/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Email,PhoneNo,TrnDate,TrnId,Donation_Reason,Donation_Medium,Amount")] Donate donate)
        {
            if (id != donate.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(donate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DonateExists(donate.ID))
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
            return View(donate);
        }

        // GET: Clarify_donation/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donate = await _context.Donate
                .FirstOrDefaultAsync(m => m.ID == id);
            if (donate == null)
            {
                return NotFound();
            }

            return View(donate);
        }

        // POST: Clarify_donation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var donate = await _context.Donate.FindAsync(id);
            _context.Donate.Remove(donate);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DonateExists(int id)
        {
            return _context.Donate.Any(e => e.ID == id);
        }
    }
}
