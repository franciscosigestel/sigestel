using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutMovimientosEura
{
    public int IdOperacion { get; set; }

    public int IdColectivo { get; set; }

    public DateTime FechaMovimiento { get; set; }

    public decimal ImporteEura { get; set; }

    public string Tipo { get; set; } = null!;

    public string? DescOperacion { get; set; }

    public int IdAdmin { get; set; }

    public int? IdPosventa { get; set; }

    public int? IdProceso { get; set; }

    public string? PerfilUsuario { get; set; }
}
