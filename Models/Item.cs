namespace BasicWebApp.Models;

public class Item
{
    public int id { get; set; }
    public int siteId { get; set; }
    public int productId { get; set; }
    public string currency  { get; set; }
    public string paymenthMedthod { get; set; }
    public int retailCost { get; set; }
    public int accountDiscount { get; set; }
    public int couponDiscount { get; set; }
    public int netCost { get; set; }
    public JobData JobData { get; set; }
}