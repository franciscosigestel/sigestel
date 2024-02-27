using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutPerfilasociacionUsuario
{
    public int IdPerfilUsuario { get; set; }

    public int IdColectivo { get; set; }

    public string CodPerfil { get; set; } = null!;

    public string LiteralPerfil { get; set; } = null!;

    public string? DescPerfil { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? NOrden { get; set; }

    public string? TextoAviso { get; set; }

    public string? LiteralPerfilparaComunicaciones { get; set; }

    public short? FidelizacionEura { get; set; }

    public decimal? BolsaEura { get; set; }
}
