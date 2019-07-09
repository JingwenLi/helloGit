using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLeetCode
{
    class MyOutRef
    {
        public void OutMethod(out int a, out string b)
        {
            //以下语句会报错：使用了未赋值的out参数
            //a += 2;

            //以下语句正常
            a = 2;
            a += 2;

            //out在外部可以不赋值, 但是到了内部就需要赋值了,不赋值无法使用,编译器会报错
            //ref和out很相近，对于out为什么要求在方法内赋值，主要是区别于ref。
            //引入out主要是为了开发人员明确被out标记的参数主要用于传出一个值，而不是传入并传出一个值。
            b = "bb";

            Debug.WriteLine("a:{0},b:{1}", a, b);   //a: 4,b: bb
        }


        public void RefMethod(ref int a, ref string b)
        {
            a += 2;
            b += "bb";

            Debug.WriteLine("a:{0},b:{1}", a, b);   //a: 3,b: bbb
        }

        public void Method(int a, string b)
        {
            a += 2;
            b += "bb";

            Debug.WriteLine("a:{0},b:{1}", a, b);  //a: 3,b: bbb
        }

        public void Run()
        {
            #region out
            //out在外部赋不赋值均可
            int a = 1;
            string b = "b";
            OutMethod(out a, out b);
            Debug.WriteLine("a:{0},b:{1}", a, b);   //a: 4,b: bb
            #endregion

            
            #region ref
            //ref在外部必须赋值
            //以下语句会报错：使用了未赋值的局部变量c/d
            //int c;
            //string d;
            //RefMethod(ref c, ref d);

            //在方法内修改引用对象在方法外生效
            a = 1;
            b = "b";
            RefMethod(ref a, ref b);
            Debug.WriteLine("a:{0},b:{1}", a, b);   //a: 3,b: bbb
            #endregion

            //在方法内修改引用对象在方法外不生效
            a = 1;
            b = "b";
            Method(a, b);
            Debug.WriteLine("a:{0},b:{1}", a, b);   //a:1,b:b
        }
    }
}
