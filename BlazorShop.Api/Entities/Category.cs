public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string CssIcon { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}