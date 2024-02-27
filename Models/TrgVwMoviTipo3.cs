using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgVwMoviTipo3
{
    public string Nivel { get; set; } = null!;

    public string Operador { get; set; } = null!;

    public string CifCliente { get; set; } = null!;

    public string IdFactura { get; set; } = null!;

    public string IdAgrupacion { get; set; } = null!;

    public string IdTelefono { get; set; } = null!;

    public double? Cuotas { get; set; }

    public string Consumos { get; set; } = null!;

    public double? Descuentos { get; set; }

    public double? Otros { get; set; }

    public double? BaseImponible { get; set; }

    public double? Impuestos { get; set; }

    public double? Total { get; set; }

    public string TipoImpuesto { get; set; } = null!;

    public string Aplicacion { get; set; } = null!;

    public string Porcentaje { get; set; } = null!;

    public string FechaFactura { get; set; } = null!;

    public string CifProveedor { get; set; } = null!;

    public string Descripcion { get; set; } = null!;
}
