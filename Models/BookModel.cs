using System.ComponentModel.DataAnnotations;
using Author.Models;
using Loan.Models;

namespace Book.Models;

public class BookModel
{
    // Properties
    public int ID { get; set; }
    public string? ISBN { get; set; }
    public string? BookName { get; set; }
    public int? Amount { get; set; }

    public int? AuthorId { get; set; }

    public AuthorModel? Author { get; set; }
    
    public List<LoanModel>? Loan { get; set; }
}