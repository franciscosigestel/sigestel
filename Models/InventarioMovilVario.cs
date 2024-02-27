using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class InventarioMovilVario
{
    public string Ntelefono { get; set; } = null!;

    public string Nprefactura { get; set; } = null!;

    public string Nextension { get; set; } = null!;

    public int? Anio { get; set; }

    public int? Mes { get; set; }

    public string Nfactura { get; set; } = null!;

    public double? Importe { get; set; }

    public string CodigoVario { get; set; } = null!;

    public string DescVario { get; set; } = null!;

    public string Cif { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? PrecioLimite { get; set; }

    public string? PrecioMaximo { get; set; }

    public string? LimiteConsumo { get; set; }

    public DateTime? FechaFactura { get; set; }
}
