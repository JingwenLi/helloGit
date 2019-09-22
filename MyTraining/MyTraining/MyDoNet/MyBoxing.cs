using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyTraining.MyDoNet
{
    class MyBoxing
    {
        public static void Run()
        {
            int a = 1;
            object b = (int)a;        //装箱  创建了a的一个新的值, b是对新值的引用, 因此修改a, b不会发生变化

            a = 2;
            Debug.WriteLine(b);


            int c = (int)b;     //拆箱  同理 也是创建了一个副本
            b = 2;
            Debug.WriteLine(c);


            //装箱和拆箱会降低性能，增大操作开销，创建众多的对象，加重垃圾回收器的负担
        }
    }


    [TestClass]
    public class TestMyBoxing
    {
        [TestMethod]
        public void TestRun()
        {
            MyBoxing.Run();
        }
    }

}
