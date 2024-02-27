using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgTeleTipo3
{
    public string? Nivel { get; set; }

    public string? Operador { get; set; }

    public string? CifCliente { get; set; }

    public string? IdFactura { get; set; }

    public string? IdAgrupacion { get; set; }

    public string? IdTelefono { get; set; }

    public double? Cuotas { get; set; }

    public double? Consumos { get; set; }

    public double? Descuentos { get; set; }

    public double? Otros { get; set; }

    public double? BaseImponible { get; set; }

    public double? Impuestos { get; set; }

    public double? Total { get; set; }

    public string? TipoImpuesto { get; set; }

    public string? Aplicacion { get; set; }

    public string? Porcentaje { get; set; }

    public string? FechaFactura { get; set; }

    public string? CifProveedor { get; set; }

    public string? Descripcion { get; set; }

    public string? FacturaInterna { get; set; }
}
