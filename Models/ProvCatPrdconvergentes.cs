using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ProvCatPrdconvergentes
{
    public int IdCatpc { get; set; }

    public string CodigoCatpc { get; set; } = null!;

    public int Idcolectivo { get; set; }

    public string Perfilusuario { get; set; } = null!;

    public string NombreCpc { get; set; } = null!;

    public string? DescripcionCpc { get; set; }

    public DateTime FaltaCpc { get; set; }

    public string EstadoCpc { get; set; } = null!;

    public DateTime FestadoCpc { get; set; }

    public DateTime? FbajaCpc { get; set; }

    public string? PlanprincipalCpc { get; set; }

    public int? NumSubproductosCpc { get; set; }

    public string? SubproductosCpc { get; set; }

    public decimal? PrecioCpc { get; set; }

    public string? AtributosAltaCpc { get; set; }

    public decimal? SubvencionCpc { get; set; }

    public short? PenalizacionCpc { get; set; }

    public string? ComentariosInternosCpc { get; set; }
}
