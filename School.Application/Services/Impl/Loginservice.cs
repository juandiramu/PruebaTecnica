using School.Domain.Shared;

namespace School.Application.Services.Impl
{
	public class Loginservice(IToken token) : ILoginservice
	{
		private readonly IToken _token = token;
		public async Task<string> LoginAsync(string? userName, string? password)
		{
			return await _token.GenerateAsync(Guid.NewGuid(), userName!, "Admin");
		}
	}
}
