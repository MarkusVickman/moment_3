using Microsoft.EntityFrameworkCore;
using Book.Models;
using Author.Models;
using Loan.Models;
using User.Models;

namespace Book.Data;

public class ApplicationDbContext : DbContext {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<BookModel> Book { get; set; }
}