using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutDocumentacion
{
    public int IdDocumento { get; set; }

    public int IdCliente { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Fichero { get; set; } = null!;

    public int? Orden { get; set; }

    public string? TipoDocumento { get; set; }

    public string? AmbitoDocumento { get; set; }

    public int? CodOperador { get; set; }

    public int? NivelAcceso { get; set; }
}
