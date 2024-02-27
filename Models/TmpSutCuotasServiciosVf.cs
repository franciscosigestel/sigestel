using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TmpSutCuotasServiciosVf
{
    public string? Ciclo { get; set; }

    public int? Idc { get; set; }

    public int? Idl { get; set; }

    public int? Idu { get; set; }

    public string? Linea { get; set; }

    public DateTime? FaltaLinea { get; set; }

    public DateTime? FbajaLinea { get; set; }

    public string? EstadoLinea { get; set; }

    public string? Tipolinea { get; set; }

    public string? CodServicioSunit { get; set; }

    public string? LiteralServicioSunit { get; set; }

    public DateTime? FaltaServicio { get; set; }

    public DateTime? FbajaServicio { get; set; }

    public string? CuentaVf { get; set; }

    public string? CodtarifaOperador { get; set; }

    public string? Literalasociado { get; set; }

    public decimal? Precioneto { get; set; }

    public DateTime? FechaDesde { get; set; }

    public DateTime? FechaHasta { get; set; }

    public int? Dias { get; set; }

    public decimal? Importe { get; set; }

    public int? DiasCiclo { get; set; }
}
