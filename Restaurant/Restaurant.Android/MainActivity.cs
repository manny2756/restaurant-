using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Content.Res;
using Android.Text;
using Restaurant.Droid;

[assembly: ExportRenderer(typeof(Entry), typeof(CustomEntryRenderer))]
[assembly: ExportRenderer(typeof(Editor), typeof(CustomEditorRenderer))]


namespace Restaurant.Droid
{
    [Activity(Label = "Restaurant", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }

  public class CustomEntryRenderer : EntryRenderer
  {

    public CustomEntryRenderer(Context context) : base(context)
    {

    }
    protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
    {
      base.OnElementChanged(e);

      if (Control != null)
      {
       
        this.Control.SetBackgroundColor(Android.Graphics.Color.Transparent);
        
      }
    }
  }

  public class CustomEditorRenderer : EditorRenderer
  {

    public CustomEditorRenderer(Context context) : base(context)
    {

    }
    protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
    {
      base.OnElementChanged(e);

      if (Control != null)
      {

        this.Control.SetBackgroundColor(Android.Graphics.Color.Transparent);

      }
    }
  }
}