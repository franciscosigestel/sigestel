using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ProvTerminales
{
    public int IdTerm { get; set; }

    public string? ImagenTerm { get; set; }

    public string? FabricanteTerm { get; set; }

    public string? NombreTerm { get; set; }

    public DateTime? FechaaltaTerm { get; set; }

    public string? EstadoTerm { get; set; }

    public DateTime? FechaestadoTerm { get; set; }

    public string? GamaTerm { get; set; }

    public string? SoTerm { get; set; }

    public string? GpsTerm { get; set; }

    public string? WifiTerm { get; set; }

    public string? CamaraTerm { get; set; }

    public string? BluetoothTerm { get; set; }

    public string? MeminternaTerm { get; set; }

    public string? SdTerm { get; set; }

    public string? RadiofmTerm { get; set; }

    public string? PantallaTerm { get; set; }

    public string? FijoTerm { get; set; }

    public string? ProcesadorTerm { get; set; }

    public decimal? PrecioTerm { get; set; }

    public decimal? PrecioTermPe { get; set; }

    public string? ReferenciaTerm { get; set; }

    public string? ObservacionesTerm { get; set; }

    public string? CategoriaTerm { get; set; }

    public short? Codoperador { get; set; }

    public DateTime? FechaFinSwapTerm { get; set; }
}
