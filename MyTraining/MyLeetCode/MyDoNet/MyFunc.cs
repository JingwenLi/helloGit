using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTraining.MyDoNet
{
    class MyFunc
    {
        int printInt()
        {
            return 999;
        }

        int printInt(string str)
        {
            Console.WriteLine(str);
            return 1000;
        }

        public void mainFunc()
        {
            // func中的泛型类型指定的是方法的返回值类型
            Func<int> fu = printInt;
            Console.WriteLine(fu());

            // func后面可以跟很多类型，前面的参数是参数类型，后面的是返回值类型，参数类型必须跟指定方法的参数类型对应
            Func<string, int> fu2 = printInt;
            Console.WriteLine(fu2("zhili"));

            Console.ReadKey();
        }
    }
}
