using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTraining.MyDoNet
{
    class MyAction
    {
        void printStr()
        {
            Console.WriteLine("printStr()");
        }

        void printStr(int i)
        {
            Console.WriteLine(i);
        }

        void printStr(int i,string s)
        {
            Console.WriteLine(i);
            Console.WriteLine(s);
        }

        public void mainAction()
        {
            // action后面可以通过泛型去指定action指向的方法的多个参数类型，参数的类型跟action后面声明的委托类型是对应这的
            // action委托可以指向一个无返回值、无参的方法
            // action是系统内置（预定义）的一个委托类型
            Action ac = printStr; 
            ac(); 

            // 定义了一个委托类型，这个类型可以指向一个没有返回值、有一个参数的方法.在这里方法中的参数最多可以16个
            Action<int> ac2 = printStr; 
            ac2(100);

            Action<int,string> ac3 = printStr;
            ac3(100,"s");
        }
    }
}
