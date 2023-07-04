namespace WebShopingCart.Models
{
    public class New :Base
    {
        public string Title { get; set; } = "";

        public string Description { get; set; } = "";

        public string Inmage { get; set; } = "";

        public decimal? Price { get; set; } = 0;

        public decimal? PriceSale { get; set; } = 0;

        public string TitleSale { get; set; } = "";
        public string DescriptionSale { get; set; } = "";
    }
}
