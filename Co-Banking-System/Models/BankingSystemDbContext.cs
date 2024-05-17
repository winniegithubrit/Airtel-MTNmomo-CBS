using Microsoft.EntityFrameworkCore;

namespace Co_Banking_System.Models
{
  public class BankingSystemDbContext : DbContext
  {
    public BankingSystemDbContext(DbContextOptions<BankingSystemDbContext> options) : base(options)
    {
    }

    public DbSet<CashInRequestModel> CashInRequests { get; set; }
    public DbSet<CashInResponseModel> CashInResponses { get; set; }
    public DbSet<TransactionEnquiryResponseModel> TransactionEnquiryResponses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      // Configure any additional settings or constraints for your models
    }
  }
}
