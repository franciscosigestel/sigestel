using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class VdfConsumosFibra
{
    public string? IdCliente { get; set; }

    public string? NumeroGeografico { get; set; }

    public string? TlfnoLlamado { get; set; }

    public string? TipoEvento { get; set; }

    public DateTime FechaEvento { get; set; }

    public TimeOnly? HoraEvento { get; set; }

    public string? DestinoGeneral { get; set; }

    public string? Destino { get; set; }

    public int? Duracion { get; set; }

    public decimal? Importe { get; set; }

    public string? FechaGrabacion { get; set; }
}
