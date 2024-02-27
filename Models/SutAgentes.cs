using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutAgentes
{
    public int IdAgente { get; set; }

    public string? Nifagente { get; set; }

    public string? NombreAgente { get; set; }

    public string? Direccion { get; set; }

    public string? CodPostal { get; set; }

    public string? Poblacion { get; set; }

    public string? Provincia { get; set; }

    public string? TelMovil { get; set; }

    public string? Email { get; set; }

    public string? Captacion { get; set; }

    public decimal? ImpCaptacion { get; set; }

    public string? Desarrollo { get; set; }

    public decimal? ImpDesarrollo { get; set; }

    public string? InfoAdicional { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaEstado { get; set; }

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public DateTime? FechaModif { get; set; }
}
