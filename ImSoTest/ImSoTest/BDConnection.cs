namespace ImSoTest
{
    public class BDConnection
    {
        string ambiente = Environment.GetEnvironmentVariable("ambiente").ToUpper();
        private IConfiguration _configuration;
        public string cadena = "";
        private string nombreCadena = "";


        /*var builder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .AddEnvironmentVariables();*/

        public BDConnection()
        {
            _configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).Build();

            nombreCadena = ("imsotest_" + ambiente).ToUpper();
            Console.WriteLine($"nombreCadena : {nombreCadena}");
            cadena = _configuration["cadenasConexion:" + nombreCadena];
        }

        public BDConnection(string nombreCad)
        {
            _configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).Build();

            nombreCadena = (nombreCad + "_" + ambiente).ToUpper();
            Console.WriteLine($"nombreCadena : {nombreCadena}");
        }
    }
}
