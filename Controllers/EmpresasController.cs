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
    public class EmpresasController : Controller
    {
        private readonly MaxDbContext _context;

        public EmpresasController(MaxDbContext context)
        {
            _context = context;
        }

        // GET: Empresas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Empresas.ToListAsync());
        }

        // GET: Empresas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empresas = await _context.Empresas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (empresas == null)
            {
                return NotFound();
            }

            return View(empresas);
        }

        // GET: Empresas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Empresas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Cif,Direccion,Descripcion,FechaBaja,FechaAlta,FechaModif,Telefono,Fax,Email,CodigoOperador,Serie,Num,Num2,NombreBanco,NumCuenta,Estado,FechaEstado,CosteServicio,Franquicia,FranquiciaMax,CabeceraColectivo,IdAsesor,TelefonoAsesor,MargenColectivo,SufijoNorma19,IdAgente,FechaDesdeAgente,FechaHastaAgente,CuentaIva,CuentaBase,AutogestionProlin,AutogestionServicios,AutogestionTerminales,AutogestionIncidencias,AutogestionSms,IdGrupo,IdCatalogo,PorcentajeDescuentoColectivo,MargenTerminal,FranquiciaVoz,NombreAdminLegal,DniAdminLegal,RefOrdenDomiciliacion,FechaOrdenDomiciliacion,NombreComercial,PlanPrecios,IdcVinculada,EmailFacturacion,PorcentajeDtoCatalogoOp,Serie3,Num3,SerieR,NumR,FormaPago")] Empresas empresas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(empresas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(empresas);
        }

        // GET: Empresas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empresas = await _context.Empresas.FindAsync(id);
            if (empresas == null)
            {
                return NotFound();
            }
            return View(empresas);
        }

        // POST: Empresas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Cif,Direccion,Descripcion,FechaBaja,FechaAlta,FechaModif,Telefono,Fax,Email,CodigoOperador,Serie,Num,Num2,NombreBanco,NumCuenta,Estado,FechaEstado,CosteServicio,Franquicia,FranquiciaMax,CabeceraColectivo,IdAsesor,TelefonoAsesor,MargenColectivo,SufijoNorma19,IdAgente,FechaDesdeAgente,FechaHastaAgente,CuentaIva,CuentaBase,AutogestionProlin,AutogestionServicios,AutogestionTerminales,AutogestionIncidencias,AutogestionSms,IdGrupo,IdCatalogo,PorcentajeDescuentoColectivo,MargenTerminal,FranquiciaVoz,NombreAdminLegal,DniAdminLegal,RefOrdenDomiciliacion,FechaOrdenDomiciliacion,NombreComercial,PlanPrecios,IdcVinculada,EmailFacturacion,PorcentajeDtoCatalogoOp,Serie3,Num3,SerieR,NumR,FormaPago")] Empresas empresas)
        {
            if (id != empresas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(empresas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmpresasExists(empresas.Id))
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
            return View(empresas);
        }

        // GET: Empresas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empresas = await _context.Empresas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (empresas == null)
            {
                return NotFound();
            }

            return View(empresas);
        }

        // POST: Empresas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var empresas = await _context.Empresas.FindAsync(id);
            if (empresas != null)
            {
                _context.Empresas.Remove(empresas);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmpresasExists(int id)
        {
            return _context.Empresas.Any(e => e.Id == id);
        }
    }
}
