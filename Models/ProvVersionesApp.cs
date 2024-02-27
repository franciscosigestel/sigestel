using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ProvVersionesApp
{
    public int IdVersion { get; set; }

    public string? NombreApp { get; set; }

    public string? Version { get; set; }

    public string? Fichero { get; set; }

    public string? Ruta { get; set; }

    public string? Descripcion { get; set; }

    public string? Estado { get; set; }
}
