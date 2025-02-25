namespace School.Domain.Shared
{
	public interface IToken
	{
		Task<string> GenerateAsync(Guid userId, string username, string rol);
	}
}
