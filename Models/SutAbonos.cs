using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutAbonos
{
    public int Idabono { get; set; }

    public int Idcliente { get; set; }

    public string Ciclo { get; set; } = null!;

    public DateTime FechaEntrada { get; set; }

    public string? RefAbono { get; set; }

    public string Linea { get; set; } = null!;

    public string? Concepto { get; set; }

    public decimal Importe { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaEstado { get; set; }

    public string? FacturaAbono { get; set; }

    public int? Idadmin { get; set; }

    public string? TipoAbono { get; set; }

    public string? FechaHora { get; set; }

    public string? Destino { get; set; }

    public string? NoRecep { get; set; }

    public decimal? Duracion { get; set; }

    public DateTime? FechaDesde { get; set; }

    public DateTime? FechaHasta { get; set; }
}
