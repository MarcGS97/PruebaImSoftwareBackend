namespace ImSoTest
{
    public class Response<T>
    {
        public bool success { get; set; }
        public string message { get; set; } = string.Empty;
        public T? data { get; set; }
        public List<string>? errors { get; set; }

        public Response() { }

        public Response(T data)
        {
            success = true;
            data = data;
        }

        public Response(string message, bool success = false)
        {
            success = success;
            message = message;
        }

        public Response(List<string> errors, string message = "Ocurrieron errores", bool success = false)
        {
            success = success;
            message = message;
            errors = errors;
        }
    }
}
