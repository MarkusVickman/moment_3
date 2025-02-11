
using System.ComponentModel.DataAnnotations.Schema;
using User.Models;
using Book.Models;

namespace Loan.Models;

public class LoanModel
{
    // Properties
    public int Id { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedDate { get; set; }

    public int? BookId { get; set; }
    public BookModel? Book { get; set; }

    public int? UserId { get; set; }
    public UserModel? User { get; set; }
}