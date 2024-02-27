using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgDetalleMovil
{
    public string Nfactura { get; set; } = null!;

    public string? Ntelefono { get; set; }

    public string? Nextension { get; set; }

    public string? Nllamado { get; set; }

    public string? Codtrafico { get; set; }

    public string? Tipotrafico { get; set; }

    public string? Coddestino { get; set; }

    public string? Tipodestino { get; set; }

    public int Operadororigen { get; set; }

    public string? Fecha { get; set; }

    public string? Horainicio { get; set; }

    public string Unidadmedida { get; set; } = null!;

    public string? Cantmedidaoriginada { get; set; }

    public string? Cantmedidarecibida { get; set; }

    public decimal? Importe { get; set; }

    public decimal? Importedatos { get; set; }

    public string Franja { get; set; } = null!;

    public string? Tarifa { get; set; }

    public string? Duracion { get; set; }

    public string? Duraciondatos { get; set; }

    public string? Operadordestino { get; set; }

    public string? Codllamada { get; set; }

    public string? Tipollamada { get; set; }

    public int? Anio { get; set; }

    public int? Mes { get; set; }

    public int? Dia { get; set; }

    public string? Codproyecto { get; set; }

    public string? Cif { get; set; }
}
