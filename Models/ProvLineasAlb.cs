using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ProvLineasAlb
{
    public int IdLineaalb { get; set; }

    public int IdAlb { get; set; }

    public string NumTelefonoAlb { get; set; } = null!;

    public string? SimAlb { get; set; }

    public string? TerminalAlb { get; set; }

    public string? ImeiAlb { get; set; }

    public int? IdclienteLinea { get; set; }

    public int? IdOrdenPosventa { get; set; }
}
