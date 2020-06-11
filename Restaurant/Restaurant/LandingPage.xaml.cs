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
  public partial class LandingPage : ContentPage
  {
    public LandingPage()
    {
      InitializeComponent();
    }

        private void Menu_Clicked(object sender, EventArgs e)
        {
          Navigation.PushAsync(new MainPage());
          MainPage.Current.HomeView.IsVisible = false;
          MainPage.Current.MenuPage.IsVisible = true;
          MainPage.Current.SalesPage.IsVisible = false;
          MainPage.Current.ServicesPage.IsVisible = false;
          
        }

    private void Specials_Clicked(object sender, EventArgs e)
    {
      Navigation.PushAsync(new MainPage());
      MainPage.Current.HomeView.IsVisible = false;
      MainPage.Current.MenuPage.IsVisible = false;
      MainPage.Current.SalesPage.IsVisible = false;
      MainPage.Current.ServicesPage.IsVisible = true;
    }

    private void Signin_Clicked(object sender, EventArgs e)
    {
      Navigation.PushAsync(new Signin());
    }
  }
}