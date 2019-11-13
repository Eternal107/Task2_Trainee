
namespace task2
{
    class PopupViewModel:BaseViewModel
    {
        private string popupName;
        public PopupViewModel(string text)
        {
            Text = text;
        }

        public string Text
        {
            get
            {
                return popupName;
            }
            private set
            {
                popupName = value;
                NotyfyPropertyChanged(nameof(Text));
            }
        }
    }
}
