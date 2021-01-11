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
  public partial class Review : ContentPage
  {
    public Review()
    {
      InitializeComponent();
    }

    private void OneStar_Tapped(object sender, EventArgs e)
    {
      OneStar.Source = ImageSource.FromFile("yellowstar.png");
      TwoStars.Source = ImageSource.FromFile("graystar.png");
      ThreeStars.Source = ImageSource.FromFile("graystar.png");
      FourStars.Source = ImageSource.FromFile("graystar.png");
      FiveStars.Source = ImageSource.FromFile("graystar.png");
      StarCount.Text = "1 out of 5 Stars";
    }

    private void TwoStars_Tapped(object sender, EventArgs e)
    {
      OneStar.Source = ImageSource.FromFile("yellowstar.png");
      TwoStars.Source = ImageSource.FromFile("yellowstar.png");
      ThreeStars.Source = ImageSource.FromFile("graystar.png");
      FourStars.Source = ImageSource.FromFile("graystar.png");
      FiveStars.Source = ImageSource.FromFile("graystar.png");
      StarCount.Text = "2 out of 5 Stars";
    }

    private void ThreeStars_Tapped(object sender, EventArgs e)
    {
      OneStar.Source = ImageSource.FromFile("yellowstar.png");
      TwoStars.Source = ImageSource.FromFile("yellowstar.png");
      ThreeStars.Source = ImageSource.FromFile("yellowstar.png");
      FourStars.Source = ImageSource.FromFile("graystar.png");
      FiveStars.Source = ImageSource.FromFile("graystar.png");
      StarCount.Text = "3 out of 5 Stars";
    }

    private void FourStars_Tapped(object sender, EventArgs e)
    {
      OneStar.Source = ImageSource.FromFile("yellowstar.png");
      TwoStars.Source = ImageSource.FromFile("yellowstar.png");
      ThreeStars.Source = ImageSource.FromFile("yellowstar.png");
      FourStars.Source = ImageSource.FromFile("yellowstar.png");
      FiveStars.Source = ImageSource.FromFile("graystar.png");
      StarCount.Text = "4 out of 5 Stars";
    }

    private void FiveStars_Tapped(object sender, EventArgs e)
    {
      OneStar.Source = ImageSource.FromFile("yellowstar.png");
      TwoStars.Source = ImageSource.FromFile("yellowstar.png");
      ThreeStars.Source = ImageSource.FromFile("yellowstar.png");
      FourStars.Source = ImageSource.FromFile("yellowstar.png");
      FiveStars.Source = ImageSource.FromFile("yellowstar.png");
      StarCount.Text = "5 out of 5 Stars";
    }
  }
}