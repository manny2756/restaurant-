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
  public partial class Specials : ContentView
  {
    public string CategoryTag

    {

      get => (string)GetValue(CategoryTagProperty);

      set => SetValue(CategoryTagProperty, value);

    }

    public static readonly BindableProperty CategoryTagProperty = BindableProperty.Create(

                                                         propertyName: "CategoryTag",
                                                         returnType: typeof(string),

                                                         declaringType: typeof(Specials),

                                                         defaultBindingMode: BindingMode.TwoWay
                                                         );
    public string CategoryId

    {

      get => (string)GetValue(CategoryIdProperty);

      set => SetValue(CategoryIdProperty, value);

    }
    public static readonly BindableProperty CategoryIdProperty = BindableProperty.Create(

                                                         propertyName: "CategoryId",
                                                         returnType: typeof(string),

                                                         declaringType: typeof(Specials),

                                                         defaultBindingMode: BindingMode.TwoWay
                                                         );
    public string CategoryName

    {

      get => (string)GetValue(CategoryNameProperty);

      set => SetValue(CategoryNameProperty, value);

    }

    public static readonly BindableProperty CategoryNameProperty = BindableProperty.Create(

                                                         propertyName: "CategoryName",

                                                         returnType: typeof(string),

                                                         declaringType: typeof(Specials),

                                                         defaultValue: "",

                                                         defaultBindingMode: BindingMode.TwoWay
                                                         );
    public string Image

    {

      get => (string)GetValue(ImageProperty);

      set => SetValue(ImageProperty, value);

    }

    public static readonly BindableProperty ImageProperty = BindableProperty.Create(

                                                         propertyName: "Image",
                                                         returnType: typeof(string),

                                                         declaringType: typeof(Specials),

                                                         defaultBindingMode: BindingMode.TwoWay
                                                         );
    public string LeftImage

    {

      get => (string)GetValue(LeftImageProperty);

      set => SetValue(LeftImageProperty, value);

    }

    public static readonly BindableProperty LeftImageProperty = BindableProperty.Create(

                                                         propertyName: "LeftImage",
                                                         returnType: typeof(string),

                                                         declaringType: typeof(Specials),

                                                         defaultBindingMode: BindingMode.TwoWay
                                                         );
    public string OnSpecial

    {

      get => (string)GetValue(OnSpecialProperty);

      set => SetValue(OnSpecialProperty, value);

    }

    public static readonly BindableProperty OnSpecialProperty = BindableProperty.Create(

                                                         propertyName: "OnSpecial",
                                                         returnType: typeof(string),

                                                         declaringType: typeof(Specials),

                                                         defaultBindingMode: BindingMode.TwoWay
                                                         );
    public Specials()
    {
      InitializeComponent();
    }

    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
      Menu.Current.HideCategories();
      Menu.Current.SetCatTitle(CategoryName);
      Menu.Current.LoadFoodItemsForCategory(CategoryId);
    }
  }
}