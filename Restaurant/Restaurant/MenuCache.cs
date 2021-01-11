using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
  public static class MenuCache
  {
    public static List<FoodItemInfo> MenuItems { get; set; }
    public static List<FoodOption> MenuOptions { get; set; }
    public static List<FoodOptionGroup> MenuOptionGroups { get; set; }
  }

  public class FoodOptionGroup
  {

  }
}
