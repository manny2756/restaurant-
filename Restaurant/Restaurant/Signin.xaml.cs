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
  public partial class Signin : ContentPage
  {
    public Signin()
    {
      InitializeComponent();
    }

        private void CreateAccount_Clicked(object sender, EventArgs e)
        {
          Navigation.PushAsync(new CreateAccount());
    }

    private void Guest_Clicked(object sender, EventArgs e)
    {
      Navigation.PushAsync(new ContinueAsGuest());
    }

    private void SignIn_Clicked(object sender, EventArgs e)
    {
      Navigation.PushAsync(new MainPage());
      MainPage.Current.HomeView.IsVisible = false;
      MainPage.Current.MenuPage.IsVisible = false;
      MainPage.Current.SalesPage.IsVisible = true;
      MainPage.Current.ServicesPage.IsVisible = false;
    }
  }
}