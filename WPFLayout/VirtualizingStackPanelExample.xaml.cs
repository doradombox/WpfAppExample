using System.Collections.ObjectModel;
using System.Windows;

namespace WPFLayout
{
    /// <summary>
    /// VirtualizingStackPanelExample.xaml 的交互逻辑
    /// </summary>
    public partial class VirtualizingStackPanelExample : Window
    {
        public ObservableCollection<string> Items { get; set; }
        public VirtualizingStackPanelExample()
        {
            InitializeComponent();
            Items = new ObservableCollection<string>();
            for (int i = 1; i <= 10000; i++)
            {
                Items.Add($"Item {i}");
            }
            DataContext = this;
        }
    }
}
