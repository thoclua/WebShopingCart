using System.ComponentModel.DataAnnotations.Schema;

namespace WebShopingCart.Models
{
    public class OderDetail
    {
        public int OderId { get; set; } = 0;
        public int ProductId { get; set; } = 0;

        public decimal? Price { get; set; } = 0;

        public int Quantity { get; set; } = 0;


        //[ForeignKey("OderId")]

        //public virtual Oder? Oders { get; set; }

        //[ForeignKey("ProductId")]

        //public virtual Product? Products { get; set; }
    }
}
