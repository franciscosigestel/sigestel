using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class DetalleLlamadasMovistar
{
    public string? Ush { get; set; }

    public string? DescArea { get; set; }

    public string LlamadaCorporativa { get; set; } = null!;

    public string Nfactura { get; set; } = null!;

    public string Ntelefono { get; set; } = null!;

    public string Nextension { get; set; } = null!;

    public string Nllamado { get; set; } = null!;

    public string Codtrafico { get; set; } = null!;

    public string TipoTrafico { get; set; } = null!;

    public string Coddestino { get; set; } = null!;

    public string Tipodestino { get; set; } = null!;

    public int Operadororigen { get; set; }

    public string? Fecha { get; set; }

    public string? Horainicio { get; set; }

    public string Unidadmedida { get; set; } = null!;

    public double? Cantmedidaoriginada { get; set; }

    public double? Cantmedidarecibida { get; set; }

    public decimal? Importe { get; set; }

    public string Importedatos { get; set; } = null!;

    public string Franja { get; set; } = null!;

    public string Tarifa { get; set; } = null!;

    public string Operadordestino { get; set; } = null!;

    public string Codllamada { get; set; } = null!;

    public string Tipollamada { get; set; } = null!;

    public string? Mes { get; set; }

    public string? Dia { get; set; }

    public int? MesFactura { get; set; }

    public int? AnioFactura { get; set; }
}
