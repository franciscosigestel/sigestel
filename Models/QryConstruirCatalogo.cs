using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class QryConstruirCatalogo
{
    public int IdCat { get; set; }

    public string? EstadoCat { get; set; }

    public int IdTerm { get; set; }

    public int? IdColectivo { get; set; }

    public string? NombreTerm { get; set; }

    public string? GamaTerm { get; set; }

    public decimal? PrecioTerm { get; set; }

    public string? CategoriaTerm { get; set; }

    public string? ReferenciaTerm { get; set; }

    public string? CodTarifa { get; set; }

    public string? Descripcion { get; set; }

    public decimal? PrecioNeto { get; set; }

    public decimal? PrecioCoste { get; set; }

    public string? VolumenDatos { get; set; }

    public int? FranquiciaVoz { get; set; }

    public string? MargenTerminal { get; set; }

    public int? CodigoOperador { get; set; }

    public string? PerfilUsuario { get; set; }

    public string? SubvencionAlta { get; set; }

    public string? SubvencionUpsell { get; set; }

    public string? CodtarifaOperador { get; set; }

    public string? CuentaVf { get; set; }

    public decimal? PorcentajeDtoCatalogoOp { get; set; }

    public string? Informecatalogo { get; set; }
}
