﻿using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ProvAtributos
{
    public int Idatributo { get; set; }

    public string CodigoAtrb { get; set; } = null!;

    public string CategoriaAtrb { get; set; } = null!;

    public string TipoAtrb { get; set; } = null!;

    public string NivelAtrb { get; set; } = null!;

    public string CodfacturacionAtrb { get; set; } = null!;

    public string EmisorAtrb { get; set; } = null!;

    public short ProrrateoAtrb { get; set; }

    public string LiteralAtrb { get; set; } = null!;

    public string DescripcionAtrb { get; set; } = null!;

    public decimal ValorAtrb { get; set; }

    public decimal Param1Atrb { get; set; }

    public decimal Param2Atrb { get; set; }

    public decimal Param3Atrb { get; set; }

    public short ObligatorioAtrb { get; set; }

    public short PermiterepAtrb { get; set; }

    public string? LiteralasociadoAtrb { get; set; }

    public DateTime FaltaAtrb { get; set; }

    public string EstadoAtrb { get; set; } = null!;

    public DateTime FestadoAtrb { get; set; }

    public short Nivel4editarAtrb { get; set; }

    public string? TraficoincluidoAtrb { get; set; }
}
