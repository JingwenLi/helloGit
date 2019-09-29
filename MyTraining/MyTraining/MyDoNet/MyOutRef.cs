using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace MyTraining.MyDoNet
{
    /// <summary>
    /// https://blog.csdn.net/u012664198/article/details/82837874
    /// </summary>


    class MyClassC
    {
        public int Val = 20;
    }

    /*  *  *  *  *  *  *  *  *  *   ref 与 out  *  *  *  *  *  *  *  *  *  *  *  *  *  
     * ref在外部必须赋值 (报错：使用了未赋值的局部变量）
     * out在外部可以不赋值, 但是到了内部就需要赋值了 (报错：使用了未赋值的out参数）
     * ref和out很相近，对于out为什么要求在方法内赋值，主要是区别于ref。
     * 引入out主要是为了开发人员明确被out标记的参数主要用于传出一个值，而不是传入并传出一个值。
     */
    class MyOutRef
    {
        public void Run()
        {
            int a = 1;
            string b = "b";
            MyClassC c = new MyClassC();
            OutMethod(out a, out b, out c);
            Debug.WriteLine("a:{0}, b:{1}, c:{2}", a, b, c.Val);   
            
            a = 1;
            b = "b";
            c = new MyClassC();
            RefMethod(ref a, ref b, ref c);
            Debug.WriteLine("a:{0}, b:{1}, c:{2}", a, b, c.Val);

            a = 1;
            b = "b";
            c = new MyClassC();
            Method(a, b, c);
            Debug.WriteLine("a:{0}, b:{1}, c:{2}", a, b, c.Val);
        }

        public void Method(int a, string b, MyClassC c)
        {
            a += 2;
            b += "bb";
            c.Val += 3;
            Debug.WriteLine("a:{0}, b:{1}, c:{2}", a, b, c.Val);
        }

        public void OutMethod(out int a, out string b, out MyClassC c)
        {
            a = 2;
            a += 2;
            b = "bb";
            c = new MyClassC();
            c.Val += 3;
            Debug.WriteLine("a:{0}, b:{1}, c:{2}", a, b, c.Val);
        }

        public void RefMethod(ref int a, ref string b, ref MyClassC c)
        {
            a += 2;
            b += "bb";
            c.Val += 3;
            Debug.WriteLine("a:{0}, b:{1}, c:{2}", a, b, c.Val);
        }
    }

    [TestClass]
    public class TestMyOutRef
    {
        [TestMethod]
        public void TestMethod()
        {
            new MyOutRef().Run();
        }
    }
}
