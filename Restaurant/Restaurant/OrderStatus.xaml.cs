using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Restaurant
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class OrderStatus : ContentPage
  {
    public OrderStatus()
    {
      InitializeComponent();
      
    }
  
    
      public void PlacePhoneCall(string number)
      {
        try
        {
          PhoneDialer.Open(number);
        }
        catch (ArgumentNullException anEx)
        {
          // Number was null or white space
        }
        catch (FeatureNotSupportedException ex)
        {
          // Phone Dialer is not supported on this device.
        }
        catch (Exception ex)
        {
          // Other error has occurred.
        }
      }
    

    private void CallRes_Clicked(object sender, EventArgs e)
    {
      PlacePhoneCall("12345625");
    }

    private void EditItem_Tapped(object sender, EventArgs e)
    {
      Navigation.PushAsync(new ItemPage());
    }
  }
}