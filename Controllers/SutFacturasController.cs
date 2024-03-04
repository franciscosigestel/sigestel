﻿using System;
using sigestel.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sigestel.Models;
using sigestel.Tools;
using ClosedXML.Excel;
using System.Data;



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
         //GET: SutFacturas
        public async Task<IActionResult> Index(string empresaSeleccionada, string buscar, string ordenActual, int? numpag, string filtroActual, int? cantidadRegistros, string selectedBanco, string exportarExcel,string selectedCliente, string fechadesde, string fechahasta)
        {

            // Obtener la página actual de la sesión o establecerla en 1 si no hay valor en la sesión
            int paginaActual = numpag ?? HttpContext.Session.GetInt32("Numpag") ?? 1;

            // Obtener la cantidad de registros por página de la sesión o establecerla en 6 si no hay valor en la sesión
            int registrosPorPagina = cantidadRegistros ?? HttpContext.Session.GetInt32("CantidadRegistros") ?? 6;

            var facturas = from SutFacturas in _context.SutFacturas select SutFacturas;

            if (buscar != null)
            {
                numpag = 1;
            }
            else
            {
                buscar = filtroActual;
            }
            //if para nombre de bancos en la barra de búsqueda
            if (!String.IsNullOrEmpty(buscar))
            {
                facturas = facturas.Where(s => s.NombreBanco!.Contains(buscar));
                //Guardar filtro en la sesion
                HttpContext.Session.SetString("FiltroActual", filtroActual);

            }
            //if para banco seleccionado en el select
            if (!String.IsNullOrEmpty(selectedBanco))
            {
                facturas = facturas.Where(s => s.NombreBanco == selectedBanco);
            }

            //if para cliente seleccionado en el select
            if (!String.IsNullOrEmpty(selectedCliente))
            {
                facturas = facturas.Where(s => s.TipoFactura == selectedCliente);
            }

            //if para cliente seleccionado en el select
            if (!String.IsNullOrEmpty(fechadesde) && !String.IsNullOrEmpty(fechahasta))
            {

                DateTime fechaSeleccionada = DateTime.Parse(fechadesde);
                DateTime fechaSeleccionada2 = DateTime.Parse(fechahasta);

                // Obtener todas las facturas de la fecha seleccionada
                var facturasFecha = facturas.Where(s => s.FechaFactura.Date >= fechaSeleccionada.Date && s.FechaFactura.Date <= fechaSeleccionada2.Date);

                // Comparar solo la fecha sin tener en cuenta la hora, minutos y segundos
                facturas = facturas.Where(s => s.FechaFactura.Date >= fechaSeleccionada.Date && s.FechaFactura.Date <= fechaSeleccionada2.Date);
            }

            //listados base de bancos y sus facturas
            ViewData["OrdenActual"] = ordenActual;
            ViewData["FiltroActual"] = buscar;

            ViewData["FiltroNombre"] = String.IsNullOrEmpty(ordenActual) ? "NombreDescendente" : "";
            ViewData["FiltroFecha"] = ordenActual == "FechaAscendente" ? "FechaDescendente" : "FechaAscendente";

            //seleccionados por banco 
            ViewData["BancoSeleccionado"] = selectedBanco;

            //seleccionados por banco 
            ViewData["BancoSeleccionado"] = selectedCliente;


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
                    facturas = facturas.OrderBy(facturas => facturas.IdFactura);
                    break;
            }
            cantidadRegistros = cantidadRegistros ?? 6; //de base se enseñan 6 registros a no ser que el usuario quiera más


            var todosLosBancos = await _context.SutFacturas
                .Select(f => f.NombreBanco)
                .Distinct() //esto hace que no coja dos veces el mismo banco
                .ToListAsync();

            var todosLosClientes = await _context.SutFacturas
               .Select(f => f.TipoFactura)
               .Distinct() //esto hace que no coja dos veces el mismo banco
               .ToListAsync();

            ViewData["Bancos"] = new SelectList(todosLosBancos);
            ViewData["Clientes"] = new SelectList(todosLosClientes);


            //Variable con los registros o facturas actualmente mostradas

            var facturasMostradas = await Paginacion<SutFacturas>.CrearPaginacion(facturas.AsNoTracking(), paginaActual, registrosPorPagina);

            // Guardar la información de la página actual y la cantidad de registros en la sesión
            HttpContext.Session.SetInt32("Numpag", paginaActual);
            HttpContext.Session.SetInt32("CantidadRegistros", registrosPorPagina);

            if (!string.IsNullOrEmpty(exportarExcel))
            {
                
                return GenerarExcel("File" , facturasMostradas);
            }

            ViewData["CantidadRegistros"] = registrosPorPagina;

            return View(facturasMostradas);
        }

        // Método para exportar a Excel
        private FileResult GenerarExcel(string nombrearchivo, List<SutFacturas> facturas)
        {
           
            DataTable dt = new DataTable("Facturas");
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("NombreBanco"),
                new DataColumn("FechaFactura"),
                new DataColumn("IdFactura")
            });

            foreach (var facturita in facturas)
            {
                dt.Rows.Add(facturita.NombreBanco ?? string.Empty,
                            facturita.FechaFactura,
                            facturita.IdFactura);
            }

            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt);

                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                                nombrearchivo + ".xlsx");
                }
            }
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
