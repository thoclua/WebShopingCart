using System.ComponentModel.DataAnnotations.Schema;

namespace WebShopingCart.Models
{
    public class NewInProduct :Base
    {
        public int NewId { get; set; } = 0;
        public int ProductId { get; set; } = 0;

        //[ForeignKey("NewId")]

        //public virtual New? News { get; set; }

        //[ForeignKey("ProductId")]

        //public virtual Product? Products { get; set; }
    }
}
