using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class CondicionesAcuerdosMarco
{
    public int Idempresa { get; set; }

    public int Idoperadora { get; set; }

    public int NumAcuerdoMarco { get; set; }

    public string Identificador { get; set; } = null!;

    public int? LimMin500 { get; set; }

    public int? LimMin1000 { get; set; }

    public string? Lunes { get; set; }

    public string? Martes { get; set; }

    public string? Miercoles { get; set; }

    public string? Jueves { get; set; }

    public string? Viernes { get; set; }

    public string? Sabado { get; set; }

    public string? Domingo { get; set; }
}
