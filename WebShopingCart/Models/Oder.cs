namespace WebShopingCart.Models
{
    public class Oder :Base
    {
        public int? Code { get; set; } = 0;
        public string CustomerName { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Address { get; set; } = "";
        public decimal? Totalmoney { get; set; } = 0;

        public int? Quantity { get; set; } = 0;

    }
}
