using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class QryDireccionFacturacionClientes
{
    public int? IdCliente { get; set; }

    public string Direccion { get; set; } = null!;

    public string CodPostal { get; set; } = null!;

    public string Poblacion { get; set; } = null!;

    public string Provincia { get; set; } = null!;
}
