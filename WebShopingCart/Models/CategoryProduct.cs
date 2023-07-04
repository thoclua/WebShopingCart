namespace WebShopingCart.Models
{
    public class CategoryProduct : Base
    {
        public string Name { get; set; } = "";
        public string Title { get; set; } = "";

        public string Description { get; set; } = "";

        public string Inmage { get; set; } = "";

        public decimal? Price { get; set; } = 0;

        public decimal? PriceSale { get; set; } = 0;

        public string DescriptionSale { get; set; } = "";

        public string TitleSale { get; set; } = "";
    }
}
