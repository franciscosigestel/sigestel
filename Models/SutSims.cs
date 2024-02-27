using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutSims
{
    public int IdSim { get; set; }

    public string NumSim { get; set; } = null!;

    public DateTime FechaActivacion { get; set; }

    public string PinOriginal { get; set; } = null!;

    public string Puk { get; set; } = null!;

    public DateTime? FechaBaja { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaEstado { get; set; }

    public int? IdLinea { get; set; }

    public string? InfoAdicional { get; set; }

    public int? IdAdminCreador { get; set; }

    public short? MultiSim { get; set; }

    public short? ESim { get; set; }

    public virtual SutLineas? IdLineaNavigation { get; set; }
}
