namespace ApiPaisesProyecto.Services
{
    public interface ISaludo
    {
        string Saludar(string nombre);
    }

    public class Saludo : ISaludo
    {
        public string Saludar(string nombre)
        {
            return $"¡Hola, {nombre}! Bienvenido a la API de países y apartamentos.";
        }
    }

    // Saludo en Inglés

    public class EnglishSaludo : ISaludo
    {
        public string Saludar(string nombre)
        {
            return $"Hello, {nombre}! Welcome to the countries and apartments API.";
        }
    }

    public class FrenchSaludo : ISaludo
    {
        public string Saludar(string nombre)
        {
            return $"Bonjour, {nombre}! Bienvenue dans l'API des pays et des appartements.";
        }
    }

    // Alemám

    public class GermanSaludo : ISaludo
    {
        public string Saludar(string nombre)
        {
            return $"Hallo, {nombre}! Willkommen in der API für Länder und Wohnungen.";
        }
    }
    // Italiano

    public class ItalianSaludo : ISaludo
    {
        public string Saludar(string nombre)
        {
            return $"Ciao, {nombre}! Benvenuto nell'API dei paesi e degli appartamenti.";
        }
    }

    // Portugués

    public class PortugueseSaludo : ISaludo
    {
        public string Saludar(string nombre)
        {
            return $"Olá, {nombre}! Bem-vindo à API de países e apartamentos.";
        }
    }

    // Chino

    public class ChineseSaludo : ISaludo
    {
        public string Saludar(string nombre)
        {
            return $"你好, {nombre}! 欢迎来到国家和公寓的API.";
        }
    }
}
