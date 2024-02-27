using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutHistComentariosLineas
{
    public int IdHistorico { get; set; }

    public string TipoComentario { get; set; } = null!;

    public int IdColectivo { get; set; }

    public int? IdLinea { get; set; }

    public string? NumTelefono { get; set; }

    public string? Comentario { get; set; }

    public int? IdAdminComentario { get; set; }

    public string? Origen { get; set; }

    public int? IdPosventa { get; set; }
}
