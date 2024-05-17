using System.Collections.Generic;

namespace Co_Banking_System.Models
{
  public class CashInRequestModel
  {
    public SubscriberModel Subscriber { get; set; }
    public TransactionModel Transaction { get; set; }
    public List<AdditionalInfoModel> AdditionalInfo { get; set; }
    public string Reference { get; set; }
    public string Pin { get; set; }
  }

  public class SubscriberModel
  {
    public string Msisdn { get; set; }
  }

  public class TransactionModel
  {
    public string Amount { get; set; }
    public string Id { get; set; }
  }

  public class AdditionalInfoModel
  {
    public string Key { get; set; }
    public string Value { get; set; }
  }
}
