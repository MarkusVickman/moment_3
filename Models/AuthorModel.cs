using System.ComponentModel.DataAnnotations;
using Book.Models;

namespace Author.Models;

public class AuthorModel
{
    // Properties
    [Display(Name = "Författare")]
    public int Id { get; set; }

    [Required]
    [Display(Name = "Namn")]
    public string? Name { get; set; }

    public List<BookModel>? Book { get; set; }
}