namespace Lesson12_练习题
{
    #region 问题1
    //写一个人类，人类中有姓名，年龄属性，有说话行为
    //战士类继承人类，有攻击行为
    class Person
    {

        public string name;
        public int age;
        public void speak()
        {
            Console.WriteLine("我叫" + name + "，今年" + age + "岁了");
        }

    }

    class Warrior : Person
    {
        public void attack()
        {
            Console.WriteLine(name + "发动了攻击");
        }
    }

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Warrior warrior = new Warrior();
            warrior.name = "张三";
            warrior.age = 20;
            warrior.speak();
            warrior.attack();
        }
    }
}
