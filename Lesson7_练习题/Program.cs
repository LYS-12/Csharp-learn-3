namespace Lesson7_练习题
{


    #region 问题2
    //请用静态成员相关知识实现
    //一个类对象，在整个应用程序的生命周期中，有且仅会有一个该对象的
    //存在，不能在外部实例化，直接通过该类类名就能够得到唯一的对象
    class SingleObject
    {
        private static SingleObject _instance = new SingleObject();
        private SingleObject() { }
        public static SingleObject Instance
        {
            get { return _instance; }
        }
    }








    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            #region 问题1
            //请说出const和static的区别
            //相同点：都可以点出来使用
            //不同点：
            //1.const必须初始化，不能修改 static没有这个规则
            //2.const只能修饰变量、static可以修饰很多
            //3.const一定是写在访问修饰符后面的 ，static没有这个要求



            #endregion
        }
    }
}
