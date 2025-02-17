using System.Collections.ObjectModel;
using System.Windows;

namespace ObservableCollectionExample
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        private MainWindowViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();
            viewModel = new MainWindowViewModel();
            this.DataContext = viewModel;
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(InputTextBox.Text) && InputTextBox.Text != TextBoxHelper.GetPlaceholderText(InputTextBox))
            {
                viewModel.Items.Add(InputTextBox.Text);
                InputTextBox.Clear();
            }
        }
    }
}
