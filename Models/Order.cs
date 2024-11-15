namespace BasicWebApp.Models;

public class Order
{ 
      public int id { get; set; }
      public string status { get; set; }
      public string paymentMethod { get; set; }
      public int recruiterId { get; set; }
      public int divisionId { get; set; }
      public int companyId { get; set; }
      public bool validated { get; set; }
      public string created { get; set; }
      public string? completed { get; set; } 
      public Item[] items { get; set; }
}


