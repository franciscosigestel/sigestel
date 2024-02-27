using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class InventarioMovilCuotas
{
    public string? CodigoVario { get; set; }

    public string? DescVario { get; set; }

    public string? Descripcion { get; set; }

    public string Finicio { get; set; } = null!;

    public string CodigoCuota { get; set; } = null!;

    public string DescripcionCuota { get; set; } = null!;

    public string Ntelefono { get; set; } = null!;

    public string Nprefactura { get; set; } = null!;

    public string Nextension { get; set; } = null!;

    public string? Ush { get; set; }

    public string? DescArea { get; set; }

    public int? Anio { get; set; }

    public int? Mes { get; set; }

    public string Nfactura { get; set; } = null!;

    public double? Importe { get; set; }
}
