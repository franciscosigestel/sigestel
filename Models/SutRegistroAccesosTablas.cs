using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutRegistroAccesosTablas
{
    public int Idregistro { get; set; }

    public string? Tabla { get; set; }

    public int? Idadmin { get; set; }

    public string? TipoAcceso { get; set; }

    public string? Registro { get; set; }

    public DateTime? FechaHora { get; set; }
}
