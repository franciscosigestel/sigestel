using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ProvFicherosAdjuntos
{
    public int IdFichero { get; set; }

    public int IdLinea { get; set; }

    public int IdPeticion { get; set; }

    public string? NombreFichero { get; set; }

    public string? RutaServidor { get; set; }

    public DateTime? FechaAlta { get; set; }
}
