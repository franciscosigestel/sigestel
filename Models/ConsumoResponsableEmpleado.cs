using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ConsumoResponsableEmpleado
{
    public string Ntelefono { get; set; } = null!;

    public string? NombreEmpleado { get; set; }

    public string? Nombre { get; set; }

    public string? PrimerApellido { get; set; }

    public string? SegundoApellido { get; set; }

    public double? ImporteTotal { get; set; }

    public int? Anio { get; set; }

    public int? Mes { get; set; }

    public string? NombreResponsable { get; set; }

    public string Nextension { get; set; } = null!;

    public double? Cuotas { get; set; }

    public double? ServicioMedido { get; set; }

    public double? Varios { get; set; }

    public double? Descuentos { get; set; }

    public double? Total { get; set; }

    public double? Cargo { get; set; }

    public double? DescCuotas { get; set; }

    public double? DescServMedido { get; set; }

    public string? Descripcion { get; set; }

    public double? Llamadas { get; set; }

    public string? Unidades { get; set; }

    public double? Cantidad { get; set; }

    public double? Importe { get; set; }
}
