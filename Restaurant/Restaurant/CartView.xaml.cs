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
  public partial class CartView : ContentView
  {
    public CartView()
    {
      InitializeComponent();
    }

    private void Cart_Clicked(object sender, EventArgs e)
    {
      Navigation.PushAsync(new Cart());
    }
  }
}