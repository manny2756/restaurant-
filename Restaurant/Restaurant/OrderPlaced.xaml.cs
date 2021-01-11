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
  public partial class OrderPlaced : ContentPage
  {
    public OrderPlaced()
    {
      InitializeComponent();
    }

    private void OrderPlaced_Clicked(object sender, EventArgs e)
    {
      Navigation.PushAsync(new OrderStatus());
      
    }

    private void BackToMenu_Clicked(object sender, EventArgs e)
    {
      Navigation.PushAsync(new MainPage("Menu"));
      MainPage.Current.HomeView.IsVisible = false;
      MainPage.Current.MenuPage.IsVisible = true;
      MainPage.Current.SalesPage.IsVisible = false;
      MainPage.Current.SpecialsPage.IsVisible = false;

    }
  }
}