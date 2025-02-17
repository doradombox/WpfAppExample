using System.Collections.ObjectModel;

namespace ObservableCollectionExample
{
    public class MainWindowViewModel
    {
        public ObservableCollection<string> Items { get; set; }

        public MainWindowViewModel()
        {
            Items = new ObservableCollection<string> { "Item 1", "Item 2", "Item 3" };
        }
    }
}
