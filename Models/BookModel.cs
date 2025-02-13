using System.ComponentModel.DataAnnotations;
using Author.Models;
using Loan.Models;

namespace Book.Models;

//Modell över böcker, Relation till författare där författar id är FK i denna tabell
//Har även en relation till boklån
public class BookModel
{
    // Properties
    public int ID { get; set; }

    [Required]
    public string? ISBN { get; set; }

    [Required]
    [Display(Name = "Boknamn")]
    public string? BookName { get; set; }

    [Display(Name = "Lager")]
    public int? Amount { get; set; }

    [Display(Name = "Författare")]
    public int? AuthorId { get; set; }

    [Display(Name = "Författare")]
    public AuthorModel? Author { get; set; }

    public List<LoanModel>? Loan { get; set; }
}