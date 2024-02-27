using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgMvstr330
{
    public string TipoRegistro { get; set; } = null!;

    public string SecuenciaRegistro { get; set; } = null!;

    public string Nfactura { get; set; } = null!;

    public string Nprefactura { get; set; } = null!;

    public string Ntelefono { get; set; } = null!;

    public string Nextension { get; set; } = null!;

    public string CodigoTipoTrafico { get; set; } = null!;

    public string TipoTrafico { get; set; } = null!;

    public string CodAbreLlamada { get; set; } = null!;

    public string DescTipoLlamada { get; set; } = null!;

    public string CodDestino { get; set; } = null!;

    public string TipoDestino { get; set; } = null!;

    public string Operador { get; set; } = null!;

    public string Nllamado { get; set; } = null!;

    public string Fecha { get; set; } = null!;

    public string CodHorario { get; set; } = null!;

    public string HoraInicio { get; set; } = null!;

    public string UnidadMedida { get; set; } = null!;

    public string CantidadMedidaOrig { get; set; } = null!;

    public string CantidadMedidaRecib { get; set; } = null!;

    public string UnidadCalidad { get; set; } = null!;

    public string CalidadSuministrada { get; set; } = null!;

    public string Importe { get; set; } = null!;

    public string Libre { get; set; } = null!;

    public int? ExcedeLimiteDuracion { get; set; }
}
