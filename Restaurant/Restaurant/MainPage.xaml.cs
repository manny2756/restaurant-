﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace Restaurant
{
  // Learn more about making custom code visible in the Xamarin.Forms previewer
  // by visiting https://aka.ms/xamarinforms-previewer
  [DesignTimeVisible(false)]
  public partial class MainPage : ContentPage
  {
    public static MainPage Current { get; set; }
    public MainPage()
    {
      InitializeComponent();
      Current = this;
    }

    public MainPage(string page)
    {
      InitializeComponent();
      Current = this;
       
      
      if (page == "Specials")
      {
        Tabs.SelectSpecialsTab(); 
      }
      else if (page == "Menu")
      {
        Tabs.SelectMenuTab();
      }
    }


  }
}
