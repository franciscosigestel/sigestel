using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutRegistrovbp
{
    public int IdregistroVbp { get; set; }

    public int? Idcolectivo { get; set; }

    public int? Idlinea { get; set; }

    public int? Idusuario { get; set; }

    public string? Movil { get; set; }

    public string? UsrEmail { get; set; }

    public string? ProductId { get; set; }

    public string? ServiceList { get; set; }

    public decimal? Importe { get; set; }

    public string? Estado { get; set; }

    public string? EstadoAnterior { get; set; }

    public DateTime? FechaEntrada { get; set; }

    public DateTime? FechaProcesoSuscrip { get; set; }

    public DateTime? FechaProcesoDesuscrip { get; set; }

    public DateTime? FechaUltimaRenovacion { get; set; }

    public DateTime? FechaEstado { get; set; }

    public string? UltimoCodigoRespuesta { get; set; }

    public string? UltimoCodigoRetornado { get; set; }

    public string? ServiceId { get; set; }

    public string? MovilUserId { get; set; }

    public string? DescripcionError { get; set; }

    public DateTime? FechaLanzamientoSuscrip { get; set; }

    public string? Aplicacion { get; set; }
}
