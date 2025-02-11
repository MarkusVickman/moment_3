using System.ComponentModel.DataAnnotations;
using Loan.Models;

namespace User.Models;

public class UserModel
{
    // Properties
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }

    public List<LoanModel>? Loan { get; set; }

}