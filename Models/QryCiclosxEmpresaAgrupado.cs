using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class QryCiclosxEmpresaAgrupado
{
    public int? IdEmpresa { get; set; }

    public string? NifCif { get; set; }

    public string? Ciclo { get; set; }

    public string? Fechainicio { get; set; }

    public string? Fechafin { get; set; }
}
