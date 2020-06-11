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
  public partial class Services : ContentView

  {
    public List<Specials> OnSpecial { get; set; }

    public Services()
    {
      InitializeComponent();
      OnSpecial = new List<Specials> { new Specials { CategoryId = "Specials", CategoryName = "Pancakes", LeftImage = "breakFast2.png" } };
    }
  }
}