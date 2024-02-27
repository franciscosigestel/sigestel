using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ProvDocumentosCt
{
    public int IdDocumento { get; set; }

    public int IdColectivo { get; set; }

    public string NumTelefono { get; set; } = null!;

    public string NombreFichero { get; set; } = null!;

    public string RutaServidor { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public int IdAdminCreador { get; set; }
}
