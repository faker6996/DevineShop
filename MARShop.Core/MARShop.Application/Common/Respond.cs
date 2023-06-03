namespace MARShop.Application.Common
{
    public class Respond
    {
        public string Status { get; set; }
        public string Message { get; set; } = "";

        public static Respond New(string status, string message)
        {
            return new Respond()
            {
                Status = status,
                Message = message
            };
        }
        public static Respond New(string status)
        {
            return new Respond()
            {
                Status = status,
            };
        }
    }

    public class Respond<T> where T : class
    {
        public string Status { get; set; }
        public string Message { get; set; } = "";
        public T Result { get; set; }
        public static Respond<T> New(string status, string message, T result)
        {
            return new Respond<T>()
            {
                Status = status,
                Message = message,
                Result = result
            };
        }
    }
}
