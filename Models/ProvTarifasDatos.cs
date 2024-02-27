using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ProvTarifasDatos
{
    public int IdTarifaDatos { get; set; }

    public int IdColectivo { get; set; }

    public int IdOperador { get; set; }

    public string CodTarifa { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal? PrecioBruto { get; set; }

    public decimal? DtoOperador { get; set; }

    public decimal? PrecioCoste { get; set; }

    public decimal? PrecioNeto { get; set; }

    public string? VolumenDatos { get; set; }

    public string? Estado { get; set; }

    public string? Categoriaterm { get; set; }

    public string? PerfilUsuario { get; set; }

    public string? SubvencionAlta { get; set; }

    public string? SubvencionUpsell { get; set; }

    public string? AtrboblBaja { get; set; }

    public string? AtrbopcAlta { get; set; }

    public string? LiteralAsociado { get; set; }

    public string? CuentaVf { get; set; }

    public string? CodtarifaOperador { get; set; }

    public string? SubTipo { get; set; }

    public int? TipoTarifa { get; set; }

    public string? PlanesPreciosPrincipales { get; set; }

    public int? MaxLineasAdicionales { get; set; }

    public string? ServiciosAdicionales { get; set; }
}
