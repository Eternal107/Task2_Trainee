using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Linq;
using Rg.Plugins.Popup.Services;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace task2
{
    public partial class App : Application
    {
        public App()
        {

            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            

        }






        protected override void OnStart()
        {
            InnitTimer();
        }

        protected override void OnSleep()
        {
            
            
        }

        protected override void OnResume()
        {
            var Page = MainPage.Navigation.NavigationStack.Last();

            if (Page is MainPage)
                PopupNavigation.Instance.PushAsync(new Popup(nameof(OnResume)));
        }


        public void InnitTimer ()
        {
             PopupTime();
             
             MessagingCenter.Subscribe<App>((App)Application.Current, "PopupTimer", (sender) => {
                PopupTime();
             });
        }

        public void PopupTime()
        {
            Device.StartTimer(TimeSpan.FromSeconds(30), () =>
            {
                PopupNavigation.Instance.PushAsync(new PopupTime(DateTime.Now.ToString("HH:mm:ss")));

                return false; 
            });

        }


    }
}
