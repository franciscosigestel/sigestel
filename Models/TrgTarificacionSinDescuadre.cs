using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgTarificacionSinDescuadre
{
    public int IdTarificacionSinDescuadre { get; set; }

    public string? NfacturaInterna { get; set; }

    public string? AmbitoLlamada { get; set; }

    public string? Origen { get; set; }

    public string? Destino { get; set; }

    public string? Tarifa { get; set; }

    public string? ImporteEstandar { get; set; }

    public string? ImporteAm { get; set; }
}
