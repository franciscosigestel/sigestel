using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class AcuerdosTarificacion
{
    public string Identificador { get; set; } = null!;

    public int IdOperadora { get; set; }

    public string TablaParametro { get; set; } = null!;

    public string ValParametro { get; set; } = null!;

    public string DescValParametro { get; set; } = null!;

    public string UnidadMedida { get; set; } = null!;

    public string Precio { get; set; } = null!;

    public string Sumar { get; set; } = null!;

    public string? TablaParametroEst { get; set; }

    public string? ValParametroEst { get; set; }

    public string? DescValParametroEst { get; set; }

    public string? ImporteEst { get; set; }

    public string? Parametros { get; set; }

    public string? FechaInicio { get; set; }

    public string? FechaFin { get; set; }

    public int IdEmpresa { get; set; }

    public int NumAcuerdoMarco { get; set; }

    public int? TieneCondiciones { get; set; }
}
