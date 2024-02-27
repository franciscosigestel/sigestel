using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgVwTeleTipo1
{
    public string Nivel { get; set; } = null!;

    public string Operador { get; set; } = null!;

    public string? CifCliente { get; set; }

    public string? IdFactura { get; set; }

    public string IdAgrupacion { get; set; } = null!;

    public string IdTelefono { get; set; } = null!;

    public double? Cuotas { get; set; }

    public double? Consumos { get; set; }

    public double? Descuentos { get; set; }

    public double? Otros { get; set; }

    public double? BaseImponible { get; set; }

    public double? Impuestos { get; set; }

    public string Total { get; set; } = null!;

    public string? TipoImpuesto { get; set; }

    public string? Aplicacion { get; set; }

    public string? Porcentaje { get; set; }

    public string FechaFactura { get; set; } = null!;

    public string? CifProveedor { get; set; }

    public string Descripcion { get; set; } = null!;
}
