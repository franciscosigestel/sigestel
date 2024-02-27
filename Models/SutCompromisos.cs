using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutCompromisos
{
    public int IdCompromiso { get; set; }

    public int? IdTerminal { get; set; }

    public int? IdLinea { get; set; }

    public int? IdServicio { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public DateTime FechaDesde { get; set; }

    public DateTime FechaHasta { get; set; }

    public decimal? ImporteTotal { get; set; }

    public DateTime? FechaBaja { get; set; }

    public decimal? ImporteExencion { get; set; }

    public DateTime? FechaExencion { get; set; }

    public string? ComentarioBaja { get; set; }

    public decimal? ImporteTdatos { get; set; }

    public string? ModoPenal { get; set; }

    public int? IdPosventa { get; set; }

    public string? Emisor { get; set; }

    public int? MesesTramoFijo { get; set; }

    public virtual SutLineas? IdLineaNavigation { get; set; }

    public virtual SutServicios? IdServicioNavigation { get; set; }

    public virtual SutTerminales? IdTerminalNavigation { get; set; }
}
