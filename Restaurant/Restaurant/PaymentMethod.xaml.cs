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
  public partial class PaymentMethod : ContentPage
  {
    public PaymentMethod()
    {
      InitializeComponent();
    }

    

    private void Master_Tapped(object sender, EventArgs e)
    {
      Master.Source = ImageSource.FromFile("check.png");
      Visa.Source = ImageSource.FromFile("unchecked.png");
      Paypal.Source = ImageSource.FromFile("unchecked.png");
    }

    private void Visa_Tapped(object sender, EventArgs e)
    {
      Master.Source = ImageSource.FromFile("unchecked.png");
      Visa.Source = ImageSource.FromFile("check.png");
      Paypal.Source = ImageSource.FromFile("unchecked.png");
    }

    private void Paypal_Tapped(object sender, EventArgs e)
    {
      Master.Source = ImageSource.FromFile("unchecked.png");
      Visa.Source = ImageSource.FromFile("unchecked.png");
      Paypal.Source = ImageSource.FromFile("check.png");
    }

    private void Plus_Tapped(object sender, EventArgs e)
    {
      Navigation.PushAsync(new NewPayment());
    }
  }
}