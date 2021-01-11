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
  public partial class SideMenu : ContentPage
  {
    public SideMenu()
    {
      InitializeComponent();
    }

    private void Review_Tapped(object sender, EventArgs e)
    {
      Navigation.PushAsync(new Review());
    }

    private void AboutUs_Tapped(object sender, EventArgs e)
    {
      Navigation.PushAsync(new About());
    }

    private void Account_Tapped(object sender, EventArgs e)
    {
      Navigation.PushAsync(new MyAccount());

    }

    private void SignOut_Tapped(object sender, EventArgs e)
    {
      Navigation.PopToRootAsync();
    }

    private void Ex_Tapped(object sender, EventArgs e)
    {
      Navigation.PopAsync();
    }
  }
}