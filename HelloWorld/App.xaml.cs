using System;
using System.Windows;

namespace HelloWorld
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// Application 生命周期方法 OnStartup->OnActivated->OnDeactivated->OnExit
    /// </summary>
    public partial class App : Application
    {

        /// <summary>
        /// 启动应用程序时触发该事件
        /// </summary>
        /// <param name="args"></param>
        protected override void OnStartup(StartupEventArgs args)
        {
            //TODO 可以传递的参数有哪些？
            base.OnStartup(args);
            Console.WriteLine("1.OnStartup被触发");
        }

        /// <summary>
        /// 窗口被激活时触发该事件
        /// </summary>
        /// <param name="e"></param>
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            Console.WriteLine("2.OnActivated被触发");
        }

        /// <summary>
        /// 窗口由激活状态变为非激活状态时触发该事件
        /// </summary>
        /// <param name="e"></param>
        protected override void OnDeactivated(EventArgs e)
        {
            base.OnDeactivated(e);
            Console.WriteLine("3.OnDeactivated被触发");
        }

        /// <summary>
        /// 退出应用程序时触发该事件
        /// </summary>
        /// <param name="e"></param>
        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            Console.WriteLine("4.OnExit被触发");
        }
    }
}
