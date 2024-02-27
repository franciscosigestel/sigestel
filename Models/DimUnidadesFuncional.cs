using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class DimUnidadesFuncional
{
    public int FuncionalKey { get; set; }

    public int? FuncionalPkey { get; set; }

    public string? FuncionalCod { get; set; }

    public string? FuncionalPcod { get; set; }

    public string? FuncionalNombre { get; set; }

    public string? FuncionalDescripcion { get; set; }

    public byte? FuncionalEsPersona { get; set; }

    public string? FuncionalUsuarioRed { get; set; }

    public bool? FuncionalAct { get; set; }
}
