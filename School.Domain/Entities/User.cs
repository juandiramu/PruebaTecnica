using School.Domain.Enums;
namespace School.Domain.Entities
{
	public class User: Entity
	{
		public string UserName { get; set; } = string.Empty;
		public string Password { get; set; } = string.Empty;
		public UserRole Rol {  get; set; }

	}
}
