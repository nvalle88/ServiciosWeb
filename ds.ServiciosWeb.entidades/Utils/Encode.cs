using System;
using System.Collections.Generic;
using System.Text;

namespace ds.WebServices.entities.Utils
{
    /*
    Creado por DigitalStrategy
    Las Clases Utils son clases con metodos para ser reutilizados como mensajes, Codificar, o response 
    según sean necesarias para el proyecto
    */
    public class Encode
    {

        public static string SHA512(string input)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(input);
            using (var hash = System.Security.Cryptography.SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);

                // Convert to text
                // StringBuilder Capacity is 128, because 512 bits / 8 bits in byte * 2 symbols for byte 
                var hashedInputStringBuilder = new System.Text.StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                return hashedInputStringBuilder.ToString();
            }
        }
    }
}
