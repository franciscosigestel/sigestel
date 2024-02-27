using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class AcuerdosMarcoVirtuales
{
    public int Id { get; set; }

    public int Idempresa { get; set; }

    public int NumAcuerdoVirtual { get; set; }

    public string? DescAcuerdoVirtual { get; set; }

    public string? CuotasAcuerdoVirtual { get; set; }
}
