using System;
using Xam.Plugin.SimpleBottomDrawer.Samples;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Xam.Plugin.SimpleBottomDrawer
{
   /// <summary>
   /// Sample app for SimpleBottomDrawer
   /// </summary>
   public partial class App : Application
   {
      /// <summary>
      /// Default constructor
      /// </summary>
      public App()
      {
         InitializeComponent();

         MainPage = new NavigationPage(new MainPage());
      }
   }
}
