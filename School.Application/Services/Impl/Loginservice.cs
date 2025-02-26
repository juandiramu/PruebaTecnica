using School.Domain.Entities;
using School.Domain.Repository;
using School.Domain.Shared;

namespace School.Application.Services.Impl
{
	public class Loginservice(IToken token, IRepository<User> repository) : ILoginservice
	{
		private readonly IToken _token = token;
		private readonly IRepository<User> _repository = repository;
		public async Task<string> LoginAsync(string? userName, string? password)
		{
			if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
				throw new ValidatorException("Username y contraseña no puden ser nulos o vacíos");
			User user = (await _repository.GetByFilter(user => user.UserName == userName && user.Password == password)).FirstOrDefault() ?? throw new ValidatorException("Username o contraseña inválida");
			return await _token.GenerateAsync(user.Id, user.UserName, user.Rol.ToString());
		}
	}
}
