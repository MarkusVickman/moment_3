using System.ComponentModel.DataAnnotations;

namespace Book.Models;

public class BookModel
{
    // Properties
    public int ID { get; set; }
    public string? BookName { get; set; }
    public int? Amount { get; set; }
}