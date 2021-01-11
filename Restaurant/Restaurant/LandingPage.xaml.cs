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
          Navigation.PushAsync(new MainPage("Menu"));
          MainPage.Current.HomeView.IsVisible = false;
          MainPage.Current.MenuPage.IsVisible = true;
          MainPage.Current.SalesPage.IsVisible = false;
          MainPage.Current.SpecialsPage.IsVisible = false;
          
          

    }

    private void Specials_Clicked(object sender, EventArgs e)
    {
      Navigation.PushAsync(new MainPage("Specials"));
      MainPage.Current.HomeView.IsVisible = false;
      MainPage.Current.MenuPage.IsVisible = false;
      MainPage.Current.SalesPage.IsVisible = false;
      MainPage.Current.SpecialsPage.IsVisible = true;
      


    }

    private void Signin_Clicked(object sender, EventArgs e)
    {
      Navigation.PushAsync(new Signin());
    }

    private void Guest_Clicked1(object sender, EventArgs e)
    {
      Navigation.PushAsync(new ContinueAsGuest());
    }
  }
}