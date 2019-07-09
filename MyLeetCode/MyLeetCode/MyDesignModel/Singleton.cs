using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLeetCode.MyDesignModel
{
    //非线程安全
    public class Singleton
    {

        //构造函数必须是私有的,不带任何的参数的,确保外层无法通过new进行实例化对象
        private Singleton()
        {
        }

        //静态
        private static Singleton instance = null;

        //静态
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }


    //简单线程安全
    public sealed class Singleton1
    {
        private static Singleton1 instance = null;
        private static readonly object padlock = new object();

        Singleton1() { }

        public static Singleton1 Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton1();
                    }
                    return instance;
                }
            }
        }
    }


    //双重锁定线程安全
    public sealed class Singleton2
    {
        private static Singleton2 instance = null;
        private static readonly object padlock = new object();

        Singleton2() { }

        public static Singleton2 Instance
        {
            get
            {
                //外层if判断_instance不为null时，直接返回实例，避免每次获取实例时进行锁定，节省了 性能损耗
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton2();
                        }
                    }
                }
                return instance;
            }
        }
    }

    //线程安全且不用用锁
    class HungerSingleton
    {
        private static HungerSingleton _hungerSingleton = new HungerSingleton();

        private HungerSingleton() { }

        public static HungerSingleton GetInstance()
        {
            return _hungerSingleton;
        }
    }

    public class My
    {
        public void Run()
        {
            volatile int i2;
        }
    }
}
