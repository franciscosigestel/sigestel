using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgVwDetalleDatosBorrar
{
    public string CodigoRegistro { get; set; } = null!;

    public string NSecuencial { get; set; } = null!;

    public string CodigoCliente { get; set; } = null!;

    public string RefAgrupacionFacturable { get; set; } = null!;

    public string CodAgrupacionDetalle { get; set; } = null!;

    public string TipoServicio { get; set; } = null!;

    public string CodMulticonexion { get; set; } = null!;

    public string NComercial1 { get; set; } = null!;

    public string NComercial2 { get; set; } = null!;

    public string Longitud { get; set; } = null!;

    public string TipoTrafico { get; set; } = null!;

    public string SubTipoTrafico { get; set; } = null!;

    public string AmbitoLlamada { get; set; } = null!;

    public string OperadorProveedor { get; set; } = null!;

    public string NumeroLlamado { get; set; } = null!;

    public string Origen { get; set; } = null!;

    public string Destino { get; set; } = null!;

    public string Servicio { get; set; } = null!;

    public string NtelPer { get; set; } = null!;

    public string Nrecibo { get; set; } = null!;

    public DateTime? Fecha { get; set; }

    public string Hora { get; set; } = null!;

    public string Duracion { get; set; } = null!;

    public decimal? Unidades { get; set; }

    public string Locuciones { get; set; } = null!;

    public string TipoVariable { get; set; } = null!;

    public decimal? UnidadesVolumen { get; set; }

    public string Tarifa { get; set; } = null!;

    public decimal? ImporteEstandar { get; set; }

    public decimal? ImporteValor { get; set; }

    public string CodigoDescuento { get; set; } = null!;

    public string CodigoDescuentoPer { get; set; } = null!;

    public decimal? ImporteDescuento { get; set; }
}
