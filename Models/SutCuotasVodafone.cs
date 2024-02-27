using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutCuotasVodafone
{
    public int IdColectivo { get; set; }

    public string CodOperador { get; set; } = null!;

    public string CodCuenta { get; set; } = null!;

    public string? LiteralAsociado { get; set; }

    public string? TipoTarifa { get; set; }

    public decimal? PrecioBruto { get; set; }

    public int? DtoOperador { get; set; }

    public decimal? PrecioNeto { get; set; }

    public DateTime Fechadesde { get; set; }

    public DateTime Fechahasta { get; set; }
}
