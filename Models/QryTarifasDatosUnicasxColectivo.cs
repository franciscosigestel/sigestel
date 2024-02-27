using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class QryTarifasDatosUnicasxColectivo
{
    public int IdColectivo { get; set; }

    public string CodTarifa { get; set; } = null!;

    public decimal? PrecioCoste { get; set; }

    public string? CuentaVf { get; set; }

    public string? CodtarifaOperador { get; set; }
}
