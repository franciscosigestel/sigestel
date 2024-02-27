using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgVwDescuentosMoviles
{
    public string LibNfactura { get; set; } = null!;

    public string FechFactura { get; set; } = null!;

    public string TotalDescuentos { get; set; } = null!;
}
