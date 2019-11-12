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
            InnitTimer(30);
        }

        protected override void OnSleep()
        {
            
            
        }

        protected override void OnResume()
        {
            var Page = MainPage.Navigation.NavigationStack.Last();
            var Popup = PopupNavigation.Instance.PopupStack.LastOrDefault(p => p is Popup);
            if (Page is MainPage && Popup==null)
            {
                Popup Resume = new Popup
                {
                    BindingContext = new PopupViewModel(nameof(OnResume))
                };
                PopupNavigation.Instance.PushAsync(Resume);
            }
            else if(Page is MainPage )
            {
                Popup.BindingContext = new PopupViewModel(nameof(OnResume));
            }
        }


        public void InnitTimer (int seconds)
        {
             PopupTime(seconds);
        }

        public void PopupTime(int seconds)
        {
            Device.StartTimer(TimeSpan.FromSeconds(seconds), () =>
            {
                var Popup = PopupNavigation.Instance.PopupStack.LastOrDefault(p => p is Popup);

                if (Popup != null)
                    Popup.BindingContext = new PopupViewModel(DateTime.Now.ToString("HH:mm:ss"));
                else
                {
                    Popup Time = new Popup
                    {
                        BindingContext = new PopupViewModel(DateTime.Now.ToString("HH:mm:ss"))
                    };
                    PopupNavigation.Instance.PushAsync(Time);
                }

                return true; 
            });

        }


    }
}
