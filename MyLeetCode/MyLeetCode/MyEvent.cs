using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLeetCode
{
    class MyEvent
    {
        /**
         * https://www.cnblogs.com/qwg123/p/4641133.html
            C#中使用事件需要的步骤：
            1.创建一个委托
            2.将创建的委托与特定事件关联
                (.Net类库中的很多事件都是已经定制好的，所以他们也就有相应的一个委托，
                在编写关联事件处理程序--也就是当有事件发生时我们要执行的方法的时候我们需要和这个委托有相同的签名)
            3.编写事件处理程序
            4.利用编写的事件处理程序生成一个委托实例
            5.把这个委托实例添加到产生事件对象的事件列表中去，这个过程又叫订阅事件

            C#中事件产生和实现的流程：
            1.定义A为产生事件的实例，a为A产生的一个事件
            2.定义B为接收事件的实例，b为处理事件的方法
            3.A由于用户(程序编写者或程序使用者)或者系统产生一个a事件(例如点击一个Button，产生一个Click事件)
            4.A通过事件列表中的委托对象将这个事件通知给B
            5.B接到一个事件通知(实际是B.b利用委托来实现事件的接收)
            6.调用B.b方法完成事件处理
        **/

        public class A
        {
            public delegate void EventHandler(object sender);
            public event EventHandler a;

            public void Run()
            {
                Console.WriteLine("Trigger an event.");
                a(this);
            }
        }

        class B
        {
            public B(A a)
            {
                a.a += new A.EventHandler(this.b);
            }
            private void b(object sender)
            {
                Console.WriteLine("Received and handled an event.");
                Console.Read();
            }
        }

        public void Run()
        {
            A a = new A();
            B b = new B(a);
            a.Run();
        }
    }
}
