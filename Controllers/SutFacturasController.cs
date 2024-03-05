using System;
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
        public async Task<IActionResult> Index(string empresaSeleccionada, string buscar, string ordenActual, int? numpag, string filtroActual, int? cantidadRegistros, string selectedEstado, string exportarExcel,string selectedCliente, string fechadesde, string fechahasta)
        {
            //-----------------RECUPERAR DATOS DE LA SESIÓN-----------------

            // Obtener la página actual de la sesión o establecerla en 1 si no hay valor en la sesión
            int paginaActual = numpag ?? HttpContext.Session.GetInt32("Numpag") ?? 1;

            // Obtener la cantidad de registros por página de la sesión o establecerla en 6 si no hay valor en la sesión
            int registrosPorPagina = cantidadRegistros ?? HttpContext.Session.GetInt32("CantidadRegistros") ?? 6;


            //Listado de todas las facturas de la bdd
            var facturas = from SutFacturas in _context.SutFacturas select SutFacturas;



            // ------------------FILTROS--------------------------------
            //si no hay nigun filtro activo se muestra el listado de forma natural pero si hay filtro...
            if (buscar != null || selectedEstado != null || selectedCliente != null || (!String.IsNullOrEmpty(fechadesde) && !String.IsNullOrEmpty(fechahasta)))
            {
                numpag = 1; // Resetear la página a 1 si se aplican filtros
            }
            else
            {
                // Usar filtros de la sesión si no se proporcionan nuevos filtros
                buscar = HttpContext.Session.GetString("FiltroBuscar") ?? filtroActual;
                selectedEstado = HttpContext.Session.GetString("FiltroEstado") ?? selectedEstado;
                selectedCliente = HttpContext.Session.GetString("FiltroCliente") ?? selectedCliente;
               
            }

            //if para num factura en la barra de búsqueda
            if (!String.IsNullOrEmpty(buscar))
            {
                facturas = facturas.Where(s => s.NumFactura!.Contains(buscar));

            }
            //if para banco seleccionado en el select
            if (!String.IsNullOrEmpty(selectedEstado))
            {
                facturas = facturas.Where(s => s.EstadoNorma19 == selectedEstado);
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


            //---------------------ÓRDENES DE MOSTRADO------------------------------

            //listados base de bancos y sus facturas
            ViewData["OrdenActual"] = ordenActual;
            ViewData["FiltroActual"] = buscar;

            //de forma genérica la tabla ordena de forma id descendente si le pinchamos activara la forma ascendente del switch
            ViewData["FiltroId"] = String.IsNullOrEmpty(ordenActual) ? "IdAscendente" : "IdDescendente";

            ViewData["FiltroFecha"] = ordenActual == "FechaAscendente" ? "FechaDescendente" : "FechaAscendente";

            //seleccionados por banco 
            ViewData["EstadoSeleccionado"] = selectedEstado;  

            //seleccionados por banco 
            ViewData["BancoSeleccionado"] = selectedCliente;


            switch (ordenActual)
            {
                case "FechaDescendente":
                    facturas = facturas.OrderByDescending(facturas => facturas.FechaFactura);
                    break;
                case "FechaAscendente":
                    facturas = facturas.OrderBy(facturas => facturas.FechaFactura);
                    break;
                case "IdAscendente":
                    facturas = facturas.OrderBy(facturas => facturas.IdFactura);
                    break;
                case "IdDescendente":
                default:
                    facturas = facturas.OrderByDescending(facturas => facturas.IdFactura);
                    break;
            }

            cantidadRegistros = cantidadRegistros ?? 6; //de base se enseñan 6 registros a no ser que el usuario quiera más


            var todosLosEstados = await _context.SutFacturas
                .Select(f => f.EstadoNorma19)
                .Distinct() //esto hace que no coja dos veces el mismo banco
                .ToListAsync();

            var todosLosClientes = await _context.SutFacturas
               .Select(f => f.TipoFactura)
               .Distinct() //esto hace que no coja dos veces el mismo cliente
               .ToListAsync();

            ViewData["Estados"] = new SelectList(todosLosEstados);
            ViewData["Clientes"] = new SelectList(todosLosClientes);


            //Variable con los registros o facturas actualmente mostradas

            var facturasMostradas = await Paginacion<SutFacturas>.CrearPaginacion(facturas.AsNoTracking(), paginaActual, registrosPorPagina);

            // Guardar la información de la página actual y la cantidad de registros en la sesión Y FILTROS TAMBIÉN
            HttpContext.Session.SetInt32("Numpag", paginaActual);
            HttpContext.Session.SetInt32("CantidadRegistros", registrosPorPagina);
            //---------------------GUARDAR FILTROS EN SESIÓN------------------------------


            if (!String.IsNullOrEmpty(buscar))
            {
                HttpContext.Session.SetString("FiltroBuscar", buscar);
            }
            else
            {
                HttpContext.Session.Remove("FiltroBuscar");
            }

            if (!String.IsNullOrEmpty(selectedEstado))
            {
                HttpContext.Session.SetString("FiltroEstado", selectedEstado);
            }
            else
            {
                HttpContext.Session.Remove("FiltroEstado");
            }

            if (!String.IsNullOrEmpty(selectedCliente))
            {
                HttpContext.Session.SetString("FiltroCliente", selectedCliente);
            }
            else
            {
                HttpContext.Session.Remove("FiltroCliente");
            }

            if (!String.IsNullOrEmpty(fechadesde) && !String.IsNullOrEmpty(fechahasta))
            {
                DateTime fechaSeleccionada = DateTime.Parse(fechadesde);
                DateTime fechaSeleccionada2 = DateTime.Parse(fechahasta);

                HttpContext.Session.SetString("FiltroFechaDesde", fechaSeleccionada.ToString("yyyy-MM-dd"));
                HttpContext.Session.SetString("FiltroFechaHasta", fechaSeleccionada2.ToString("yyyy-MM-dd"));
            }
            else
            {
                HttpContext.Session.Remove("FiltroFechaDesde");
                HttpContext.Session.Remove("FiltroFechaHasta");
            }

            //REFLEJAR FILTROS EN LOS INPUTS O SELECTS 
            // Luego, puedes agregar estas líneas para reflejar los valores de los filtros en las vistas.
            ViewData["FiltroBuscar"] = HttpContext.Session.GetString("FiltroBuscar");
            ViewData["FiltroEstado"] = HttpContext.Session.GetString("FiltroEstado");
            ViewData["FiltroCliente"] = HttpContext.Session.GetString("FiltroCliente");
            ViewData["FiltroFechaDesde"] = HttpContext.Session.GetString("FiltroFechaDesde");
            ViewData["FiltroFechaHasta"] = HttpContext.Session.GetString("FiltroFechaHasta");

            //-------------------MÉTODO EXCEL----------------------------

            if (!string.IsNullOrEmpty(exportarExcel))
            {
                
                return GenerarExcel("File" , facturasMostradas);
            }

            ViewData["CantidadRegistros"] = registrosPorPagina;

            //devolver las facturas
            return View(facturasMostradas);
        }

        // Método para exportar a Excel
        private FileResult GenerarExcel(string nombrearchivo, List<SutFacturas> facturas)
        {
           
            DataTable dt = new DataTable("Facturas");
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Id"),
                new DataColumn("Num_fac"),
                new DataColumn("Cliente"),
                new DataColumn("Fecha"),
                new DataColumn("Nombre"),
                new DataColumn("Importe"),
                new DataColumn("Estado")
            });

            foreach (var facturita in facturas)
            {
                dt.Rows.Add(facturita.IdFactura,
                            facturita.FechaFactura,
                            facturita.TipoFactura,
                             facturita.FechaFactura,
                              facturita.NombreBanco,
                               facturita.TotalFactura,
                               facturita.EstadoNorma19
                            );
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

        [HttpPost]
        public IActionResult LimpiarFiltros()
        {
            // Elimina todos los filtros de la sesión
            HttpContext.Session.Remove("FiltroBuscar");
            HttpContext.Session.Remove("FiltroEstado");
            HttpContext.Session.Remove("FiltroCliente");
            HttpContext.Session.Remove("FiltroFechaDesde");
            HttpContext.Session.Remove("FiltroFechaHasta");

            // Redirige a la acción principal
            return RedirectToAction("Index");
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
    }
}
