using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Restaurant.MenuCache;

namespace Restaurant
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class Menu : ContentView
  {
    public static Menu Current { get; set; }

    public Menu()
    {
      InitializeComponent();
      MenuItems = new List<FoodItemInfo> { new FoodItemInfo { CategoryId = "Breakfast", Title="Pancakes",LeftImage="breakFast2.png"} ,
       new FoodItemInfo { CategoryId = "Breakfast", Title="Sunny Side Breakfast",LeftImage="breakFast2.png", Options= new List<string>{ "No Sausage", "No Beans", "No Bacon", "Add Extra Bacon", "Add Extra Sausage"} },
       new FoodItemInfo { CategoryId = "Breakfast", Title="Blue Berry Pancakes",LeftImage="pancakes.png", Options= new List<string>{ "No Blueberries", "No Butter", "No Syrup","Add More Pancackes", "Add Bacon"}  },
       new FoodItemInfo { CategoryId = "Breakfast", Title="Scrabble Breakfast",LeftImage="entrees.png", Options= new List<string>{ "No Sausage", "No Beans", "No Bacon", "Add Extra Bacon", "Add Extra Sausage" }  },
       new FoodItemInfo { CategoryId = "Breakfast", Title="Waffles",LeftImage="waffles.png", Options= new List<string>{ "No Sausage", "No Beans", "No Bacon", "Add Extra Bacon", "Add Extra Sausage" }  },
       new FoodItemInfo { CategoryId = "Meals", Title="Chicken Wings",LeftImage="spicychickenwings.png" , Options= new List<string>{ "No Sausage", "No Beans", "No Bacon", "Add Extra Bacon", "Add Extra Sausage" }  },
       new FoodItemInfo { CategoryId = "Meals", Title="Cheese Burger",LeftImage="cheeseburger.png" , Options= new List<string>{ "No Sausage", "No Beans", "No Bacon", "Add Extra Bacon", "Add Extra Sausage" }  },
       new FoodItemInfo { CategoryId = "Meals", Title="Taco Tuesday",LeftImage="tacos.png"  , Options= new List<string>{ "No Sausage", "No Beans", "No Bacon", "Add Extra Bacon", "Add Extra Sausage" } },
       new FoodItemInfo { CategoryId = "Meals", Title="Jam Jimbalaya",LeftImage="jimbalaya.png"  , Options= new List<string>{ "No Sausage", "No Beans", "No Bacon", "Add Extra Bacon", "Add Extra Sausage" } },
       new FoodItemInfo { CategoryId = "Drinks", Title="Mtn Dew",LeftImage="mountaindew.png", Options= new List<string>{ "No Sausage", "No Beans", "No Bacon", "Add Extra Bacon", "Add Extra Sausage" }  },
       new FoodItemInfo { CategoryId = "Drinks", Title="Sprite",LeftImage="sprite.png", Options = new List<string> { "No Sausage", "No Beans", "No Bacon", "Add Extra Bacon", "Add Extra Sausage" }  },
       new FoodItemInfo { CategoryId = "Drinks", Title="7up",LeftImage="sevup.png" , Options= new List<string>{ "No Sausage", "No Beans", "No Bacon", "Add Extra Bacon", "Add Extra Sausage" } },
       new FoodItemInfo { CategoryId = "Drinks", Title="Pepsi",LeftImage="pepsi.png", Options= new List<string>{ "No Sausage", "No Beans", "No Bacon", "Add Extra Bacon", "Add Extra Sausage" }  },
       new FoodItemInfo { CategoryId = "Drinks", Title="Coke",LeftImage="coke.png" , Options= new List<string>{ "No Sausage", "No Beans", "No Bacon", "Add Extra Bacon", "Add Extra Sausage" } },
       new FoodItemInfo { CategoryId = "Drinks", Title="Water",LeftImage="water.png" , Options= new List<string>{ "No Sausage", "No Beans", "No Bacon", "Add Extra Bacon", "Add Extra Sausage" } },
       new FoodItemInfo { CategoryId = "Appetizers", Title="Sunny Prawns",LeftImage="sunnyprawns.png", Options= new List<string>{ "No Sausage", "No Beans", "No Bacon", "Add Extra Bacon", "Add Extra Sausage" }  },
       new FoodItemInfo { CategoryId = "Appetizers", Title="Spicy Meatballs",LeftImage="meatballs.png" , Options= new List<string>{ "No Sausage", "No Beans", "No Bacon", "Add Extra Bacon", "Add Extra Sausage" } },
       new FoodItemInfo { CategoryId = "Appetizers", Title="Fried Shrimp",LeftImage="breakFast2.png", Options= new List<string>{ "No Sausage", "No Beans", "No Bacon", "Add Extra Bacon", "Add Extra Sausage" }  },
       new FoodItemInfo { CategoryId = "Appetizers", Title="Spicy Chicken Wings",LeftImage="spicychickenwings.png" , Options= new List<string>{ "No Sausage", "No Beans", "No Bacon", "Add Extra Bacon", "Add Extra Sausage" } },
       new FoodItemInfo { CategoryId = "Appetizers", Title="Panini",LeftImage="panini.png", Options= new List<string>{ "No Sausage", "No Beans", "No Bacon", "Add Extra Bacon", "Add Extra Sausage" }  },
       new FoodItemInfo { CategoryId = "Other", Title="Chocolate Chip Cookies",LeftImage="cookies.png", Options= new List<string>{ "No Sausage", "No Beans", "No Bacon", "Add Extra Bacon", "Add Extra Sausage" }  },
       new FoodItemInfo { CategoryId = "Other", Title="Milk Shake",LeftImage="breakFast2.png", Options= new List<string>{ "No Sausage", "No Beans", "No Bacon", "Add Extra Bacon", "Add Extra Sausage" }  },
       new FoodItemInfo { CategoryId = "Other", Title="Cake",LeftImage="breakFast2.png", Options= new List<string>{ "asdnfdkfasdfd-w3737fjsd", "aksdfasdfakal;jdseis"}  },
       new FoodItemInfo { CategoryId = "Other", Title="Ice Cream",LeftImage="icecream.png" , Options= new List<string>{ "asdnfdkfasdfd-w3737fjsd", "aksdfasdfakal;jdseis"} },
       new FoodItemInfo { CategoryId = "Other", Title = "Cookie w/ Ice Cream", LeftImage = "pizookie.png" , Options= new List<string>{ "asdnfdkfasdfd-w3737fjsd", "aksdfasdfakal;jdseis"} } };

      MenuOptions = new List<FoodOption>
      {
        new FoodOption{Title = "Mild"}
      };

      InsertFoodOptions();

      //Here you need to create FoodOptions
    
      Current = this;
      BindingContext = this;
      ItemsScroll.TranslationX = CategoriesScroll.Width;
    }

    private void InsertFoodOptions()
    {
      foreach(FoodItemInfo f in MenuItems)
      {
        // f.Options.Add("No Sausage");
        //or you could assign all at once
        //f.Options = new List<string> { "gfgawsef44t65465453w", "gfgawsef44t65465453w", "gfgawsef44t65465453wp" };
        //or search for a specific option and add
        if (f.CategoryId == "Meals")
        {
          FoodOption option = MenuOptions?.Find(x => x.Title == "Mild");
          if (option != null)
          {
            f.Options.Add(option.Id);
          }
        }
        else if (f.CategoryId == "Breakfast")
        {

        }
      }
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
      var items = MenuCache.MenuItems.FindAll(x => x.CategoryId == categoryId);
      FoodItemsStack.Children?.Clear();
      foreach(FoodItemInfo f in items)
      {
        FoodItem item = new FoodItem(f);
       
        FoodItemsStack.Children.Add(item);
      }

    }
    private void BackToCatButton_Clicked(object sender, EventArgs e)
    {
      ShowCategories();
    }
  }
}