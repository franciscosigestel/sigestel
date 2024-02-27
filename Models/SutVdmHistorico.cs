using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutVdmHistorico
{
    public int IdRegistro { get; set; }

    public int? IdColectivo { get; set; }

    public int? IdLinea { get; set; }

    public int IdEdicion { get; set; }

    public string IdClienteVdm { get; set; } = null!;

    public string? NumMovil { get; set; }

    public decimal Importe { get; set; }

    public string Estado { get; set; } = null!;

    public DateTime FechaEstado { get; set; }

    public DateTime FechaEntrada { get; set; }

    public DateTime? FechaPasoVdm { get; set; }

    public DateTime? FechaUltimaSolicitud { get; set; }

    public int? IdSolicitudLastVdm { get; set; }

    public string? Aplicacion { get; set; }

    public DateTime? FechaLanzamiento { get; set; }

    public string? Comentarios { get; set; }
}
