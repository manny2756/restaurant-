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
  public partial class MidTabView : ContentView
  {
    public MidTabView()
    {
      InitializeComponent();
    }
    private void Button_Clicked(object sender, EventArgs e)
    {


      SelectMenuTab();

    }

    public void SelectMenuTab()
    {
      MainPage.Current.HomeView.IsVisible = false;
      MainPage.Current.MenuPage.IsVisible = true;
      MainPage.Current.SalesPage.IsVisible = false;
      MainPage.Current.SpecialsPage.IsVisible = false;
      MainPage.Current.CheckoutPage.IsVisible = false;
      SpecialsTab.BackgroundColor = Color.Transparent;
      HomeTab.BackgroundColor  =  Color.Transparent;
      MenuTab.BackgroundColor = Color.White;
    }
    public void SelectSpecialsTab()
    {
      MainPage.Current.HomeView.IsVisible = false;
      MainPage.Current.MenuPage.IsVisible = false;
      MainPage.Current.SalesPage.IsVisible = false;
      MainPage.Current.SpecialsPage.IsVisible = true;
      MainPage.Current.CheckoutPage.IsVisible = false;
      SpecialsTab.BackgroundColor = Color.White;
      HomeTab.BackgroundColor = Color.Transparent;
      MenuTab.BackgroundColor = Color.Transparent;


    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
      SelectSpecialsTab();
      

    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
      SelectHometab();
    }

    public void SelectHometab()
    {
      MainPage.Current.HomeView.IsVisible = false;
      MainPage.Current.MenuPage.IsVisible = false;
      MainPage.Current.SalesPage.IsVisible = true;
      MainPage.Current.SpecialsPage.IsVisible = false;
      MainPage.Current.CheckoutPage.IsVisible = false;
      SpecialsTab.BackgroundColor = Color.Transparent;
      HomeTab.BackgroundColor  =  Color.White;
      MenuTab.BackgroundColor = Color.Transparent;
    }

       

        private void Button_Clicked_3(object sender, EventArgs e)
        {
          MainPage.Current.HomeView.IsVisible = false;
          MainPage.Current.MenuPage.IsVisible = false;
          MainPage.Current.SalesPage.IsVisible = false;
          MainPage.Current.SpecialsPage.IsVisible = false;
          MainPage.Current.CheckoutPage.IsVisible = true;
    }
    }
}