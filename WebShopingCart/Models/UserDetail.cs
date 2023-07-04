namespace WebShopingCart.Models
{
    public class UserDetail : Base
    {
        public string Code { get; set; } = ""; 
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public int? Age { get; set; } = 0;
        public string Address { get; set; } = "";

        public string Phone { get; set; } = "";

    }
}
