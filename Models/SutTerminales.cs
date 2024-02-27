using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutTerminales
{
    public int IdTerminal { get; set; }

    public int IdLinea { get; set; }

    public DateTime? FechaCompra { get; set; }

    public decimal? ImporteCompra { get; set; }

    public string? Imei { get; set; }

    public string? Estado { get; set; }

    public string? Modelo { get; set; }

    public string? Fabricante { get; set; }

    public int? IdOperacion { get; set; }

    public DateTime? FechaEstado { get; set; }

    public string? Comentario { get; set; }

    public short? Botiquin { get; set; }

    public int? IdReparacion { get; set; }

    public int? IdAdminCreador { get; set; }

    public short? TerminalIrreparable { get; set; }

    public DateTime? FechaTerminalIrreparable { get; set; }

    public virtual SutLineas IdLineaNavigation { get; set; } = null!;

    public virtual SutPuntos? IdOperacionNavigation { get; set; }

    public virtual ICollection<SutCompromisos> SutCompromisos { get; set; } = new List<SutCompromisos>();
}
