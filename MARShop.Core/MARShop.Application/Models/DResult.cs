using System;
using System.Collections.Generic;
using System.Linq;

namespace MARShop.Application.Models
{
    public class DResult
    {
        public bool Succeeded { get; set; }

        public string Message { get; set; }

        internal DResult(bool succeeded, string message)
        {
            Succeeded = succeeded;
            Message = message;
        }

        public static DResult Success()
        {
            return new DResult(true, "");
        }
        public static DResult Success(string message)
        {
            return new DResult(true, message);
        }

        public static DResult Failure(string message)
        {
            return new DResult(false, message);
        }

        public static DResult Failure()
        {
            return new DResult(false, "");
        }
    }

    public class DResult<T>
    {
        internal DResult(bool succeeded, string message, T result)
        {
            Succeeded = succeeded;
            Message = message;
            Result = result;
        }

        public bool Succeeded { get; set; }

        public string Message { get; set; }

        public T Result { get; set; }

        public static DResult<T> Success(T result)
        {
            return new DResult<T>(true, "", result);
        }
        public static DResult<T> Success(T result, string message)
        {
            return new DResult<T>(true, message, result);
        }
        public static DResult<T> Failure(T result)
        {
            return new DResult<T>(false, "", result);
        }
        public static DResult<T> Failure(T result, string message)
        {
            return new DResult<T>(false, message, result);
        }
    }
}
