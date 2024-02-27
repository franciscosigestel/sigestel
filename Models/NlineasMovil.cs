using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class NlineasMovil
{
    public int? Anio { get; set; }

    public int? Mes { get; set; }

    public string? Empresa { get; set; }

    public DateTime? FechaFactura { get; set; }

    public int? LineasFijas { get; set; }

    public int? LineasMoviles { get; set; }

    public double? Cuota { get; set; }

    public double? Totalservicio { get; set; }

    public double? Varios { get; set; }

    public double? Descuentos { get; set; }

    public double? SumaTot { get; set; }

    public double? TotalImp { get; set; }

    public double? TotalPag { get; set; }

    public string Impuesto { get; set; } = null!;

    public double? Bimponible { get; set; }

    public string Tipo { get; set; } = null!;

    public string Cif { get; set; } = null!;

    public string CodFactura { get; set; } = null!;
}
