using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sigestel.Models;

namespace sigestel.Controllers
{
    [Authorize]
    public class SutAdministradoresController : Controller
    {
        private readonly MaxDbContext _context;

        public SutAdministradoresController(MaxDbContext context)
        {
            _context = context;
        }

        // GET: SutAdministradores
        public async Task<IActionResult> Index()
        {
            var maxDbContext = _context.SutAdministradores.Include(s => s.IdClienteNavigation).Include(s => s.IdPerfilNavigation);
            return View(await maxDbContext.ToListAsync());
        }

        // GET: SutAdministradores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sutAdministradores = await _context.SutAdministradores
                .Include(s => s.IdClienteNavigation)
                .Include(s => s.IdPerfilNavigation)
                .FirstOrDefaultAsync(m => m.IdAdministrador == id);
            if (sutAdministradores == null)
            {
                return NotFound();
            }

            return View(sutAdministradores);
        }

        // GET: SutAdministradores/Create
        public IActionResult Create()
        {
            ViewData["IdCliente"] = new SelectList(_context.Empresas, "Id", "Id");
            ViewData["IdPerfil"] = new SelectList(_context.SutPerfiles, "IdPerfil", "IdPerfil");
            return View();
        }

        // POST: SutAdministradores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdAdministrador,NombreCompleto,Usuario,Clave,IdCliente,Email,FechaAlta,FechaBaja,Telefono,IdPerfil,Nif,Estado,FechaEstado,ReenvioEmail,FechaUltimaConexion,ConexionesRealizadas,FechaAceptacionRgpd,IpaceptacionRgpd,DatosNavegadorRgpd,EmailVerificado,TelefonoAgente,Idagente,PerfilUsuario,AsociacionPerfilUsuario")] SutAdministradores sutAdministradores)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sutAdministradores);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCliente"] = new SelectList(_context.Empresas, "Id", "Id", sutAdministradores.IdCliente);
            ViewData["IdPerfil"] = new SelectList(_context.SutPerfiles, "IdPerfil", "IdPerfil", sutAdministradores.IdPerfil);
            return View(sutAdministradores);
        }

        // GET: SutAdministradores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sutAdministradores = await _context.SutAdministradores.FindAsync(id);
            if (sutAdministradores == null)
            {
                return NotFound();
            }
            ViewData["IdCliente"] = new SelectList(_context.Empresas, "Id", "Id", sutAdministradores.IdCliente);
            ViewData["IdPerfil"] = new SelectList(_context.SutPerfiles, "IdPerfil", "IdPerfil", sutAdministradores.IdPerfil);
            return View(sutAdministradores);
        }

        // POST: SutAdministradores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdAdministrador,NombreCompleto,Usuario,Clave,IdCliente,Email,FechaAlta,FechaBaja,Telefono,IdPerfil,Nif,Estado,FechaEstado,ReenvioEmail,FechaUltimaConexion,ConexionesRealizadas,FechaAceptacionRgpd,IpaceptacionRgpd,DatosNavegadorRgpd,EmailVerificado,TelefonoAgente,Idagente,PerfilUsuario,AsociacionPerfilUsuario")] SutAdministradores sutAdministradores)
        {
            if (id != sutAdministradores.IdAdministrador)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sutAdministradores);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SutAdministradoresExists(sutAdministradores.IdAdministrador))
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
            ViewData["IdCliente"] = new SelectList(_context.Empresas, "Id", "Id", sutAdministradores.IdCliente);
            ViewData["IdPerfil"] = new SelectList(_context.SutPerfiles, "IdPerfil", "IdPerfil", sutAdministradores.IdPerfil);
            return View(sutAdministradores);
        }

        // GET: SutAdministradores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sutAdministradores = await _context.SutAdministradores
                .Include(s => s.IdClienteNavigation)
                .Include(s => s.IdPerfilNavigation)
                .FirstOrDefaultAsync(m => m.IdAdministrador == id);
            if (sutAdministradores == null)
            {
                return NotFound();
            }

            return View(sutAdministradores);
        }

        // POST: SutAdministradores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sutAdministradores = await _context.SutAdministradores.FindAsync(id);
            if (sutAdministradores != null)
            {
                _context.SutAdministradores.Remove(sutAdministradores);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SutAdministradoresExists(int id)
        {
            return _context.SutAdministradores.Any(e => e.IdAdministrador == id);
        }
    }
}
