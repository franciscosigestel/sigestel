using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ProvTerminalesFinanciados
{
    public int IdfinanTf { get; set; }

    public string? IdAleatorio { get; set; }

    public string? CodigoMft { get; set; }

    public decimal? ImportebaseTf { get; set; }

    public decimal? ComisionTf { get; set; }

    public decimal? ImportefinanciadoTf { get; set; }

    public decimal? ImporteacuentaTf { get; set; }

    public int? NumerocuotasTf { get; set; }

    public decimal? ImportecuotaTf { get; set; }

    public decimal? ImportetotalTf { get; set; }

    public DateTime? FaltaTf { get; set; }

    public string? EstadoTf { get; set; }

    public DateTime? FestadoTf { get; set; }

    public int? IdAdminOperTf { get; set; }

    public string? GestionTf { get; set; }

    public int? IdColectivoTf { get; set; }

    public int? TipoMft { get; set; }

    public string? PerfilUsuario { get; set; }
}
