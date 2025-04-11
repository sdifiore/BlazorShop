using System.ComponentModel.DataAnnotations;

namespace BlazorShopApi.Entities
{
	public class Category
	{
		public int Id { get; set; }
		[MaxLength(100)]
		public string Name { get; set; } = string.Empty;
		public string IconCSS { get; set; } = string.Empty;

		public ICollection<Products> Products { get; set; } = new List<Products>();
	}
}
