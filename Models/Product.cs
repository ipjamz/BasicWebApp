namespace BasicWebApp.Models;

public class Product
{ 
    public int product_id { get; set; }
    public int site_id { get; set; }
    public string product_name { get; set; }
    public int cost { get; set; }
    public bool inventory_only { get; set; }
    public bool @private { get; set; }
}