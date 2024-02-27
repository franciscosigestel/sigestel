using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutPromociones
{
    public int IdPromocion { get; set; }

    public string? Texto { get; set; }

    public string? Imagen { get; set; }

    public string? Url { get; set; }

    public int? IdColectivo { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public short? Predeterminado { get; set; }

    public short? EsAviso { get; set; }
}
