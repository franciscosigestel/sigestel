using Microsoft.EntityFrameworkCore;
using sigestel.Models;
using sigestel.Services.contract;

namespace sigestel.Services.Implementation
{
    public class UsuarioService : IUsuarioService
    {

        private readonly MaxDbContext _dbContext;

        public UsuarioService(MaxDbContext dbContext)
        {
            _dbContext = dbContext;

        }

        // Solicitud asíncrona para recolectar el usuario.
        public async Task<SutAdministradores> GetUsuario(string dni, string clave)
        {
            SutAdministradores usuario_encontrado = await _dbContext.SutAdministradores
                .Where(u => u.Nif == dni && u.Clave == clave)
                .FirstOrDefaultAsync();

            return usuario_encontrado;
        }

        public async Task<SutAdministradores> SaveUsuario(SutAdministradores modelo)
        {
            _dbContext.SutAdministradores.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return modelo;
        }
    }
}
