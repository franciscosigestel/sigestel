using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutFichAdjuntos
{
    public int IdFichero { get; set; }

    public int? IdLinea { get; set; }

    public int? IdPeticion { get; set; }

    public string NombreFichero { get; set; } = null!;

    public string RutaServidor { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public virtual SutLineas? IdLineaNavigation { get; set; }

    public virtual SutPeticionesIncidencias? IdPeticionNavigation { get; set; }
}
