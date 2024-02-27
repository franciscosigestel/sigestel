using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutDescargas
{
    public int IdDescarga { get; set; }

    public string? FactOtm { get; set; }

    public string? Ciclo { get; set; }

    public int? IdColectivo { get; set; }

    public string? NombreFichero { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string? IdentificadorDescarga { get; set; }

    public DateTime? FechaInicioDescarga { get; set; }

    public DateTime? FechaFinDescarga { get; set; }

    public int? NumDescargas { get; set; }

    public DateTime? FechaUltimaDescarga { get; set; }

    public string? IpUltimaDescarga { get; set; }
}
