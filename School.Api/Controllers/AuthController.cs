using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using School.Api.Extensions;
using School.Application.Dtos;
using School.Application.Services;
using School.Domain.Entities;

namespace School.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController(ILoginservice loginservice) : ControllerBase
	{
		private readonly ILoginservice _loginService = loginservice;
		[HttpPost]
		[Route("login")]
		public Task<Response<string>> LoginAsync(LoginDTo login)
		{
			return this.Execute(async () =>
			{
				return await _loginService.LoginAsync(login.UserName, login.Password);
			});
		}
	}
}
