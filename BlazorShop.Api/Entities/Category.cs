using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Category
{
    public int Id { get; set; }
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;
    public string CssIcon { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    [Column(TypeName = "decimal(10,2)")]
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public Collection<Product> Products { get; set; } = new Collection<Product>();
}