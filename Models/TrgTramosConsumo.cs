using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgTramosConsumo
{
    public int? IdTramo { get; set; }

    public int? Inferior { get; set; }

    public int? Superior { get; set; }

    public string? DescTramo { get; set; }
}
