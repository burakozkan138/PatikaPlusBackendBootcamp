using System;

namespace BasicExample.Models;

public class CustomerOrdersVievModel
{
  public Customer Customer { get; set; }
  public List<Order> Orders { get; set; }
}
