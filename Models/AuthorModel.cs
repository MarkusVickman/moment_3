using System.ComponentModel.DataAnnotations;
using Book.Models;

namespace Author.Models;

public class AuthorModel {
    // Properties
    public int Id { get; set; }    
    public string? FirstName { get; set; }
    public string?  LastName { get; set; }

    public List<BookModel>? Book { get; set; }
}