using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class InvarioVozTrafico
{
    public string NComercial1 { get; set; } = null!;

    public string? DescAmbitoLlamada { get; set; }

    public int? NumLlamadas { get; set; }

    public string DomicilioTa { get; set; } = null!;

    public string PoblacionTa { get; set; } = null!;

    public string DescServicio { get; set; } = null!;

    public string AmbitoLlamada { get; set; } = null!;

    public string? Ush { get; set; }

    public string? DescProyecto { get; set; }

    public string LlamadaCorportativa { get; set; } = null!;

    public int? DuracionLlamadasSeg { get; set; }

    public int? Anio { get; set; }

    public int? Mes { get; set; }

    public double? ImpEstandar { get; set; }

    public double? ImpDescuento { get; set; }

    public string? Empresa { get; set; }

    public string OperadorProveedor { get; set; } = null!;

    public string NumeroLlamado { get; set; } = null!;
}
