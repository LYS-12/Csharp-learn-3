namespace Lesson4_练习题
{
    #region 问题1
    //基于成员方法练习题
    //对人类的构造函数进行重载，用人类创建若干个对象
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
        public Person( string name,float height, int age, string homeAddress)
        {
            this.name = name;
            this.height = height;
            this.age = age;
            this.homeAddress = homeAddress;
        }
    }
    #endregion

    #region 问题2
    //基于成员变量练习题
    //对班级类的构造函数进行重载，用班级类创建若干个对象

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
        public Student(string name, int number, int age, Student deskmate)
        {
            this.name = name;
            this.number = number;
            this.age = age;
            this.deskmate = deskmate;
        }
    }
    #endregion

    #region 问题3
    //写一个Ticket类，有一个距离变量（在构造对象时赋值，不能为负
    //数），有一个价格特征，有一个方法GetPrice可以读取到价格，并且根
    //据距离distance计算价格price（1元/公里）
    //0～100公里不打折
    //101~200公里大9.5折
    //201～300公里打9折
    //300公里以上打8折
    //有一个显示方法，可以显示这张票的信息。
    //例如：100公里100块钱


    class Ticket
    {
        public float distance;
        public float price;
        public  float GetPrice()
        {
            if (0<=distance && distance<101)
            {

                return price*distance;
            }
            else if (100< distance && distance < 201)
            {
                return price*distance*0.95f;

            }
            else if (200 < distance && distance < 301)
            {
                return price * distance * 0.9f;

            }
            else 
            {
                return price * distance * 0.8f;

            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("{0}公里{1}块钱", distance, GetPrice());
        }
        public Ticket(float distance)
        {
            this.distance = distance;
            price = 1;
        }

    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");




            Person p1 = new Person("唐老狮", 177.5f, 18, "成都");
            Person p2 = new Person("唐老鸭", 150.5f, 20, "上海");
            Console.WriteLine("{0}的名字是{1}，身高是{2}，年龄是{3}，家庭住址是{4}", p1.name, p1.name, p1.height, p1.age, p1.homeAddress);
            Console.WriteLine("{0}的名字是{1}，身高是{2}，年龄是{3}，家庭住址是{4}", p2.name, p2.name, p2.height, p2.age, p2.homeAddress);
            Student s1 = new Student("火山哥", 1, 22, null);
            Student s2 = new Student("小明", 2, 21, s1);
            s1.deskmate = s2;

            Console.WriteLine("{0}的名字是{1}，学号是{2}，年龄是{3}，同桌是{4}", s1.name, s1.name, s1.number, s1.age, s1.deskmate.name);
            Console.WriteLine("{0}的名字是{1}，学号是{2}，年龄是{3}，同桌是{4}", s2.name, s2.name, s2.number, s2.age, s2.deskmate.name);


            Ticket t1 = new Ticket(50);
            t1.ShowInfo();
            Ticket t2 = new Ticket(150);
            t2.ShowInfo();
        }
    }
}
