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
  public partial class ContinueAsGuest : ContentPage
  {
    public ContinueAsGuest()
    {
      InitializeComponent();
    }

        private void Guest_SignIn(object sender, EventArgs e)
        {
      Navigation.PushAsync(new MainPage());
      MainPage.Current.HomeView.IsVisible = false;
      MainPage.Current.MenuPage.IsVisible = false;
      MainPage.Current.SalesPage.IsVisible = true;
      MainPage.Current.SpecialsPage.IsVisible = false;
    }
    }
}