using Microsoft.AspNetCore.Mvc;
//Mis librerías
using sigestel.Models;
using sigestel.Tools;
using sigestel.Services.contract;

//Libreria para trabajar con cookies
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
namespace sigestel.Controllers
{
    public class InicioController : Controller
    {
        private readonly IUsuarioService _usuarioServicio;

        //Constructor
        public InicioController(IUsuarioService usuarioServicio)
        {
            _usuarioServicio = usuarioServicio;
        }
        //Este método carga la vista
        public IActionResult Registrarse()
        {
            return View();
        }

        //Este método responde a la solicitud que se pueda generar (en este caso registrar al usuario)
        [HttpPost]
        public async Task<IActionResult> Registrarse(SutAdministradores modelo)
        {
            //Encriptamos y actualizamos la clave
            modelo.Clave = Utilidades.EncriptarClave(modelo.Clave);

            SutAdministradores usuario_creado = await _usuarioServicio.SaveUsuario(modelo);

            if (usuario_creado.Nif != null)   //posible cambio aquí por dni en vez de Nif

                //esto redirecciona a la vista deseada
                return RedirectToAction("IniciarSesion","Inicio");
            ViewData["Mensaje"] = "No se ha podido darle de alta.";

            return View();
        }

        public IActionResult IniciarSesion()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> IniciarSesion(string dni, string clave)
        {
            SutAdministradores usuario_encontrado = await _usuarioServicio.GetUsuario(dni, Utilidades.EncriptarClave(clave));

            if(usuario_encontrado == null)
            {
                ViewData["Mensaje"] = "Usuario o contraseña no válidos.";
                return View();
            }
            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, usuario_encontrado.NombreCompleto)
            };
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            AuthenticationProperties properties = new AuthenticationProperties()
            {
                AllowRefresh = true

            };

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                properties
                );
            return RedirectToAction("Index", "Home");
        }
    }
}
