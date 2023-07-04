using System.ComponentModel.DataAnnotations;

namespace WebShopingCart.Models
{
    public class Base
    {

        [Key]
        public int id { get; set; }

        public DateTime? CreatedDate { get; set; } = DateTime.Now;

        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; } = DateTime.Now;

        public string ModifiedBy { get; set; }

    }
}
