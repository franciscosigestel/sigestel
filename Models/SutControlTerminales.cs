using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutControlTerminales
{
    public int Idcliente { get; set; }

    public int Idlinea { get; set; }

    public string Terminal { get; set; } = null!;

    public string Imei { get; set; } = null!;

    public decimal PCompra { get; set; }

    public decimal PVenta { get; set; }

    public DateTime FPublicacion { get; set; }

    public string Estado { get; set; } = null!;

    public DateTime FEstado { get; set; }

    public int? ModoFinanciacion { get; set; }

    public int? PlazoFinanciacion { get; set; }

    public string? Clave { get; set; }

    public int? NOrden { get; set; }

    public string? NPedidoOp { get; set; }

    public string? TipoPedido { get; set; }

    public decimal? PCompraEurvf { get; set; }

    public string? Comentarios { get; set; }

    public string? EstadoLiq { get; set; }

    public string? CicloLiq { get; set; }
}
