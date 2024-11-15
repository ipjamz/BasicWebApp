namespace BasicWebApp.Models;

public class Order
{
     private int id { get; set; }
     private string status { get; set; }
     private string paymenthMethod { get; set; }
     private string recruiterId { get; set; }
     private string divisionId { get; set; }
     private string companyId { get; set; }
     private string validated { get; set; }
     private string created { get; set; }
     private string completed { get; set; }
     private Item[] items { get; set; }
}


