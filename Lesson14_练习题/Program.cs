namespace Lesson14_练习题
{

    #region 问题
    //有一个打工人基类，有工种，工作内容两个特征，一个工作方法
    //程序员、策划、美术分别继承打工人
    //请用继承中的构造函数这个知识点
    //实例化3个对象，分别是程序员、策划、美术
    class HunMan
    {

        public string job;
        public string JobConntent;
        public void workway()
        {

        }
        public HunMan()
        {
            Console.WriteLine("打工人的构造函数");
        }
    }
    class Programmer : HunMan
    {


        public Programmer() { Console.WriteLine("程序员的构造函数"); }
    }
    class Planner : HunMan { public Planner() { Console.WriteLine("策划的构造函数"); } }
    class Artist : HunMan { public Artist() { Console.WriteLine("美术的构造函数"); } }



    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Programmer programmer = new Programmer();
            Artist artist = new Artist();
            Planner planner = new Planner();



        }
    }
}
