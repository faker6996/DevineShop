using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MARShop.Application.Middleware
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception error)
            {
                var response = context.Response;
                response.ContentType = "application/json";

                switch (error)
                {
                    case AppException:
                        // custom application error
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        break;
                    case KeyNotFoundException:
                        // not found error
                        response.StatusCode = (int)HttpStatusCode.NotFound;
                        break;
                    default:
                        // unhandled error
                        response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        break;
                }

                var problemDetail = new ProblemDetail()
                {
                    Status = response.StatusCode,
                    Type = "Server error",
                    Title = "Server error",
                    Detail = error?.Message ?? ""
                };

                var result = JsonSerializer.Serialize(problemDetail);
                await response.WriteAsync(result);
            }
        }
    }
    class ProblemDetail
    {
        public int Status { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
    }
}
