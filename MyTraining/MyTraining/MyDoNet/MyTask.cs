using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTraining.MyDoNet
{
    /**
        action委托指向的方法没有返回值
        func委托要求必须指向带返回值的方法, 
        func后面可以跟很多类型，前面的参数是参数类型，后面的是返回值类型，参数类型必须跟指定方法的参数类型对应
    **/

    class MyTask
    {
        delegate void FunDe();

        //函数 fun1
        static void fun1()
        {
            Console.WriteLine("Fun1");
        }

        //函数 fun2
        static void fun2(object s)
        {
            Console.WriteLine(s.ToString());
        }

        static void Run()
        {
            {
                //Action
                FunDe funDelegate = fun1;
                Task.Factory.StartNew(new Action(funDelegate));

                //lambda表达式
                Task.Run(() => { fun1(); });

                //匿名函数
                FunDe fun3 = delegate ()
                {
                    Console.WriteLine("Fun3");
                };
                Task.Run(() => { fun3(); });
            }

            {
                // Action<object>
                Task.Factory.StartNew(fun2, "fun2");
                Task.Run(() => { fun2("fun2"); });
            }

            Console.ReadKey();
        }
    }
}
