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
  public partial class SecNavBar : ContentView
  {
    public SecNavBar()
    {
      InitializeComponent();
    }

    private void X_Tapped(object sender, EventArgs e)
    {
      Navigation.PushAsync(new SideMenu());
    }
  }
}