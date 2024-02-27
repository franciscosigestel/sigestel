using Microsoft.EntityFrameworkCore;
using sigestel.Models;
namespace sigestel.Services.contract
{
    public interface IUsuarioService
    {
        Task<SutAdministradores> GetUsuario(string dni, string clave);

        Task<SutAdministradores> SaveUsuario(SutAdministradores modelo);
    }
}
