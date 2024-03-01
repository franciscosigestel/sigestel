using System.Security.Cryptography;
using System.Text;
namespace sigestel.Tools
{
    public class Utilidades
    {
        // Trocea una cadena de entrada y devuelve el hash como
        // una cadena hexadecimal de 32 caracteres.
        public static string EncriptarClave(string input)
        {
            // Crea una nueva instancia del objeto MD5.
            using (MD5 md5Hasher = MD5.Create())
            {
                // Convierte la cadena de entrada a una matriz de bytes y calcula el hash.
                byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

                // Crea un nuevo StringBuilder para recopilar los bytes
                // y crear una cadena.
                StringBuilder sBuilder = new StringBuilder();

                // Recorre cada byte de los datos hash
                // y formatea cada uno como una cadena hexadecimal.
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                // Devuelve la cadena hexadecimal.
                return sBuilder.ToString();
            }
        }
    
    }
}
