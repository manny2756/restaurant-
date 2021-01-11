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
  public partial class Cart : ContentPage
  {
    public Cart()
    {
      InitializeComponent();
    }

    private void OrderPlaced_Clicked(object sender, EventArgs e)
    {
      Navigation.PushAsync(new OrderStatus());
    }

    private void PaymentMethod_Tapped(object sender, EventArgs e)
    {
      Navigation.PushAsync(new PaymentMethod());
    }

    private void EditItem_Tapped(object sender, EventArgs e)
    {
      Navigation.PushAsync(new ItemPage());
    }
  }
}