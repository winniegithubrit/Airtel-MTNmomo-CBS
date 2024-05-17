namespace Co_Banking_System.Models
{
  public class TransactionEnquiryResponseModel
  {
    public DataModel Data { get; set; }
    public StatusModel Status { get; set; }
  }

  public class DataModel
  {
    public TransactionResponseModel Transaction { get; set; }
  }

  public class StatusModel
  {
    public string Code { get; set; }
    public string Message { get; set; }
    public string ResultCode { get; set; }
    public bool Success { get; set; }
  }
}
