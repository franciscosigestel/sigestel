using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutGenerarFacturas
{
    public int IdgenerarFactura { get; set; }

    public int Idfactura { get; set; }

    public int Idcolectivo { get; set; }

    public string Ruta { get; set; } = null!;

    public DateTime FechaEntrada { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaProceso { get; set; }

    public int? NumIntentos { get; set; }

    public short Concatenar { get; set; }

    public short Parear { get; set; }

    public short Prioridad { get; set; }
}
