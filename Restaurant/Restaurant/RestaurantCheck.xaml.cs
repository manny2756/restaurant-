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
  public partial class RestaurantCheck : ContentView
  {
    public FoodOption Option { get; set; }

    public string CheckTitle { get; set; } 
    public bool IsChecked

    {

      get { return (bool)GetValue(IsCheckedProperty); }

      set { bool hasChanged = false; 
        if ((bool)GetValue(IsCheckedProperty) != value) 
        {
          hasChanged = true;
        } 
        SetValue(IsCheckedProperty, value);
        if (hasChanged)
        {
          CheckChanged?.Invoke(this, value);
        }
      }

    }

    public static readonly BindableProperty IsCheckedProperty = BindableProperty.Create(

                                                         propertyName: "IsChecked",
                                                         returnType: typeof(bool),

                                                         declaringType: typeof(RestaurantCheck),

                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         defaultValue:false
                                                         );

    public delegate void CheckChangedEventArgs(RestaurantCheck check, bool isChecked);

    public event CheckChangedEventArgs CheckChanged;

    internal void UnCheck()
    {
      IsChecked = false;
      ImgCheck.Source = ImageSource.FromFile("unchecked.png");
    }

    internal void Check()
    {
      IsChecked = true;
      ImgCheck.Source = ImageSource.FromFile("check.png");
    }

    public bool IsRadioCheck { get; set; } = false;

    public RestaurantCheck()
    {
      BindingContext = this;
      Option = new FoodOption();
      CheckTitle = Option.Title;
      InitializeComponent();
      if (IsChecked)
      {
        ImgCheck.Source = ImageSource.FromFile("check.png");
      }
      else
      {
        ImgCheck.Source = ImageSource.FromFile("unchecked.png");
      }
    }

    public RestaurantCheck(FoodOption option)
    {
      BindingContext = this;
      Option = option;
      CheckTitle = Option.Title;
      InitializeComponent();
      IsChecked = Option.IsChecked;
      if (IsChecked)
      {
        ImgCheck.Source = ImageSource.FromFile("check.png");
      }
      else
      {
        ImgCheck.Source = ImageSource.FromFile("unchecked.png");
      }
    }

    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
      if (!IsRadioCheck || (!IsChecked && IsRadioCheck))
      {
        IsChecked = !IsChecked;
      }
      if (IsChecked)
      {
        ImgCheck.Source = ImageSource.FromFile("check.png");
      }
      else
      {
        ImgCheck.Source = ImageSource.FromFile("unchecked.png");
      }
    }
  }
}