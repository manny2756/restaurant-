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
  public partial class NavBar : ContentView
  {
    public NavBar()
    {
      InitializeComponent();
    }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
      MainPage.Current.HomeView.IsVisible = false;
      MainPage.Current.MenuPage.IsVisible = true;
      MainPage.Current.SalesPage.IsVisible = false;
      MainPage.Current.ServicesPage.IsVisible = false;
      MainPage.Current.CheckoutPage.IsVisible = false;
    }
    }
}