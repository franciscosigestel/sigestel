using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class MovilCuotasyVarios
{
    public string? DescripcionCuota { get; set; }

    public int? Anio { get; set; }

    public int? Mes { get; set; }

    public double? Importe { get; set; }

    public string Nfactura { get; set; } = null!;

    public string Ntelefono { get; set; } = null!;

    public string Nextension { get; set; } = null!;

    public string? Finicio { get; set; }

    public string? Descripcion { get; set; }

    public string? DescVario { get; set; }

    public string? ImporteVario { get; set; }

    public string? CodigoVario { get; set; }

    public string DescuentoCuotas { get; set; } = null!;

    public string DescuentoServicio { get; set; } = null!;

    public string Cif { get; set; } = null!;
}
