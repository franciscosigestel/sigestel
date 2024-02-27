using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutContactosVodafone
{
    public int IdComercialvd { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Sfid { get; set; }

    public string? Movil { get; set; }

    public string? Email { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaEstado { get; set; }
}
