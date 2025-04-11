using System.ComponentModel.DataAnnotations;

namespace BlazorShopApi.Entities
{
	public class User
	{
		public int Id { get; set; }
		[MaxLength(200)]
		public string UserName { get; set; } = string.Empty;

		public Cart Cart { get; set; } = new Cart();
	}
}
