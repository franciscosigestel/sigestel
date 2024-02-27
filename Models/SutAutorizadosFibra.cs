using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutAutorizadosFibra
{
    public int Id { get; set; }

    public string? NumFibra { get; set; }

    public string? NumFijo { get; set; }

    public int? IdColectivo { get; set; }

    public string? IdLineaAsociatel { get; set; }

    public string? NombreCompletoAutorizado { get; set; }

    public string? NifAutorizado { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaEstado { get; set; }

    public string? Direccion { get; set; }

    public string? CodPostal { get; set; }

    public string? Poblacion { get; set; }

    public string? Provincia { get; set; }

    public string? TlfnoContacto { get; set; }

    public string? EmailContacto { get; set; }
}
