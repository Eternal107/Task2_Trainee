

namespace task2
{
    class PopupViewModel:BaseViewModel
    {
        private string popupName;
        public PopupViewModel(string label)
        {
            Label = label;
           
           
        }

        public string Label
        {
            get { return popupName; } private set { popupName = value; NotyfyPropertyChanged(nameof(Label)); }
        }
    }
}
