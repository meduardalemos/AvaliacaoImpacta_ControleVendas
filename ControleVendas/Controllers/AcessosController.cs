﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ControleVendas.Data;
using ControleVendas.Models;

namespace ControleVendas.Controllers
{
    public class AcessosController : Controller
    {
        private readonly ControleVendasContext _context;

        public AcessosController(ControleVendasContext context)
        {
            _context = context;
        }

        // GET: Acessos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Acesso.ToListAsync());
        }

        // GET: Acessos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var acesso = await _context.Acesso
                .FirstOrDefaultAsync(m => m.AcessoID == id);
            if (acesso == null)
            {
                return NotFound();
            }

            return View(acesso);
        }

        // GET: Acessos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Acessos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AcessoID,AcessoNivel")] Acesso acesso)
        {
            if (ModelState.IsValid)
            {
                _context.Add(acesso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(acesso);
        }

        // GET: Acessos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var acesso = await _context.Acesso.FindAsync(id);
            if (acesso == null)
            {
                return NotFound();
            }
            return View(acesso);
        }

        // POST: Acessos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AcessoID,AcessoNivel")] Acesso acesso)
        {
            if (id != acesso.AcessoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(acesso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AcessoExists(acesso.AcessoID))
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
            return View(acesso);
        }

        // GET: Acessos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var acesso = await _context.Acesso
                .FirstOrDefaultAsync(m => m.AcessoID == id);
            if (acesso == null)
            {
                return NotFound();
            }

            return View(acesso);
        }

        // POST: Acessos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var acesso = await _context.Acesso.FindAsync(id);
            if (acesso != null)
            {
                _context.Acesso.Remove(acesso);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AcessoExists(int id)
        {
            return _context.Acesso.Any(e => e.AcessoID == id);
        }
    }
}
