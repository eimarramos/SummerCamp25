using ApiPaisesProyecto.Entities;

namespace ApiPaisesProyecto.Utilidades
{
    public static class Utilidades
    {
        public static string ConvertirMayusculas(this string text)
        {    
            if (string.IsNullOrEmpty(text))
            {
                return text;
            }

            return text.ToUpper() + "-----------";
        }

        //Capitalizar primera letra

        public static string CapitalizarPrimeraLetra(this string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return text;
            }
            return char.ToUpper(text[0]) + text.Substring(1);
        }

        //Es Par

        public static bool EsPar(this int numero)
        {
            return numero % 2 == 0;
        }

        // Calcular Edad

        public static int CalcularAntiguedad(this DateTime fechaNacimiento)
        {
            var edad = DateTime.Now.Year - fechaNacimiento.Year;
            if (DateTime.Now < fechaNacimiento.AddYears(edad))
            {
                edad--;
            }
            return edad;
        }
    }
}
