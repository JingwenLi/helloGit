using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTraining.MyDoNet
{
    abstract class MyAbstractClass
    {
        //abstract修饰的方法一定不能有实现
        public abstract void fun();
    }


    class MyClass : MyAbstractClass
    {
        public override void fun()
        {
            throw new NotImplementedException();
        }
    }

    /**
     * C#中virtual和abstract的区别
     *（1） virtual修饰的方法必须有实现（哪怕是仅仅添加一对大括号)
     *      abstract修饰的方法一定不能有实现
     *（2） virtual可以被子类重写，
     *      abstract必须被子类重写，
     *（3） 如果类成员被abstract修饰，则该类前必须添加abstract，因为只有抽象类才可以有抽象方法
     *（4） 无法创建abstract类的实例，只能被继承无法实例化
     */
}
