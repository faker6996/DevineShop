using MARShop.Application.Enum;

namespace MARShop.Application.Common
{
    public class Respond
    {
        public string Status { get; set; }
        public string Message { get; set; } = "";

        public static Respond Success()
        {
            return new Respond()
            {
                Status = nameof(RespondStatus.Success),
            };
        }
    }

    public class Respond<T> where T : class
    {
        public string Status { get; set; }
        public string Message { get; set; } = "";
        public T Result { get; set; }
        public static Respond<T> Success(T result)
        {
            return new Respond<T>()
            {
                Status = nameof(RespondStatus.Success),
                Result = result
            };
        }
        public static Respond<T> Success(string message, T result)
        {
            return new Respond<T>()
            {
                Status = nameof(RespondStatus.Success),
                Message = message,
                Result = result
            };
        }
    }
}
