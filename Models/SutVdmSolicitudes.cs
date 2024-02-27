using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutVdmSolicitudes
{
    public int IdSolicitud { get; set; }

    public string? IdCuenta { get; set; }

    public string? CodEdicion { get; set; }

    public int TotalUnidades { get; set; }

    public decimal ImporteTotal { get; set; }

    public DateTime FechaRegistro { get; set; }

    public DateTime? FechaProceso { get; set; }

    public string EstadoSolicitud { get; set; } = null!;

    public string? CodigoRespuesta { get; set; }

    public string? DescRespuesta { get; set; }
}
