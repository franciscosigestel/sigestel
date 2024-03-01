namespace sigestel.Tools
{
    public static class QueryableExtensions
    {
        //esta clase hace que puedas consultar todas las paginas que quieras de registros sin saturar al server porque se va trayendo las necesarias
        public static IQueryable<T> Paginar<T>(this IQueryable<T> queryable, Paginacion paginacion)
        {
            return queryable
                .Skip((paginacion.Pagina - 1) * paginacion.cantidadAMostrar)
                .Take(paginacion.cantidadAMostrar);
        }
    }
}
