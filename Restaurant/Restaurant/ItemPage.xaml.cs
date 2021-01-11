using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Restaurant
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class ItemPage : ContentPage
  {
    public FoodItemInfo ItemInfo { get; set; }
    public List<FoodOption> ItemOptions { get; set; }
    public ItemPage()
    {
      InitializeComponent();

    }
    public ItemPage(FoodItemInfo itemInfo)
    {
      InitializeComponent();
      ItemInfo = itemInfo;
      GetItemOptions();
    }

    public void GetItemOptions()
    {
      ItemOptions = new List<FoodOption>();
      foreach(string id in ItemInfo.Options)
      {
        FoodOption option = MenuCache.MenuOptions?.Find(x => x.Id == id);
        if (option != null)
        {
          ItemOptions.Add(option);
        }
      }
      if (ItemOptions?.Count > 0)
      {
        LoadFoodOptions();
      }
    }

    public void LoadFoodOptions()
    {
      foreach(FoodOption o in ItemOptions)
      {
        RestaurantCheck check = new RestaurantCheck(o);
        OptionsRadioStack.Children.Add(check);
        //here instantiate the ReestaurantCheck object
        //then add it to the options stack ex. OptionsRadioStack
      }
    }

    private void AddToCart_Tapped(object sender, EventArgs e)
    {
      Navigation.PushAsync(new Cart());
    }
  }
}