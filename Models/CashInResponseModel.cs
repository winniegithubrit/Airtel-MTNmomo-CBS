namespace Co_Banking_System.Models
{
  public class CashInResponseModel
  {
    public DataModel Data { get; set; }
    public StatusModel Status { get; set; }
  }

  public class DataModel
  {
    public string Message { get; set; }
    public string Status { get; set; }
    public TransactionResponseModel Transaction { get; set; }
  }

  public class TransactionResponseModel
  {
    public string AirtelMoneyId { get; set; }
    public string Id { get; set; }
  }
}
