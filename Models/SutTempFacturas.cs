using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutTempFacturas
{
    public int IdFactura { get; set; }

    public string NumFactura { get; set; } = null!;

    public decimal? BaseImponible { get; set; }

    public int? Iva { get; set; }

    public decimal? Impuesto { get; set; }

    public decimal? TotalFactura { get; set; }

    public DateTime FechaFactura { get; set; }

    public decimal? ImportePuntos { get; set; }

    public decimal? ImporteBruto { get; set; }

    public decimal? TotalDescuentos { get; set; }

    public string? Ciclo { get; set; }

    public string? TipoFactura { get; set; }

    public string? NombreBanco { get; set; }

    public string? NumCuenta { get; set; }

    public string? FactOtm { get; set; }

    public string? FechaInicio { get; set; }

    public string? FechaFin { get; set; }

    public string? Direccion { get; set; }

    public string? CodPostal { get; set; }

    public string? Poblacion { get; set; }

    public string? Provincia { get; set; }

    public string? EstadoNorma19 { get; set; }

    public DateTime? FechaCargo { get; set; }

    public string? FicheroNorma19 { get; set; }

    public string? EnlaceGenerado { get; set; }

    public string? Generacion { get; set; }

    public int? Contabilizada { get; set; }

    public int? IdProceso { get; set; }

    public int? IdColectivo { get; set; }

    public int? IdClienteUsuario { get; set; }

    public string? Observaciones { get; set; }

    public decimal? TmPreciocoste1 { get; set; }

    public decimal? TmPreciocoste2 { get; set; }

    public decimal? TmPrecioventa { get; set; }

    public decimal? TmImporteacuenta { get; set; }

    public decimal? TmImportecomision { get; set; }

    public short? TmModoFin { get; set; }

    public short? TmMesesPlazo { get; set; }

    public decimal? ImportePagos { get; set; }

    public string? PerfilUsuario { get; set; }

    public int? IdAsociacionPerfilUsuario { get; set; }

    public decimal? ImportePtePago { get; set; }

    public string? ComentariosPagos { get; set; }
}
