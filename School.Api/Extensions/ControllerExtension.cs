using Microsoft.AspNetCore.Mvc;
using School.Domain.Entities;

namespace School.Api.Extensions
{
	public static class ControllerExtension
	{
		public static async Task<Response<TResult>> Execute<TResult>(this ControllerBase controller, Func<Task<TResult>> func)
		{
			try
			{
				var data = await func();
				return new Response<TResult>
				{
					Success = true,
					Message = "Success",
					Data = data
				};
			}
			catch (ValidatorException ex)
			{
				return new Response<TResult>
				{
					Success = false,
					Message = ex.Errors!.First().Message,
					Errors = ex.Errors
				};
			}
			catch (Exception)
			{
				return new Response<TResult>
				{
					Success = false,
					Message = "Internal exception"
				};
			}
		}

		public static async Task<Response> Execute(this ControllerBase controller, Func<Task> func, ILogger logger, string transactionName)
		{
			try
			{

				await func();
				return new Response
				{
					Success = true,
					Message = "Success",
				};
			}
			catch (ValidatorException ex)
			{

				return new Response
				{
					Success = false,
					Message = ex.Errors!.First().Message,
					Errors = ex.Errors
				};
			}
			catch (Exception ex)
			{
				return new Response
				{
					Success = false,
					Message = "Internal exception"
				};
			}
		}
	}
}
