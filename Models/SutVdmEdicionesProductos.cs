using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutVdmEdicionesProductos
{
    public int IdEdicion { get; set; }

    public string NombreProducto { get; set; } = null!;

    public string DescProducto { get; set; } = null!;

    public string? CodEdicion { get; set; }

    public string NombreEdicion { get; set; } = null!;

    public string TipoUnidad { get; set; } = null!;

    public decimal ImporteUnidad { get; set; }

    public string EstadoEdicion { get; set; } = null!;

    public DateTime FechaEstadoEdicion { get; set; }

    public string ClaveConsumidorProducto { get; set; } = null!;

    public string SecretoConsumidorProducto { get; set; } = null!;

    public string? Aplicacion { get; set; }
}
