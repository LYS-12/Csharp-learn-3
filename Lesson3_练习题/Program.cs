namespace Lesson3_练习题
{

    #region 问题1
    //基于成员变量练习题
    //为人类定义说话、走路、吃饭等方法
    class Person
    {
        public string name;
        public float height;
        public int age;
        public string homeAddress;
        public void Speak(string str)
        {
            Console.WriteLine("{0}说{1}", name, str);
        }
        public void Walk()
        {
            Console.WriteLine("{0}在走路", name);
        }
        public void Eat()
        {
            Console.WriteLine("{0}在吃饭", name);
        }
    }



    #endregion

    #region 问题2
    //基于成员变量练习题
    //为学生类定义学习、吃饭等方法
    class Student
    {
        public string name;
        public int number;
        public int age;
        public Student deskmate;
        public void study()
        {
            Console.WriteLine("{0}在学习", name);
        }
        public void Eat()
        {
            Console.WriteLine("{0}在吃饭", name);
        }
    }

    #endregion

    #region 问题3
    //定义一个食物类，有名称，热量等特征
    //思考如何和人类以及学生类联系起来

    class Food
    {
        public string name;
        public int calories;
        public void BeEatenBy(Person p)
        {
            Console.WriteLine("{0}被{1}吃了", name, p.name);
        }
        public void BeEatenBy(Student s)
        {
            Console.WriteLine("{0}被{1}吃了", name, s.name);
        }
    }


    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
