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
  public partial class Menu : ContentView
  {
    public static Menu Current { get; set; }
    public List<FoodItem> MenuItems { get; set; }
    public Menu()
    {
      InitializeComponent();
      MenuItems = new List<FoodItem> { new FoodItem { CategoryId = "Breakfast", CategoryName="Pancakes",LeftImage="breakFast2.png" },
       new FoodItem { CategoryId = "Breakfast", CategoryName="Sunny Side Breakfast",LeftImage="breakFast2.png" },
       new FoodItem { CategoryId = "Breakfast", CategoryName="Blue Berry Pancakes",LeftImage="pancakes.png" },
       new FoodItem { CategoryId = "Breakfast", CategoryName="Scrabble Breakfast",LeftImage="entrees.png" },
       new FoodItem { CategoryId = "Breakfast", CategoryName="Waffles",LeftImage="waffles.png" },
       new FoodItem { CategoryId = "Meals", CategoryName="Chicken Wings",LeftImage="spicychickenwings.png" },
       new FoodItem { CategoryId = "Meals", CategoryName="Cheese Burger",LeftImage="cheeseburger.png" },
       new FoodItem { CategoryId = "Meals", CategoryName="Taco Tuesday",LeftImage="tacos.png" },
       new FoodItem { CategoryId = "Meals", CategoryName="Jam Jimbalaya",LeftImage="breakFast2.png" },
       new FoodItem { CategoryId = "Drinks", CategoryName="Mtn Dew",LeftImage="mountaindew.png" },
       new FoodItem { CategoryId = "Drinks", CategoryName="Sprite",LeftImage="sprite.png" },
       new FoodItem { CategoryId = "Drinks", CategoryName="7up",LeftImage="sevup.png" },
       new FoodItem { CategoryId = "Drinks", CategoryName="Pepsi",LeftImage="pepsi.png" },
       new FoodItem { CategoryId = "Drinks", CategoryName="Coke",LeftImage="coke.png" },
       new FoodItem { CategoryId = "Drinks", CategoryName="Water",LeftImage="water.png" },
       new FoodItem { CategoryId = "Appetizers", CategoryName="Sunny Prawns",LeftImage="sunnyprawns.png" },
       new FoodItem { CategoryId = "Appetizers", CategoryName="Spicy Meatballs",LeftImage="meatballs.png" },
       new FoodItem { CategoryId = "Appetizers", CategoryName="Fried Shrimp",LeftImage="breakFast2.png" },
       new FoodItem { CategoryId = "Appetizers", CategoryName="Spicy Chicken Wings",LeftImage="spicychickenwings.png" },
       new FoodItem { CategoryId = "Appetizers", CategoryName="Panini",LeftImage="panini.png" },
       new FoodItem { CategoryId = "Other", CategoryName="Chocolate Chip Cookies",LeftImage="breakFast2.png" },
       new FoodItem { CategoryId = "Other", CategoryName="Milk Shake",LeftImage="breakFast2.png" },
       new FoodItem { CategoryId = "Other", CategoryName="Cake",LeftImage="breakFast2.png" },
       new FoodItem { CategoryId = "Other", CategoryName="Ice Cream",LeftImage="icecream.png" },
       new FoodItem { CategoryId = "Other", CategoryName = "Cookie w/ Ice Cream", LeftImage = "pizookie.png" }};
                     
      Current = this;
      ItemsScroll.TranslationX = CategoriesScroll.Width;
    }

    public void ShowItems()
    {
      HideCategories();
    }

    public void HideCategories()
    {
      Animation hideCategories = new Animation();
      Animation catOpacity = new Animation(v => CategoriesScroll.Opacity = v, 1, 0, Easing.SinInOut);
      Animation catMove = new Animation(m => CategoriesScroll.TranslationX = m, 0, -1 * CategoriesScroll.Width);
      hideCategories.Add(0,1,catOpacity);
      hideCategories.Add(0,1, catMove);
      Animation showItems = new Animation();
      Animation itemOpacity = new Animation(v => ItemsScroll.Opacity = v, 0, 1, Easing.SinInOut);
      Animation itemMove = new Animation(m => ItemsScroll.TranslationX = m, CategoriesScroll.Width, 0);
      showItems.Add(0, 1, itemOpacity);
      showItems.Add(0, 1, itemMove);
      ItemsScroll.IsVisible = true;
      hideCategories.Commit(this, "HideCategories",16,375);
      showItems.Commit(this, "ShowItems",16,375);
      
    }

    public void ShowCategories()
    {
      Animation showCategories = new Animation();
      Animation catOpacity = new Animation(v => CategoriesScroll.Opacity = v, 0, 1, Easing.SinInOut);
      Animation catMove = new Animation(m => CategoriesScroll.TranslationX = m, -CategoriesScroll.Width,0);
      showCategories.Add(0, 1, catOpacity);
      showCategories.Add(0, 1, catMove);
      Animation hideItems = new Animation();
      Animation itemOpacity = new Animation(v => ItemsScroll.Opacity = v, 1, 0, Easing.SinInOut);
      Animation itemMove = new Animation(m => ItemsScroll.TranslationX = m, 0,CategoriesScroll.Width);
      hideItems.Add(0, 1, itemOpacity);
      hideItems.Add(0, 1, itemMove);
      ItemsScroll.IsVisible = true;
      showCategories.Commit(this, "ShowCategories",16, 375);
      hideItems.Commit(this, "HideItems",16, 375);
    }
    public void SetCatTitle(string catName)
    {
      CatTitle.Text = catName;

    }

    public void LoadFoodItemsForCategory(string categoryId)
    {
      var items = MenuItems.FindAll(x => x.CategoryId == categoryId);
      FoodItemsStack.Children?.Clear();
      foreach(FoodItem f in items)
      {
        FoodItemsStack.Children.Add(f);
      }

    }
    private void BackToCatButton_Clicked(object sender, EventArgs e)
    {
      ShowCategories();
    }
  }
}