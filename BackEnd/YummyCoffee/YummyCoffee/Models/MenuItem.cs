namespace YummyCoffee.Models
{
    public class MenuItem
    {
       public int  ItemId { get; set; }
       public string ItemName { get; set; }
       //public string description { get; set;}
       public double Price { get; set; }
       public string Category { get; set; }
       public string ImageUrl { get; set; }
       public bool IsAvailable { get; set; } = true;

    }
}
