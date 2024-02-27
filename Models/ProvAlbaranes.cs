using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ProvAlbaranes
{
    public int IdAlb { get; set; }

    public DateTime FechaAlb { get; set; }

    public string AgenciaAlb { get; set; } = null!;

    public string? TipodestinoAlb { get; set; }

    public int? IdclienteAlb { get; set; }

    public string? NifusuarioAlb { get; set; }

    public string NomdestinoAlb { get; set; } = null!;

    public string? ContactodestinoAlb { get; set; }

    public string TeldestinoAlb { get; set; } = null!;

    public string? EmaildestinoAlb { get; set; }

    public string? DirdestinoAlb { get; set; }

    public string? CpdestinoAlb { get; set; }

    public string? PobldestinoAlb { get; set; }

    public string? ProvdestinoAlb { get; set; }

    public string? EstadoAlb { get; set; }

    public DateTime? FechaestadoAlb { get; set; }

    public string? OtrosAlb { get; set; }

    public short? PdebidosAlb { get; set; }

    public short? AcusereciboAlb { get; set; }

    public int? IdadminCreadoporAlb { get; set; }

    public string? RefexternaAlb { get; set; }
}
