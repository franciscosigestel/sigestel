using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgDescuentosSinDescuadre
{
    public int IdDescuentoSinDescuadre { get; set; }

    public string? NfacturaInterna { get; set; }

    public string? CodDescuento850 { get; set; }

    public string? ImpDescuento850 { get; set; }

    public string? ImpDescuentoAm { get; set; }
}
