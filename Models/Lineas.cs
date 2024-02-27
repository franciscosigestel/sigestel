using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class Lineas
{
    public string NTelfConex { get; set; } = null!;

    public string? FechaAlta { get; set; }

    public string? Direccion { get; set; }

    public string? Tipo { get; set; }

    public string? Subtipo { get; set; }

    public string? Extension { get; set; }

    public int? IdFuncional { get; set; }

    public string? Descripcion { get; set; }

    public string? Estado { get; set; }

    public int? IdCentroFisicoTa { get; set; }

    public int? IdOperadora { get; set; }

    public string? FechaAltaOp { get; set; }

    public string? FechaBajaOp { get; set; }

    public string? TipoServicio { get; set; }

    public string? FechaVigencia { get; set; }

    public string? Sim { get; set; }

    public string? Limite { get; set; }

    public string? Compromiso { get; set; }

    public string? TarifaPvoz { get; set; }

    public string? TarifaPdatos { get; set; }

    public string? CodMulticonex { get; set; }

    public string? Distancia { get; set; }

    public int? IdCentroFisicoTb { get; set; }

    public bool? ModificaFichero { get; set; }

    public bool? ModificadoAplicacion { get; set; }

    public bool? Act { get; set; }
}
