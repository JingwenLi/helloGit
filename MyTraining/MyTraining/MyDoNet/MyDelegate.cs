using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTraining.MyDoNet
{
    //委托写法的进化史
    class MyDelegate
    {
        static void HandleDemo(object sender, EventArgs e)
        {
            Debug.WriteLine("Handle");
        }


        public void Run1()
        {
            EventHandler handler = new EventHandler(HandleDemo);
            handler(new Object(), EventArgs.Empty);
        }

        public void Run2()
        {
            EventHandler handler = HandleDemo;
            handler(new Object(), EventArgs.Empty);
        }

        public void Run3()
        {
            EventHandler handler = delegate (object sender, EventArgs e)
            {
                Debug.WriteLine("Handle");
            };
            handler(new Object(), EventArgs.Empty);
        }

        public void Run4()
        {
            //简写， 省略了参数
            EventHandler handler = delegate
            {
                Debug.WriteLine("Handle");
            };
            handler(new Object(), EventArgs.Empty);
        }
    }
}
