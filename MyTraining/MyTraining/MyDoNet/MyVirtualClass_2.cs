using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyTraining.MyDoNet
{
    class MyVirtualClass_2
    {
        public class A
        {
            public virtual void F() { Debug.WriteLine("A.F"); }
            public void F1() { Debug.WriteLine("A.F1"); }
            public virtual void F2() { Debug.WriteLine("A.F2"); }
        }
        public class B : A
        {
            public override void F() { Debug.WriteLine("B.F"); }
        }
        public class C : B
        {
            public new virtual void F() { Debug.WriteLine("C.F"); }
            public new void F1() { Debug.WriteLine("C.F1"); }
        }
        public class D : C
        {
            public override void F() { Debug.WriteLine("D.F"); }
        }

        public static void Run()
        {
            D d = new D();
            A a = new D();
            B b = new D();
            C c = new D();

            a.F();   //B.F          （2）
            b.F();   //B.F          （1）
            c.F();   //D.F  不是C.F （2）
            d.F();   //D.F          （1）

            a.F1();  //A.F1         （1）
            a.F2();  //A.F2         （3）
            c.F1();  //C.F1         （1）
            c.F2();  //A.F2
            /** 
             * 说明：
                    就 a 来说，A 是声明类，D 是实例类
                    在调用实例a的方法时，首先是在声明类A中找此方法：
                        （1）. 如果有此方法并且是非虚方法，就直接执行该方法；
                        （2）. 如果有此方法并且是虚方法，就在A的子类中找，如果在子类B中找到该方法的重写，就执行B中的重写方法；
                        （3）. 如果没有找到B中对该方法的重写，就执行A类的虚方法。注意：如果A a = new A(); 
                    如果子类中没有该方法，调用基类的方法时，执行基类的方法。
            **/
        }
    }

    [TestClass]
    public class TestMyVirtualClass_2
    {
        [TestMethod]
        public void TestRun()
        {
            MyVirtualClass_2.Run();
        }
    }
}
