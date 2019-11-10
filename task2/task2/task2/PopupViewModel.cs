

namespace task2
{
    class PopupViewModel:BaseViewModel
    {
        
        public PopupViewModel(string label)
        {
            Label = label;
            NotyfyPropertyChanged(nameof(Label));
           
        }

        public string Label
        {
            get;private set;
        }
    }
}
