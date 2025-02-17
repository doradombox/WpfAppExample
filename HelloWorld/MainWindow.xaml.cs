using System;
using System.Windows;

namespace HelloWorld
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // 当窗口的SourceInitialized事件触发时，执行委托中的方法
            SourceInitialized += (s, e) =>
                Console.WriteLine("1.MainWindow的SourceInitialized被执行");

            // 当窗口被激活时，执行委托中的方法
            Activated += (s, e) => Console.WriteLine("2.MainWindow的Activated被执行");

            // 当窗口加载完成时，执行委托中的方法
            Loaded += (s, e) => Console.WriteLine("3.MainWindow的Loaded被执行");

            // 当窗口的内容渲染完成时，执行委托中的方法
            ContentRendered += (s, e) => Console.WriteLine("4.MainWindow的ContentRendered被执行");

            // 当窗口失去焦点时，执行委托中的方法
            Deactivated += (s, e) => Console.WriteLine("5.MainWindow的Deactivated被执行");

            // 当窗口即将关闭时，执行委托中的方法
            Closing += (s, e) => Console.WriteLine("6.MainWindow的Closing被执行");

            // 当窗口已经关闭时，执行委托中的方法
            Closed += (s, e) => Console.WriteLine("7.MainWindow的Closed被执行");

            // 当窗口卸载时，执行委托中的方法
            Unloaded += (s, e) => Console.WriteLine("8.MainWindow的Unloaded被执行");
        }

    }
}
