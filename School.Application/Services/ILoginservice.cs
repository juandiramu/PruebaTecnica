namespace School.Application.Services
{
	public interface ILoginservice
	{
		public Task<string> LoginAsync(string? userName, string? password);
	}
}
