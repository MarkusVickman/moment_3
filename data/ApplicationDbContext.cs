using Microsoft.EntityFrameworkCore;
using Book.Models;
using Author.Models;
using Loan.Models;
using User.Models;

namespace Book.Data;

//inställningar för DbContext, inkluderar databastabeller.
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<BookModel> Book { get; set; }

    public DbSet<AuthorModel> Author { get; set; }

    public DbSet<LoanModel> Loan { get; set; }

    public DbSet<UserModel> User { get; set; }
}