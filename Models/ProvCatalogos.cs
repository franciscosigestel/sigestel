using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ProvCatalogos
{
    public int IdCat { get; set; }

    public string? NombreCat { get; set; }

    public DateTime? FechaaltaCat { get; set; }

    public string? EstadoCat { get; set; }

    public DateTime? FechaestadoCat { get; set; }

    public decimal? Franquicia { get; set; }

    public decimal? CosteAdicional { get; set; }

    public string? InfoAdicional { get; set; }

    public short? Codoperador { get; set; }

    public string? Informecatalogo { get; set; }
}
