namespace BasicWebApp.Models;

public class Order
{ 
      public int id { get; set; }
      public string status { get; set; }
      public string paymenthMethod { get; set; }
      public string recruiterId { get; set; }
      public string divisionId { get; set; }
      public string companyId { get; set; }
      public string validated { get; set; }
      public string created { get; set; }
      public string completed { get; set; } 
      public Item[] items { get; set; }
}


