using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class Presupuestos
{
    public string Empresa { get; set; } = null!;

    public string Año { get; set; } = null!;

    public string? FijoLineas { get; set; }

    public string? FijoImporte { get; set; }

    public string? DatosLineas { get; set; }

    public string? DatosImporte { get; set; }

    public string? McorporativoLineas { get; set; }

    public string? McorporativoImporte { get; set; }

    public string? MdatosLineas { get; set; }

    public string? MdatosImporte { get; set; }

    public string? MinternacionalLineas { get; set; }

    public string? MinternacionalImporte { get; set; }

    public string? MmensajesLineas { get; set; }

    public string? MmensajesImporte { get; set; }

    public string? MnoCorporativoLineas { get; set; }

    public string? MnoCorporativoImporte { get; set; }

    public string? MrestoLineas { get; set; }

    public string? MrestoImporte { get; set; }
}
