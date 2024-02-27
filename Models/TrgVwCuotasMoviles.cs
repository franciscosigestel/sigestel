using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgVwCuotasMoviles
{
    public string? Nfactura { get; set; }

    public string? Ntelefono { get; set; }

    public string Nextension { get; set; } = null!;

    public string? Finicio { get; set; }

    public string? Ffin { get; set; }

    public string CodigoCuota { get; set; } = null!;

    public string? DescripcionCuota { get; set; }

    public decimal? Importe { get; set; }

    public string IdOperador { get; set; } = null!;

    public int? Contador { get; set; }
}
