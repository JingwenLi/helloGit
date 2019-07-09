using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLeetCode
{
    public class MyClasses
    {
        class Shape
        {
            public virtual void Draw()
            {
                Debug.WriteLine("Performing base class drawing tasks");
            }
        }

        class Circle : Shape
        {
            public override void Draw()
            {
                Debug.WriteLine("Drawing a circle");
            }
        }
        class Rectangle : Circle
        {
            public override void Draw()
            {
                Debug.WriteLine("Drawing a rectangle");
                base.Draw();
            }
        }
        class Triangle : Shape
        {
            public override void Draw()
            {
                Debug.WriteLine("Drawing a triangle");
                base.Draw();
            }
        }


        public static void Run1()
        {
            Circle cc = new Circle();
            cc.Draw();

            Shape sc = new Circle();
            sc.Draw();
        }


        public class A
        {
            public virtual void F()
            {
                Console.WriteLine("A.F");
            }
            public void F1()
            {
                Console.WriteLine("A.F1");
            }
            public virtual void F2()
            {
                Console.WriteLine("A.F2");
            }
        }
        public class B : A
        {
            public override void F()
            {
                Console.WriteLine("B.F");
            }
        }
        public class C : B
        {
            new public virtual void F()
            {
                Console.WriteLine("C.F");
            }
            new public void F1()
            {
                Console.WriteLine("C.F1");
            }
        }
        public class D : C
        {
            public override void F()
            {
                Console.WriteLine("D.F");
            }
        }


        public static void Run2()
        {
            D d = new D();
            A a = d;
            B b = d;
            C c = d;

            a.F();   //B.F
            b.F();   //B.F
            c.F();   //D.F
            d.F();   //D.F
            a.F1();  //A.F1
            a.F2();  //A.F2
            c.F1();  //C.F1
            c.F2();  //A.F2

            /**
             * 说明：
                    就 类A 来说，其他类同：
                    A 是a 的声明类；D是实例类
                    在调用实例a的方法时，首先是在声明类A中找此方法，
                        如果有此方法并且是非虚方法，就直接执行该方法；
                        如果有此方法并且是虚方法，就在A的子类中找，如果在子类B中找到该方法的重写，就执行B中的重写方法；
                        如果没有找到B中对该方法的重写，就执行A类的虚方法。注意：如果A a = new A(); 
                        调用a的方法时，都执行A类自己的方法。
                    如果有子类new 一个方法时，就表示覆盖了基类的该方法，调用时就执行自己的new方法；
                    如果子类中没有该方法，调用基类的方法时，执行基类的方法。
            **/
            Console.ReadKey();
        }
    }
}
