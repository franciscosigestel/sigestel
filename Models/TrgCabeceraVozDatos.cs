using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgCabeceraVozDatos
{
    public string Nfactura { get; set; } = null!;

    public string? Nfacturainterna { get; set; }

    public string Cif { get; set; } = null!;

    public decimal? Cuotamensual { get; set; }

    public decimal? Descuentos { get; set; }

    public decimal? Otrosabonos { get; set; }

    public decimal? Totalsinimpuestos { get; set; }

    public string Impuestos { get; set; } = null!;

    public decimal? Totalconimpuestos { get; set; }

    public DateTime? Fechafactura { get; set; }

    public decimal? Tipoimpositivo { get; set; }

    public string CodigoConcepto { get; set; } = null!;

    public int? Anio { get; set; }

    public int? Mes { get; set; }

    public int? Dia { get; set; }
}
