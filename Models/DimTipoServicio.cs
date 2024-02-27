using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class DimTipoServicio
{
    public int ServicioKey { get; set; }

    public int? ServicioPkey { get; set; }

    public string? ServicioCod { get; set; }

    public string? ServicioPcod { get; set; }

    public string? ServicioDescripcion { get; set; }
}
