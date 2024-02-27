using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ProvModosFinanciacionTerminales
{
    public int IdMft { get; set; }

    public string? CodigoMft { get; set; }

    public int? Idcolectivo { get; set; }

    public string? LiteralMft { get; set; }

    public string? DescripcionMft { get; set; }

    public decimal? ComisionMft { get; set; }

    public int? PlazosMft { get; set; }

    public decimal? ImporteminMft { get; set; }

    public decimal? ImportemaxMft { get; set; }

    public DateTime? FaltaMft { get; set; }

    public string? EstadoMft { get; set; }

    public DateTime? FestadoMft { get; set; }

    public string? PerfilUsuario { get; set; }
}
