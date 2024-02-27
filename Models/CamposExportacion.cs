using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class CamposExportacion
{
    public string Nocamp { get; set; } = null!;

    public string Ticamp { get; set; } = null!;

    public int Ordenv { get; set; }

    public string Tacamp { get; set; } = null!;

    public string? Carrel { get; set; }

    public bool? Imcamp { get; set; }
}
