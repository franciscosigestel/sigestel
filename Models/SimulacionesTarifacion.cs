using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SimulacionesTarifacion
{
    public string? Nfactura { get; set; }

    public int? Operador1 { get; set; }

    public int? Operador2 { get; set; }

    public string? Precio1 { get; set; }

    public string? Precio2 { get; set; }

    public string? Fecha { get; set; }

    public string? HoraInicio { get; set; }

    public string? Parametros { get; set; }

    public string? Parametros2 { get; set; }

    public int? IdEmpresa { get; set; }
}
