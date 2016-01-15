using System;
using log4net;

namespace HQF.Tutorial.Logers.Log4net
{
    //注意下面的语句一定要加上，指定log4net使用.config文件来读取配置信息
    //如果是WinForm（假定程序为MyDemo.exe，则需要一个MyDemo.exe.config文件）
    //如果是WebForm，则从web.config中读取相关信息
    //[assembly: log4net.Config.XmlConfigurator(Watch = true)]

    internal class Program
    {
        private static void Main(string[] args)
        {
            Random random = new Random();
            for (int i = 0; i < 1; i++)
            {
                //创建日志记录组件实例  
                //ILog log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);  

                ILog log = log4net.LogManager.GetLogger(typeof (Program));
                //记录错误日志  
                //log.Error("error", new Exception("在这里发生了一个异常,Error Number:"+random.Next()));  
                //记录严重错误  
                //log.Fatal("fatal", new Exception("在发生了一个致命错误，Exception Id："+random.Next()));  
                //记录一般信息  
                //log.Info("提示：系统正在运行");  
                //记录调试信息  
                //log.Debug("调试信息：debug");  
                //记录警告信息  
                //log.Warn("警告：warn");  
            }
            Console.WriteLine("日志记录完毕。");
            Console.Read();

        }
    }
} 