
using System;

using Xamarin.Forms;

namespace task2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
           
        }
       

        public void ToPage2(object o,EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }

        

    }
}
