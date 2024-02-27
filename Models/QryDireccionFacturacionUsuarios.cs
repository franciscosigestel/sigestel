using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class QryDireccionFacturacionUsuarios
{
    public int IdUsuario { get; set; }

    public string Nombre { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string CodPostal { get; set; } = null!;

    public string Poblacion { get; set; } = null!;

    public string Provincia { get; set; } = null!;
}
