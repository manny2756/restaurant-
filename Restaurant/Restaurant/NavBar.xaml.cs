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
  public partial class NavBar : ContentView
  {
    public NavBar()
    {
      InitializeComponent();
      BindingContext = this;
     
    }
    
    public string Image

    {

      get => (string)GetValue(ImageProperty);

      set => SetValue(ImageProperty, value);

    }

    public static readonly BindableProperty ImageProperty = BindableProperty.Create(

                                                         propertyName: "Image",
                                                         returnType: typeof(string),

                                                         declaringType: typeof(NavBar),

                                                         defaultBindingMode: BindingMode.TwoWay
                                                         );
    public string XTapped

    {

      get => (string)GetValue(XTappedProperty);

      set => SetValue(XTappedProperty, value);

    }

    public static readonly BindableProperty XTappedProperty = BindableProperty.Create(

                                                         propertyName: "XTapped",
                                                         returnType: typeof(string),

                                                         declaringType: typeof(NavBar),

                                                         defaultBindingMode: BindingMode.TwoWay
                                                         );


    public bool isXButton;
    private void MenuBars_Tapped(object sender, EventArgs e)
    {
      if (isXButton)
      {
        Navigation.PopAsync();
      }
      else
      {
        Navigation.PushAsync(new SideMenu());
      }
    }

    private void Back_Tapped(object sender, EventArgs e)
    {
      Navigation.PopAsync();
    }
    private void X_Tapped(object sender, EventArgs e)
    {
      Navigation.PopAsync();
    }
  }
}