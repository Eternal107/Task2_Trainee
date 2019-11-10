

namespace task2
{
	
	public partial class Popup : Rg.Plugins.Popup.Pages.PopupPage
    {

      
        public Popup(string onResume )
        {

            this.BindingContext = new PopupViewModel(onResume);
            InitializeComponent();
        }

        


    }
}