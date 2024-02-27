using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutTareasApiVodafone
{
    public int Idtarea { get; set; }

    public string TipoTarea { get; set; } = null!;

    public int Idlinea { get; set; }

    public int Idcolectivo { get; set; }

    public int IdadminCreador { get; set; }

    public string NumTelefono { get; set; } = null!;

    public int? Idticket { get; set; }

    public string? Cif { get; set; }

    public string? CifReal { get; set; }

    public string? CuentaInstalacion { get; set; }

    public string? NumSim { get; set; }

    public string? CodRestriccion { get; set; }

    public string? EstadoRestriccion { get; set; }

    public short Prioridad { get; set; }

    public DateTime FechaRegistroTarea { get; set; }

    public int NumIntentosEnvio { get; set; }

    public string EstadoTarea { get; set; } = null!;

    public DateTime FechaEstadoTarea { get; set; }

    public string? CodError { get; set; }

    public string? MensajeError { get; set; }

    public DateTime? FechaEnvioSolicitada { get; set; }

    public string? EmailNotificacionAdmin { get; set; }
}
