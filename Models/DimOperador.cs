using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class DimOperador
{
    public int OperadorKey { get; set; }

    public int? OperadorPkey { get; set; }

    public string? OperadorCod { get; set; }

    public string? OperadorPcod { get; set; }

    public string? OperadorDescripcion { get; set; }
}
