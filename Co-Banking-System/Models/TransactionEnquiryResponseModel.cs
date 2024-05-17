namespace Co_Banking_System.Models
{
  public class TransactionEnquiryResponseModel
  {
    public TransactionEnquiryResponseDataModel Data { get; set; }
    public StatusModel Status { get; set; }
  }

  public class TransactionEnquiryResponseDataModel
  {
    public TransactionResponseModel Transaction { get; set; }
  }
}
