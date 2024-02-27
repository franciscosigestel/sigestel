using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ScctPaises
{
    public string CodPais { get; set; } = null!;

    public string DesPais { get; set; } = null!;

    public int? IdOperadora { get; set; }

    public int? IdConcepto { get; set; }
}
