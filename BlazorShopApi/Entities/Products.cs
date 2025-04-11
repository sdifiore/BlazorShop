using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorShopApi.Entities
{
	public class Products
	{
		public int Id { get; set; }
		[MaxLength(100)]
		public string Name { get; set; } = string.Empty;
		[MaxLength(200)]
		public string Description { get; set; } = string.Empty;
		[MaxLength(200)]
		public string ImageUrl { get; set; } = string.Empty;
		[Column(TypeName = "decimal(18,2)")]
		public decimal Price { get; set; }
		public int Quantity { get; set; }

		public int CategoryId { get; set; }
		public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
	}
}
