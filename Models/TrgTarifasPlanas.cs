using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgTarifasPlanas
{
    public string Codigo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string LimiteConsumo { get; set; } = null!;

    public string PrecioLimite { get; set; } = null!;

    public string Bloque { get; set; } = null!;

    public string PrecioBloque { get; set; } = null!;

    public string PrecioMaximo { get; set; } = null!;
}
