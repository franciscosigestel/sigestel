using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgConsumoPorEmpleado
{
    public double? ImporteTotal { get; set; }

    public string Nfactura { get; set; } = null!;

    public string? NTelfConex { get; set; }

    public string? Tipo { get; set; }

    public string? MarcAbrev { get; set; }

    public string? Ush { get; set; }

    public string? Area { get; set; }

    public string? NombreEmpleado { get; set; }

    public string? DescArea { get; set; }

    public int? Anio { get; set; }

    public int? Mes { get; set; }

    public string? DescProyecto { get; set; }

    public string Ntelefono { get; set; } = null!;

    public string? IdEmpleado { get; set; }

    public string Nextension { get; set; } = null!;

    public double? Cuotas { get; set; }

    public double? ServicioMedido { get; set; }

    public double? Varios { get; set; }

    public double? Descuentos { get; set; }

    public double? Total { get; set; }

    public double? Cargo { get; set; }

    public double? DescCuotas { get; set; }

    public double? DescServMedido { get; set; }
}
