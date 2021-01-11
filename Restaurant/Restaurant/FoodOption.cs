using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Restaurant
{
  public class FoodOption
  {
    public string Title { get; set; } = "Extra Spicy";

    public string Id { get; set; }

    public FoodOption()
    {
      Id = Guid.NewGuid().ToString();
    }

    //This object needs a string for the title, a boolean for determining if checked or not, and a string for an ID

    public bool IsChecked { get; set; } = true;
  


  }

}
