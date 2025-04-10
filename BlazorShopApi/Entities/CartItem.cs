namespace BlazorShopApi.Entities
{
	public class CartItem
	{
		public int Id { get; set; }
		public int CartId { get; set; }
		public int ProductId { get; set; }
		public int Quantity { get; set; }

		public Cart Cart { get; set; } = new Cart();
		public Products Product { get; set; } = new Products();

	}
}
