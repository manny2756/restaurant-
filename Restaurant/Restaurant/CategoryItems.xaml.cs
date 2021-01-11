using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Restaurant
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class CategoryItems : ContentPage
  {
    public CategoryItems(string categoryId)
    {
      InitializeComponent();
      List<FoodItemInfo> itemsInCategory = MenuCache.MenuItems.FindAll(x => x.CategoryId == categoryId);
      foreach(FoodItemInfo f in itemsInCategory)
      {
        FoodItem item = new FoodItem(f);
        CategoryItemsStack.Children.Add(item);
      }
    }
  }
}