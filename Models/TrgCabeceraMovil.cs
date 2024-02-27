using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgCabeceraMovil
{
    public string Nfactura { get; set; } = null!;

    public decimal? Cuotamensual { get; set; }

    public decimal? Otrascuotas { get; set; }

    public decimal? Consumo { get; set; }

    public decimal? Descuentos { get; set; }

    public decimal? Otrosabonos { get; set; }

    public decimal? Otroscargos { get; set; }

    public decimal? Totalsinimpuestos { get; set; }

    public decimal? Impuestos { get; set; }

    public decimal? Totalconimpuestos { get; set; }

    public DateTime? Fechafactura { get; set; }

    public string? Tipoimpositivo { get; set; }

    public string Operador { get; set; } = null!;

    public string? Cif { get; set; }

    public int? Anio { get; set; }

    public int? Mes { get; set; }

    public int? Dia { get; set; }

    public decimal? Facturacion { get; set; }

    public int Concepto { get; set; }
}
