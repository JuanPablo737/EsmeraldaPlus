using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EsmeraldaPlus.Core;
using EsmeraldaPlus.Core.Domain;
using EsmeraldaPlus.Infrastructure.Data;



namespace EsmeraldaPlus.Web.Controllers
{
    public class ClienteController : Controller
    {
        private readonly EsmeraldaPlusDbContext _context;

        public ClienteController(EsmeraldaPlusDbContext context)
        {
            _context = context;
        }

        // GET: Cliente
        public async Task<IActionResult> Index()
        {
            var esmeraldaPlusDbContext = _context.Cliente.Include(c => c.CodTelefonNavigation).Include(c => c.IdRolesNavigation);
            return View(await esmeraldaPlusDbContext.ToListAsync());
        }

        // GET: Cliente/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente
                .Include(c => c.CodTelefonNavigation)
                .Include(c => c.IdRolesNavigation)
                .FirstOrDefaultAsync(m => m.IdCliente == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // GET: Cliente/Create
        public IActionResult Create()
        {
            ViewData["CodTelefon"] = new SelectList(_context.TipoDeNumero, "CodTelefon", "CodTelefon");
            ViewData["IdRoles"] = new SelectList(_context.Roles, "IdRoles", "IdRoles");
            return View();
        }

        // POST: Cliente/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCliente,PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,Direccion,CorreoElectronico,CodTelefon,IdRoles,Telefon")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CodTelefon"] = new SelectList(_context.TipoDeNumero, "CodTelefon", "CodTelefon", cliente.CodTelefon);
            ViewData["IdRoles"] = new SelectList(_context.Roles, "IdRoles", "IdRoles", cliente.IdRoles);
            return View(cliente);
        }

        // GET: Cliente/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            ViewData["CodTelefon"] = new SelectList(_context.TipoDeNumero, "CodTelefon", "CodTelefon", cliente.CodTelefon);
            ViewData["IdRoles"] = new SelectList(_context.Roles, "IdRoles", "IdRoles", cliente.IdRoles);
            return View(cliente);
        }

        // POST: Cliente/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCliente,PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,Direccion,CorreoElectronico,CodTelefon,IdRoles,Telefon")] Cliente cliente)
        {
            if (id != cliente.IdCliente)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(cliente.IdCliente))
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
            ViewData["CodTelefon"] = new SelectList(_context.TipoDeNumero, "CodTelefon", "CodTelefon", cliente.CodTelefon);
            ViewData["IdRoles"] = new SelectList(_context.Roles, "IdRoles", "IdRoles", cliente.IdRoles);
            return View(cliente);
        }

        // GET: Cliente/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente
                .Include(c => c.CodTelefonNavigation)
                .Include(c => c.IdRolesNavigation)
                .FirstOrDefaultAsync(m => m.IdCliente == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // POST: Cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cliente = await _context.Cliente.FindAsync(id);
            _context.Cliente.Remove(cliente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClienteExists(int id)
        {
            return _context.Cliente.Any(e => e.IdCliente == id);
        }
    }
}
