using System.ComponentModel.DataAnnotations;

namespace Book.Models;

public class BookModel
{
    // Properties
    public string? ISBN { get; set; }
    public string? BookName { get; set; }
    public int? Amount { get; set; }
}