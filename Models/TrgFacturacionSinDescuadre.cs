using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgFacturacionSinDescuadre
{
    public int IdFacturacionSinDescuadre { get; set; }

    public string? NfacturaInterna { get; set; }

    public string? Ntelefono { get; set; }

    public string? CodProdConcepFact { get; set; }

    public string? ImporteEstandar { get; set; }

    public string? ImporteAm { get; set; }
}
