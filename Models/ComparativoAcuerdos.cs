using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ComparativoAcuerdos
{
    public int? CodOperador1 { get; set; }

    public int? CodOperador2 { get; set; }

    public string? Parametros1 { get; set; }

    public string? Parametros2 { get; set; }

    public string? Identificador1 { get; set; }

    public string? Identificador2 { get; set; }

    public int? Indicador { get; set; }

    public string? TipoEntrada { get; set; }

    public int? IdEmpresa { get; set; }
}
