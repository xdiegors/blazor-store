using System.ComponentModel.DataAnnotations;

public class User
{
    public int Id { get; set; }
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    public Cart? Cart { get; set; }
}