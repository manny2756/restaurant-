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
  public partial class Statusview : ContentView
  {
    public Statusview()
    {
      InitializeComponent();
      //ShrinkCircles();
      Load();
      
    }
    public async Task FillOrdersAsync()
    {
      

      
      await FirstCircle.FadeTo(0, 1500);
      await SecCircle.FadeTo(0, 1500);
      await ThirdCircle.FadeTo(0, 1500);
      await FourthCircle.FadeTo(0, 1500);
      await RedOne.ScaleTo(0.8, 1000);
      await RedTwo.ScaleTo(0.8, 1000);
      await Redthree.ScaleTo(0.8, 1000);
      await RedFour.ScaleTo(0.8, 1000);


    }
    public async void Load()
    {
      await FillOrdersAsync();
    
    }

    public void ShrinkCircles()
    {
      Animation shrinkCircles = new Animation();
      Animation firstOpacity = new Animation(v => FirstCircle.Opacity = v, 1, 0, Easing.SinInOut);
      Animation secOpacity = new Animation(v => SecCircle.Opacity = v, 1, 0, Easing.SinInOut);
      Animation thirdOpacity = new Animation(v => ThirdCircle.Opacity = v, 1, 0, Easing.SinInOut);
      Animation fourthOpacity = new Animation(v => FourthCircle.Opacity = v, 1, 0, Easing.SinInOut);
      Animation shrinkFirst = new Animation(m => FirstCircle.WidthRequest = m, 0, -1 * FirstCircle.WidthRequest);
      Animation shrinkSecond = new Animation(m => SecCircle.WidthRequest = m, 0, 1 * SecCircle.WidthRequest);
      Animation shrinkThird = new Animation(m => ThirdCircle.WidthRequest = m, 0, 1 * ThirdCircle.WidthRequest);
      Animation shrinkFourth = new Animation(m => FourthCircle.WidthRequest = m, 0, 1 * FourthCircle.WidthRequest);
      shrinkCircles.Add(0, 1, firstOpacity);
      shrinkCircles.Add(0, 1, secOpacity);
      shrinkCircles.Add(0, 1, thirdOpacity);
      shrinkCircles.Add(0, 1, fourthOpacity);
      shrinkCircles.Add(0, 1, shrinkFirst);
      shrinkCircles.Add(0, 1, shrinkSecond);
      shrinkCircles.Add(0, 1, shrinkThird);
      shrinkCircles.Add(0, 1, shrinkFourth);
      shrinkCircles.Commit(this, "ShrinkCircles", 16, 375);
      
    }
  }
}