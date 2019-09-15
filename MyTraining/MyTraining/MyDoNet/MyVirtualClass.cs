using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyTraining.MyDoNet
{
    class MyVirtualClass
    {
        class A
        {
            public virtual void Draw() { Debug.WriteLine("A"); }
        }

        class B : A
        {
            public override void Draw() { Debug.WriteLine("B"); }
        }

        /// <summary>
        /// 运行时绑定（根据实际类型调用方法）
        /// </summary>
        public static void Run()
        {
            A a = new A();
            a.Draw();   //A

            B b = new B();
            b.Draw();   //B

            A a1 = new B();
            a1.Draw();  //B
        }
    }

    [TestClass]
    public class TestMyVirtualClass
    {
        [TestMethod]
        public void TestRun()
        {
            MyVirtualClass.Run();
        }
    }
}
