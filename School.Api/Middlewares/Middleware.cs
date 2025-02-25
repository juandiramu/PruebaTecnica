using School.Domain.Entities;
using School.Domain.Repository;
using System.Net;
using System.Text.Json;

namespace School.Api.Middlewarees
{
	public class Middleware(RequestDelegate next, IHostEnvironment env)
	{
		private readonly RequestDelegate _next = next;
		private readonly IHostEnvironment _env = env;


		public async Task InvokeAsync(HttpContext context)
		{
			context.Request.EnableBuffering();
			try
			{
				await _next(context);
			}
			catch (Exception ex)
			{
				await HandleExceptionAsync(context, ex, _env);
			}
		}

		private async Task HandleExceptionAsync(HttpContext context, Exception ex, IHostEnvironment env)
		{
			context.Response.ContentType = "aplication/json";
			int statusCode = (int)HttpStatusCode.InternalServerError;
			string result = string.Empty;

			switch (ex)
			{
				case ValidatorException validatorException:
					result = JsonSerializer.Serialize(new Response { Success = false, Message = "Falló una o más validaciones", Errors = validatorException.Errors });
					context.Response.StatusCode = statusCode;
					break;
				case InvalidOperationException invalidOperationException:
					result = JsonSerializer.Serialize(new Response { Success = false, Message = invalidOperationException.Message, Errors = [new() { Code = "500", Message = invalidOperationException.Message }] });
					context.Response.StatusCode = statusCode;
					break;
				case UnauthorizedAccessException unauthorizedAccessException:
					result = JsonSerializer.Serialize(new Response { Success = false, Message = unauthorizedAccessException.Message, Errors = [new() { Code = "402", Message = unauthorizedAccessException.Message }] });
					context.Response.StatusCode = statusCode;
					break;
				case FormatException formatException:
					result = JsonSerializer.Serialize(new Response { Success = false, Message = formatException.Message, Errors = [new() { Code = "500", Message = formatException.Message }] });
					context.Response.StatusCode = statusCode;
					break;
				case TimeoutException timeOutException:
					result = JsonSerializer.Serialize(new Response { Success = false, Message = timeOutException.Message, Errors = [new() { Code = "500", Message = timeOutException.Message }] });
					context.Response.StatusCode = statusCode;
					break;
				case IOException IOException:
					result = JsonSerializer.Serialize(new Response { Success = false, Message = IOException.Message, Errors = [new() { Code = "500", Message = IOException.Message }] });
					context.Response.StatusCode = statusCode;
					break;
			}
			await context.Response.WriteAsync(result);
		}
	}
}
