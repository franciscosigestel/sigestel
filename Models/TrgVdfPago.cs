using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgVdfPago
{
    public int Idregistro { get; set; }

    public string? Tiporeg { get; set; }

    public string? Ciclo { get; set; }

    public string? FactNo { get; set; }

    public string? FormaPago { get; set; }

    public string? FechaVto { get; set; }

    public string? Refer { get; set; }

    public string? CtaIngreso { get; set; }

    public string? NoTarjeta { get; set; }

    public string? EntBancaria { get; set; }

    public string? NoCuenta { get; set; }
}
