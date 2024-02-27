using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutIncidRefacturacion
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public string? FactOtm { get; set; }

    public string? Ciclo { get; set; }

    public int IdProceso { get; set; }

    public string? Tipo { get; set; }

    public string? Descripcion { get; set; }

    public string? Objeto { get; set; }

    public string? Valor { get; set; }
}
