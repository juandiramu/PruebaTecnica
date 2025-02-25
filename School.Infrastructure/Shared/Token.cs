using School.Domain.Shared;

namespace School.Infrastructure.Shared
{
	public class Token : IToken
	{
		public Task<string> GenerateAsync(Guid userId, string username, string rol)
		{
			throw new NotImplementedException();
		}
	}
}
