namespace BlazorShopApi.Entities
{
	public class Products
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public string ImageUrl { get; set; } = string.Empty;
		public decimal Price { get; set; }
		public int Quantity { get; set; }

		public int CategoryId { get; set; }
		public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
	}
}
