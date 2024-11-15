namespace BasicWebApp.Models;

public class Item
{
    private int id { get; set; }
    private int siteId { get; set; }
    private int productId { get; set; }
    private string currency  { get; set; }
    private string paymenthMedthod { get; set; }
    private int retailCost { get; set; }
    private int accountDiscount { get; set; }
    private int couponDiscount { get; set; }
    private int netCost { get; set; }
    private JobData JobData { get; set; }
}