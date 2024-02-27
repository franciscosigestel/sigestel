using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgVdfPostVenta
{
    public int Idregistro { get; set; }

    public string? Tiporeg { get; set; }

    public string? Ciclo { get; set; }

    public string? FactNo { get; set; }

    public string? Telef { get; set; }

    public string? Servicio { get; set; }

    public string? DescripMat { get; set; }

    public string? Fecha { get; set; }

    public string? CosteServ { get; set; }

    public decimal? Descuento { get; set; }

    public decimal? Importe { get; set; }

    public string? TelefOld { get; set; }
}
