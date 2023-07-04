using System.ComponentModel.DataAnnotations.Schema;

namespace WebShopingCart.Models
{
    public class CategoryInProduct :Base
    {
        public int CategoryProductId { get; set; } = 0;
        public int ProductId { get; set; } = 0;

        //[ForeignKey("CategoryProductId")]

        //public virtual CategoryProduct? CategoryProducts { get; set; }

        //[ForeignKey("ProductId")]

        //public virtual Product? Products { get; set; }
    }
}
