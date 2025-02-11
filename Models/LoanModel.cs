using System.ComponentModel.DataAnnotations;

namespace Loan.Models;

public class LoanModel {
    // Properties
    public int Id { get; set; }    
    public string? FirstName { get; set; }
    public string?  LastName { get; set; }
    public string?  Email { get; set; }

}