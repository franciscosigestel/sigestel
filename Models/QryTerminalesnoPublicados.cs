using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class QryTerminalesnoPublicados
{
    public int IdLinea { get; set; }

    public string NumTelefono { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string? Nombre { get; set; }

    public string? Apellidos { get; set; }

    public string Origen { get; set; } = null!;

    public string? Operador { get; set; }

    public int IdCliente { get; set; }

    public string? Expr1 { get; set; }

    public string? Expr2 { get; set; }

    public string? CodigosEstado { get; set; }

    public string? Estado { get; set; }

    public string? Terminal { get; set; }

    public string? Modelo { get; set; }

    public string? Imei { get; set; }

    public string? Expr3 { get; set; }

    public decimal? ImporteCompra { get; set; }
}
