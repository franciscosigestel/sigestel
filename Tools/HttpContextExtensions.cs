using Microsoft.EntityFrameworkCore;

namespace sigestel.Tools
{
    public static class HttpContextExtensions
    {
        //Uso IQueryable para que funcione con cualquier registro de la bdd (met. Genérico)
        public static async Task InsertarParametrosPAginacionRespuesta<T>(this HttpContext context,
            IQueryable<T> queryable, int cantidadRegistrosAMostrar)
        {
            if ( context == null)
            {
                throw new ArgumentNullException(nameof(context));

            }
            double conteo = await queryable.CountAsync(); //total de registros
            double totalPaginas = Math.Ceiling(conteo / cantidadRegistrosAMostrar);
            context.Response.Headers.Add("totalPaginas", totalPaginas.ToString()); //saber el num pag en texto



        }
    }
}
