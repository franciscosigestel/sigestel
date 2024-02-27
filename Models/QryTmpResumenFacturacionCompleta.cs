using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class QryTmpResumenFacturacionCompleta
{
    public int? IdEmpresa { get; set; }

    public string? NifCif { get; set; }

    public string? Fechainicio { get; set; }

    public string? Fechafin { get; set; }

    public string? Ciclo { get; set; }

    public string? Telef { get; set; }

    public int? IdLinea { get; set; }

    public decimal? ImpCuota { get; set; }

    public decimal? DesCuota { get; set; }

    public decimal? ImpConsumo { get; set; }

    public decimal? DesConsumo { get; set; }

    public decimal? Total { get; set; }

    public int? IdUsuarioLin { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public string? TipoLinea { get; set; }

    public string? ExtNumTelefono { get; set; }

    public string? Telef3 { get; set; }
}
