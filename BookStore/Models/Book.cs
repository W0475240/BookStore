using System.ComponentModel.DataAnnotations;

namespace BookStore.Models;

public class Book
{
    [Key]
    public required string ISBN { get; set; }

    public required string Title { get; set; }

    public required string Description { get; set; }

    public int Price { get; set; }

    public string Image { get; set; }

    public int UserId { get; set; }

    public User User { get; set; }
}
