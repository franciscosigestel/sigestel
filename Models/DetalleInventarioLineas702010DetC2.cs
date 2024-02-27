using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class DetalleInventarioLineas702010DetC2
{
    public string NSecuencial { get; set; } = null!;

    public string AmbitoLlamada { get; set; } = null!;

    public string OperadorProveedor { get; set; } = null!;

    public string NumeroLlamado { get; set; } = null!;

    public string Nsolicitado { get; set; } = null!;

    public string Destino { get; set; } = null!;

    public string Fllamada { get; set; } = null!;

    public string HoraInicio { get; set; } = null!;

    public string DuracionLlamada { get; set; } = null!;

    public string Tarifa { get; set; } = null!;

    public double? ImporteEstandar { get; set; }

    public string ImporteValor { get; set; } = null!;

    public string CodigoDescuento { get; set; } = null!;

    public string CodigoDescuentoPer { get; set; } = null!;

    public string LlamadaCorportativa { get; set; } = null!;

    public double? ImporteDescuento { get; set; }

    public string? Ush { get; set; }

    public string? DescProyecto { get; set; }
}
