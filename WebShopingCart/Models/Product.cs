namespace WebShopingCart.Models
{
    public class Product : Base
    {
        public string Name { get; set; } = "";
        public string Title { get; set; } = "";

        public string Description { get; set; } = "";

        public string Inmage { get; set; } = "";

        public decimal? Price { get; set; } = 0;

        public decimal? PriceSale { get; set; } = 0;

        public string TitleSale { get; set; } = "";
        public string DescriptionSale { get; set; } = "";

        public int Quantity { get; set; } = 0;

    }
}
