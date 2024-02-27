using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutAveriasTerminal
{
    public int Id { get; set; }

    public string CodAveria { get; set; } = null!;

    public string LiteralAveria { get; set; } = null!;

    public string DescAveria { get; set; } = null!;

    public string TipoAveria { get; set; } = null!;

    public short FueraGarantia { get; set; }
}
