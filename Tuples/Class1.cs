using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

// * Su análisis debería devolver 3 piezas de datos

// * Una indicación de si el número tiene un código de marcación de Nueva York, es decir, 212 como los primeros 3 dígitos
// * Una indicación de si el número es falso al tener 555 como código de prefijo en las posiciones 5 a 7 (numeración desde 1)
// * Los últimos 4 dígitos del número.
// * Implemente el método (estático) PhoneNumber.Analyze()para producir la información del número de teléfono.

                    // * PhoneNumber.Analyze("631-555-1234");
                    // => (false, true, "1234")

namespace Tuples
{
    public static class PhoneNumber
    {
        public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
        {
            string areaCode = phoneNumber.Substring(0, 3); // Ej: "631"
            string prefix = phoneNumber.Substring(4, 3);   // Ej: "555" (posiciones 5 a 7 contando desde 1)
            string LocalNumber = phoneNumber.Substring(phoneNumber.Length - 4); // Últimos 4 dígitos

            bool IsNewYork = areaCode == "212";
            bool IsFake = prefix == "555";

            return (IsNewYork, IsFake, LocalNumber);

        }

        public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
        {
            var (boolean, cadena, numero) = phoneNumberInfo;

            return cadena;
        }
    }
}
