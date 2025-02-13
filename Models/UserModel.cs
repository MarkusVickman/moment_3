using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Loan.Models;

namespace User.Models;

//Modell över användare, Relation till boklån.
public class UserModel
{
    // Properties
    public int Id { get; set; }

    [Required]
    [Display(Name = "Namn")]
    public string? FirstName { get; set; }

    [Required]
    [Display(Name = "Email")]
    [Column(TypeName = "Email")]
    [EmailAddress]
    public string? Email { get; set; }

    public List<LoanModel>? Loan { get; set; }

}