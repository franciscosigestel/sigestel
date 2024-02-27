using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgVdfDetalleOtrasCuotas
{
    public int Idregistro { get; set; }

    public string? Tiporeg { get; set; }

    public string? Ciclo { get; set; }

    public string? FactNo { get; set; }

    public string? Telef { get; set; }

    public string? DescripCuota { get; set; }

    public int? Unidades { get; set; }

    public string? Porcentaje { get; set; }

    public decimal? Importe { get; set; }

    public string? TelefOld { get; set; }
}
