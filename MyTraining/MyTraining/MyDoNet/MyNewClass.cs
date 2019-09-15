using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyTraining.MyDoNet
{
    partial class MyNewClass
    {
        class A
        {
            public void Draw() { Debug.WriteLine("A"); }
        }

        class B : A
        {
            public new void Draw() { Debug.WriteLine("B"); }
        }

        /// <summary>
        /// 编译时绑定（根据声明类型调用方法）
        /// </summary>
        public static void Run()
        {
            A a = new A();
            a.Draw();   //A

            B b = new B();
            b.Draw();   //B

            A a1 = new B();
            a1.Draw();  //A
        }
    }

    [TestClass]
    public class TestMyNewClass
    {
        [TestMethod]
        public void TestRun()
        {
            MyNewClass.Run();
        }
    }
}
