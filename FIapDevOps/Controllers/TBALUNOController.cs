using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FiapDevOps.Data;
using FiapDevOps.Models;

namespace FiapDevOps.Controllers
{
    public class TBALUNOController : Controller
    {
        private readonly FiapDevOpsContext _context;

        public TBALUNOController(FiapDevOpsContext context)
        {
            _context = context;
        }

        // GET: TBALUNO
        public async Task<IActionResult> Index()
        {
            return View(await _context.AlunoViewModel.ToListAsync());
        }

        // GET: TBALUNO/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tB_ALUNO = await _context.AlunoViewModel
                .FirstOrDefaultAsync(m => m.ID == id);
            if (tB_ALUNO == null)
            {
                return NotFound();
            }

            return View(tB_ALUNO);
        }

        // GET: TBALUNO/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TBALUNO/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,NOM_ALUNO,NUM_RA")] TB_ALUNO tB_ALUNO)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tB_ALUNO);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tB_ALUNO);
        }

        // GET: TBALUNO/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tB_ALUNO = await _context.AlunoViewModel.FindAsync(id);
            if (tB_ALUNO == null)
            {
                return NotFound();
            }
            return View(tB_ALUNO);
        }

        // POST: TBALUNO/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,NOM_ALUNO,NUM_RA")] TB_ALUNO tB_ALUNO)
        {
            if (id != tB_ALUNO.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tB_ALUNO);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TB_ALUNOExists(tB_ALUNO.ID))
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
            return View(tB_ALUNO);
        }

        // GET: TBALUNO/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tB_ALUNO = await _context.AlunoViewModel
                .FirstOrDefaultAsync(m => m.ID == id);
            if (tB_ALUNO == null)
            {
                return NotFound();
            }

            return View(tB_ALUNO);
        }

        // POST: TBALUNO/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tB_ALUNO = await _context.AlunoViewModel.FindAsync(id);
            _context.AlunoViewModel.Remove(tB_ALUNO);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TB_ALUNOExists(int id)
        {
            return _context.AlunoViewModel.Any(e => e.ID == id);
        }
    }
}
