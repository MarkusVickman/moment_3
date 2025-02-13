
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using User.Models;
using Book.Models;

namespace Loan.Models;

//Modell över boklån, Relation till böcker och användare där bok id och användar id är FK i denna tabell
public class LoanModel
{
    // Properties
    public int Id { get; set; }

    [Required]
    [Display(Name = "Datum")]
    [Column(TypeName = "Date")]
    public DateTime CreatedDate { get; set; }

    [Required]
    [Display(Name = "Bok")]
    public int? BookId { get; set; }

    [Display(Name = "Bok")]
    public BookModel? Book { get; set; }

    [Required]
    [Display(Name = "Användare")]
    public int? UserId { get; set; }

    [Display(Name = "Användare")]
    public UserModel? User { get; set; }

    public LoanModel()
    {
        CreatedDate = DateTime.Now;
    }
}