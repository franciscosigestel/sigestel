using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgVwCuotasDatosVoz2
{
    public string? FacturaInterna { get; set; }

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

    public string CodigoConcepto { get; set; } = null!;

    public decimal? ImporteTotal { get; set; }

    public decimal? ImporteEstandar { get; set; }

    public decimal? ImporteDistancia { get; set; }

    public decimal? ImporteUnitario { get; set; }

    public string CodDesPeriodo1 { get; set; } = null!;

    public decimal? NunidadesPeriodo1 { get; set; }

    public string CodDesPeriodo2 { get; set; } = null!;

    public decimal? NunidadesPeriodo2 { get; set; }

    public string TipoValoracion { get; set; } = null!;

    public string Finicio { get; set; } = null!;

    public string Ffin { get; set; } = null!;

    public string CodProdConcepFact { get; set; } = null!;

    public string CodPaquete { get; set; } = null!;

    public string CodProdPers { get; set; } = null!;

    public decimal? Nunidades { get; set; }

    public string NivelImpositivo { get; set; } = null!;

    public decimal? TipoImpositivo { get; set; }

    public string CodDesApli { get; set; } = null!;

    public string CodDesPers { get; set; } = null!;

    public string ImporteDescuento { get; set; } = null!;
}
