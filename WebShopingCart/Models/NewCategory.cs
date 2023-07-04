namespace WebShopingCart.Models
{
    public class NewCategory : Base     
    {
        public string Title { get; set; } = "";

        public string Description { get; set; } = "";

        public string Inmage { get; set; } = "";

        public string Link { get; set; } = "";

        public string TitleSale { get; set; } = "";
        public string DescriptionSale { get; set; } = "";
    }
}
