using System;
namespace WebApplication1.Models
{
	public class UserRegisterViewModel
	{
		public UserRegisterViewModel()
		{
		}

		public string Name { get; set; }
		public string Surname { get; set; }
		public string Username { get; set; }
		public string Mail { get; set; }
		public string Password { get; set; }
	}
}

