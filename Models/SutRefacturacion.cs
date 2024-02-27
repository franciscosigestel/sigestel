using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutRefacturacion
{
    public int IdProceso { get; set; }

    public int IdCliente { get; set; }

    public string? FactOtm { get; set; }

    public int? CodigoOperador { get; set; }

    public string? Ciclo { get; set; }

    public DateTime Fecha { get; set; }

    public string? Estado { get; set; }

    public decimal? ImporteRefacturado { get; set; }

    public decimal? ImporteRefacturadoColectivo { get; set; }

    public decimal? ImporteRefacturadoSocios { get; set; }

    public decimal? ImporteFacturaOtm { get; set; }

    public decimal? ImporteTotalEmitido { get; set; }

    public decimal? ImporteFraSigestel { get; set; }

    public int? SumaPuntosRepartidos { get; set; }

    public decimal? ImporteCosteServicio { get; set; }

    public decimal? ImpoteGestionColectivo { get; set; }

    public decimal? ImporteAbonosSac { get; set; }

    public decimal? ImporteLineasSac { get; set; }

    public decimal? ImporteCorreoPostal { get; set; }

    public int? NumLineasOtm { get; set; }

    public int? NumLineasColectivo { get; set; }

    public int? NumLineasSocios { get; set; }

    public decimal? ImporteCuotasTf { get; set; }

    public decimal? ImporteBolsaEura { get; set; }

    public decimal? ImporteVdmpEnfactura { get; set; }

    public decimal? ImporteVdmpCalculado { get; set; }
}
