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
  public partial class View1 : ContentView
  {
    public View1()
    {
      InitializeComponent();
    }
    private void Button_Clicked(object sender, EventArgs e)
    {

      MainPage.Current.HomeView.IsVisible = false;
      MainPage.Current.MenuPage.IsVisible = true;
      MainPage.Current.SalesPage.IsVisible = false;
      MainPage.Current.ServicesPage.IsVisible = false;
      MainPage.Current.CheckoutPage.IsVisible = false;

    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
      MainPage.Current.HomeView.IsVisible = false;
      MainPage.Current.MenuPage.IsVisible = false;
      MainPage.Current.SalesPage.IsVisible = false;
      MainPage.Current.ServicesPage.IsVisible = true;
      MainPage.Current.CheckoutPage.IsVisible = false;

    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {

      MainPage.Current.HomeView.IsVisible = false;
      MainPage.Current.MenuPage.IsVisible = false;
      MainPage.Current.SalesPage.IsVisible = true;
      MainPage.Current.ServicesPage.IsVisible = false;
      MainPage.Current.CheckoutPage.IsVisible = false;

    }

       

        private void Button_Clicked_3(object sender, EventArgs e)
        {
          MainPage.Current.HomeView.IsVisible = false;
          MainPage.Current.MenuPage.IsVisible = false;
          MainPage.Current.SalesPage.IsVisible = false;
          MainPage.Current.ServicesPage.IsVisible = false;
          MainPage.Current.CheckoutPage.IsVisible = true;
    }
    }
}