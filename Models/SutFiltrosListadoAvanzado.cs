using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutFiltrosListadoAvanzado
{
    public int IdFiltro { get; set; }

    public int IdColectivo { get; set; }

    public int IdAdminCreador { get; set; }

    public string NombreFiltro { get; set; } = null!;

    public string? Filtros { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaEstado { get; set; }

    public int? IdAdminModif { get; set; }

    public string? Campos { get; set; }
}
