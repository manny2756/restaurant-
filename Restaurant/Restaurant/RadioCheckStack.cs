using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Restaurant
{
  public class RadioCheckStack : StackLayout 
  {
    protected override void OnAdded(View view)
    {
      base.OnAdded(view);
      RestaurantCheck check = view as RestaurantCheck;
      if (check != null)
      {
        
        check.IsRadioCheck = true;
        check.CheckChanged += Check_CheckChanged;
        if (Children.Count == 1)
        {
          check.Check();
        }
      }
    }

    private void Check_CheckChanged(RestaurantCheck check, bool isChecked)
    {
      if (check.IsChecked)
      {
        foreach (RestaurantCheck r in Children)
        {
          if (check != r)
          {
            r.UnCheck();
          }
        }
      }
    }

    private void Check_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
      if (e.PropertyName == "IsChecked")
      {
        var check = sender as RestaurantCheck;
        if (check.IsChecked)
        {
          foreach (RestaurantCheck r in Children)
          {
            if (check != r)
            {
              r.UnCheck();
            }
          }
        }
      }
    }

    public List<RestaurantCheck> GetCheckedItems()
    {
      var checks = new List<RestaurantCheck>();
      foreach(RestaurantCheck r in Children)
      {
        if (r.IsChecked)
        {
          checks.Add(r);
        }
      }
      return checks;
    }

    public List<FoodOption> GetCheckedOptions()
    {
      var options = new List<FoodOption>();
      foreach (RestaurantCheck r in Children)
      {
        if (r.IsChecked)
        {
          options.Add(r.Option);
        }
      }
      return options;
    }
  }
}
