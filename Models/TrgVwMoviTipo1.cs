using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgVwMoviTipo1
{
    public string Nivel { get; set; } = null!;

    public string Operador { get; set; } = null!;

    public string CifCliente { get; set; } = null!;

    public string IdFactura { get; set; } = null!;

    public string IdAgrupacion { get; set; } = null!;

    public string IdTelefono { get; set; } = null!;

    public string Cuotas { get; set; } = null!;

    public string Consumos { get; set; } = null!;

    public string Descuentos { get; set; } = null!;

    public string Otros { get; set; } = null!;

    public string BaseImponible { get; set; } = null!;

    public string Impuestos { get; set; } = null!;

    public string Total { get; set; } = null!;

    public string TipoImpuesto { get; set; } = null!;

    public string Aplicacion { get; set; } = null!;

    public string Porcentaje { get; set; } = null!;

    public string? FechaFactura { get; set; }

    public string CifProveedor { get; set; } = null!;

    public string Descripcion { get; set; } = null!;
}
