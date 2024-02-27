using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sigestel.Models;
using PagedList;
using sigestel.Tools;

namespace sigestel.Controllers
{
    //esto significa que si no estas logueado no podrás acceder
    [Authorize]
    public class SutFacturasController : Controller
    {
        private readonly MaxDbContext _context;

        public SutFacturasController(MaxDbContext context)
        {
            _context = context;
        }
        //En este primer método buscamos en la base de datos las facturas y podemos enseñar los registros que seleccionemos y cargarlos poco a poco
        //además de que si detecta que se ha introducido un valor en la barra de busqueda, busca por el nombre de banco introducido
        // GET: SutFacturas
        public async Task<IActionResult> Index(string empresaSeleccionada, string buscar, string ordenActual, int? numpag, string filtroActual, int? cantidadRegistros)
        {
            var facturas = from SutFacturas in _context.SutFacturas select SutFacturas;

            if (buscar != null)
            {
                numpag = 1;
            }
            else
            {
                buscar = filtroActual;
            }

            if (!String.IsNullOrEmpty(buscar))
            {
                facturas = facturas.Where(s => s.NombreBanco!.Contains(buscar));

            }

            ViewData["OrdenActual"] = ordenActual;
            ViewData["FiltroActual"] = buscar;

            ViewData["FiltroNombre"] = String.IsNullOrEmpty(ordenActual) ? "NombreDescendente" : "";
            ViewData["FiltroFecha"] = ordenActual == "FechaAscendente" ? "FechaDescendente" : "FechaAscendente";

            switch (ordenActual)
            {
                case "NombreDescendente":
                    facturas = facturas.OrderByDescending(facturas => facturas.NombreBanco);
                    break;
                case "FechaDescendente":
                    facturas = facturas.OrderByDescending(facturas => facturas.FechaFactura);
                    break;
                case "FechaAscendente":
                    facturas = facturas.OrderBy(facturas => facturas.FechaFactura);
                    break;
                default:
                    facturas = facturas.OrderBy(facturas => facturas.NombreBanco);
                    break;
            }
            int cantidadregistros = cantidadRegistros ?? 6; //de base se enseñan 6 registros a no ser que el usuario quiera más

            return View(await Paginacion<SutFacturas>.CrearPaginacion(facturas.AsNoTracking(), numpag ?? 1, cantidadregistros));
        }

        // GET: Bancos

        public async Task<IActionResult> IndexConEmpresa(string empresaSeleccionada, string buscar, string ordenActual, int? numpag, string filtroActual, int? cantidadRegistros)
        {
            var empresas = await _context.SutFacturas
                .Select(f => f.NombreBanco)
                .Distinct()
                .ToListAsync();

            ViewData["Empresas"] = new SelectList(empresas);

            var facturas = from SutFacturas in _context.SutFacturas select SutFacturas;

            if (!String.IsNullOrEmpty(empresaSeleccionada))
            {
                facturas = facturas.Where(s => s.NombreBanco == empresaSeleccionada);
            }

            if (buscar != null)
            {
                numpag = 1;
            }
            else
            {
                buscar = filtroActual;
            }

            if (!String.IsNullOrEmpty(buscar))
            {
                facturas = facturas.Where(s => s.NombreBanco!.Contains(buscar));
            }

            ViewData["OrdenActual"] = ordenActual;
            ViewData["FiltroActual"] = buscar;

            ViewData["FiltroNombre"] = String.IsNullOrEmpty(ordenActual) ? "NombreDescendente" : "";
            ViewData["FiltroFecha"] = ordenActual == "FechaAscendente" ? "FechaDescendente" : "FechaAscendente";

            switch (ordenActual)
            {
                case "NombreDescendente":
                    facturas = facturas.OrderByDescending(facturas => facturas.NombreBanco);
                    break;
                case "FechaDescendente":
                    facturas = facturas.OrderByDescending(facturas => facturas.FechaFactura);
                    break;
                case "FechaAscendente":
                    facturas = facturas.OrderBy(facturas => facturas.FechaFactura);
                    break;
                default:
                    facturas = facturas.OrderBy(facturas => facturas.NombreBanco);
                    break;
            }

            int cantidadregistros = cantidadRegistros ?? 6;

            return View("Index", await Paginacion<SutFacturas>.CrearPaginacion(facturas.AsNoTracking(), numpag ?? 1, cantidadregistros));
        }
    


    // GET: SutFacturas/Details/5
    public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sutFacturas = await _context.SutFacturas
                .FirstOrDefaultAsync(m => m.IdFactura == id);
            if (sutFacturas == null)
            {
                return NotFound();
            }

            return View(sutFacturas);
        }

        // GET: SutFacturas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SutFacturas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdFactura,NumFactura,BaseImponible,Iva,Impuesto,TotalFactura,FechaFactura,ImportePuntos,ImporteBruto,TotalDescuentos,Ciclo,TipoFactura,NombreBanco,NumCuenta,FactOtm,FechaInicio,FechaFin,Direccion,CodPostal,Poblacion,Provincia,EstadoNorma19,FechaCargo,FicheroNorma19,EnlaceGenerado,Generacion,Contabilizada,IdProceso,IdColectivo,IdClienteUsuario,Observaciones,TmPreciocoste1,TmPreciocoste2,TmPrecioventa,TmImporteacuenta,TmImportecomision,TmModoFin,TmMesesPlazo,ImportePagos,PerfilUsuario,IdAsociacionPerfilUsuario,ImportePtePago,ComentariosPagos")] SutFacturas sutFacturas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sutFacturas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sutFacturas);
        }

        // GET: SutFacturas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sutFacturas = await _context.SutFacturas.FindAsync(id);
            if (sutFacturas == null)
            {
                return NotFound();
            }
            return View(sutFacturas);
        }

        // POST: SutFacturas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdFactura,NumFactura,BaseImponible,Iva,Impuesto,TotalFactura,FechaFactura,ImportePuntos,ImporteBruto,TotalDescuentos,Ciclo,TipoFactura,NombreBanco,NumCuenta,FactOtm,FechaInicio,FechaFin,Direccion,CodPostal,Poblacion,Provincia,EstadoNorma19,FechaCargo,FicheroNorma19,EnlaceGenerado,Generacion,Contabilizada,IdProceso,IdColectivo,IdClienteUsuario,Observaciones,TmPreciocoste1,TmPreciocoste2,TmPrecioventa,TmImporteacuenta,TmImportecomision,TmModoFin,TmMesesPlazo,ImportePagos,PerfilUsuario,IdAsociacionPerfilUsuario,ImportePtePago,ComentariosPagos")] SutFacturas sutFacturas)
        {
            if (id != sutFacturas.IdFactura)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sutFacturas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SutFacturasExists(sutFacturas.IdFactura))
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
            return View(sutFacturas);
        }

        // GET: SutFacturas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sutFacturas = await _context.SutFacturas
                .FirstOrDefaultAsync(m => m.IdFactura == id);
            if (sutFacturas == null)
            {
                return NotFound();
            }

            return View(sutFacturas);
        }

        // POST: SutFacturas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sutFacturas = await _context.SutFacturas.FindAsync(id);
            if (sutFacturas != null)
            {
                _context.SutFacturas.Remove(sutFacturas);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SutFacturasExists(int id)
        {
            return _context.SutFacturas.Any(e => e.IdFactura == id);
        }
    }
}
