using System.Windows;
using System.Windows.Controls;

namespace ObservableCollectionExample
{
    public static class TextBoxHelper
    {
        public static readonly DependencyProperty PlaceholderTextProperty =
            DependencyProperty.RegisterAttached("PlaceholderText",
                                              typeof(string),
                                              typeof(TextBoxHelper),
                                              new PropertyMetadata(string.Empty, OnPlaceholderTextChanged));

        public static string GetPlaceholderText(DependencyObject obj)
        {
            return (string)obj.GetValue(PlaceholderTextProperty);
        }

        public static void SetPlaceholderText(DependencyObject obj, string value)
        {
            obj.SetValue(PlaceholderTextProperty, value);
        }

        private static void OnPlaceholderTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is TextBox textBox)
            {
                textBox.GotFocus += TextBox_GotFocus;
                textBox.LostFocus += TextBox_LostFocus;
                UpdatePlaceholderText(textBox);
            }
        }

        private static void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (textBox.Text == GetPlaceholderText(textBox))
                {
                    textBox.Text = string.Empty;
                    textBox.Foreground = System.Windows.Media.Brushes.Black; // Change to your desired text color
                }
            }
        }

        private static void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                UpdatePlaceholderText(textBox);
            }
        }

        private static void UpdatePlaceholderText(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = GetPlaceholderText(textBox);
                textBox.Foreground = System.Windows.Media.Brushes.Gray; // Change to your desired placeholder color
            }
        }
    }
}