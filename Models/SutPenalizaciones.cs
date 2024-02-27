using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutPenalizaciones
{
    public int Id { get; set; }

    public int IdColectivo { get; set; }

    public string? TipoPenal { get; set; }

    public string? DescripPenal { get; set; }

    public string ModoPenal { get; set; } = null!;

    public int MesesPenal { get; set; }

    public decimal ImportePenal { get; set; }

    public string? Emisor { get; set; }

    public string? PerfilUsuario { get; set; }

    public int? MesesTramoFijo { get; set; }
}
