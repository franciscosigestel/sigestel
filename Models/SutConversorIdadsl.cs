using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutConversorIdadsl
{
    public int Id { get; set; }

    public int? Idcolectivo { get; set; }

    public string? CodigoAdslVf { get; set; }

    public string? CodigoAdslSg { get; set; }

    public string? Estado { get; set; }
}
