
using Xamarin.Forms;


namespace task2
{
    
    public partial class PopupTime : Rg.Plugins.Popup.Pages.PopupPage
    {
        public PopupTime(string onResume)
        {

            this.BindingContext = new PopupViewModel(onResume);
            InitializeComponent();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            MessagingCenter.Send<App>((App)Application.Current, "PopupTimer");
        }

    }
}