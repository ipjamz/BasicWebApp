namespace BasicWebApp.Models;

public class Product
{
    private int product_id { get; set; }
    private int site_id { get; set; }
    private string product_name { get; set; }
    private string product_description { get; set; }
    private int cost { get; set; }
    private bool inventory_only { get; set; }
    private bool @private { get; set; }
}