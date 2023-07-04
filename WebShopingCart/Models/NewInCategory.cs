using System.ComponentModel.DataAnnotations.Schema;

namespace WebShopingCart.Models
{
    public class NewInCategory : Base
    {
        public int NewCategoryId { get; set; } = 0;
        public int NewId { get; set; } = 0;

        //[ForeignKey("NewCategoryId")]

        //public virtual NewCategory? NewCategorys { get; set; }

        //[ForeignKey("NewId")]

        //public virtual New? News { get; set; }
    }
}
