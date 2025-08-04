namespace ApiPaisesProyecto.Services
{
    public interface ICodigoGenerador
    {
        string GenerarCodigo(string prefijo);
    }

    public class CodigoGenerador : ICodigoGenerador
    {
        private readonly Random _random = new Random();
        public string GenerarCodigo(string prefijo)
        {
            return $"{prefijo.ToUpper()}-{_random.Next(1000, 9999)}";
        }
    }

    public class CodigoGeneradorConFecha : ICodigoGenerador
    {
        private readonly Random _random = new Random();
        public string GenerarCodigo(string prefijo)
        {
            string fecha = DateTime.Now.ToString("yyyyMMdd");
            return $"{prefijo.ToUpper()}-{fecha}-{_random.Next(1000, 9999)}";
        }
    }
}
