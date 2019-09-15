using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyTraining.MyDoNet
{
    public class MyVirtualClass_1
    {
        class A
        {
            public virtual void Draw() { Debug.WriteLine("A"); }
        }

        class B1 : A
        {
            public override void Draw() { Debug.WriteLine("B1"); }
        }

        class B2 : A
        {
            public new void Draw() { Debug.WriteLine("B2"); }
        }

        /// <summary>
        /// 运行时绑定（根据实际类型调用方法）
        /// </summary>
        public static void Run()
        {
            A a = new A();
            a.Draw();        //A

            B1 b1 = new B1();
            b1.Draw();      //B1    （1）声明类有此方法并且是非虚方法
            B2 b2 = new B2();
            b2.Draw();      //B2    （1）声明类有此方法并且是非虚方法

            A a1 = new B1(); 
            a1.Draw();      //B1    （2）声明类有此方法并且是虚方法 -> 在子类中找 -> 找到该方法的重写 -> 执行子类的方法
            A a2 = new B2();
            a2.Draw();      //A     （3）声明类有此方法并且是虚方法 -> 在子类中找 -> 没有找到该方法的重写 -> 执行声明类本身的方法


            /** 
             * 说明：
                    就 实例a 来说，假设 A 是声明类，B 是实例类
                    在调用实例a的方法时，首先是在声明类A中找此方法：
                        （1）. 如果有此方法并且是非虚方法，就直接执行该方法；
                        （2）. 如果有此方法并且是虚方法，就在A的子类中找，如果在子类B中找到该方法的重写，就执行B中的重写方法；
                        （3）. 如果没有找到B中对该方法的重写，就执行A类的虚方法。注意：如果A a = new A(); 
            **/
        }
    }

    [TestClass]
    public class TestMyVirtualClass_1
    {
        [TestMethod]
        public void TestRun()
        {
            MyVirtualClass_1.Run();
        }
    }
}
