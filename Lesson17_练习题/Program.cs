namespace Lesson17_练习题
{
    class Duck
    {
        public virtual void Speak()
        {
            Console.WriteLine("叫");
        }
    }
    class True : Duck
    {
        public override void Speak()
        {
            Console.Write("嘎嘎");
            base.Speak();
        }
        public void Atk()
        {
            Console.WriteLine("检测里氏替换原则");
        }
    }
    class Wooden : Duck
    {
        public override void Speak()
        {
            Console.Write("吱吱");
            base.Speak();
        }
    }
    class Xjiao : Duck
    {
        public override void Speak()
        {
            Console.Write("唧唧");
            base.Speak();
        }
    }

    class Employee
    {
        public virtual void Clock()
        {
            Console.WriteLine("9点打卡");
        }
    }

    class Manager : Employee
    {
        public override void Clock()
        {
            Console.WriteLine("十一点打卡");
        }
    }
    class Programmar : Employee
    {
        public override void Clock()
        {
            Console.WriteLine("不打卡");
        }
    }




    class Picture
    {
        public virtual float Area()
        {
            return 0;
           
        }
        public virtual float Length()
        {
            return 0;
        }


    }
    class Rectangle : Picture
    {
        private float w;
        private float h;
        public Rectangle(float w,float h)
        {
            this.w = w;
            this.h = h;
        }
        public override float Area()
        {
            return w*h;
        }
        public override float Length()
        {
            return 2 * (w + h);
        }
    }
    class Square : Picture
    {
        private float l;
        public Square(float l)
        {
            this.l = l;
        }
        public override float Area()
        {
            return l*l;
        }
        public override float Length()
        {
            return 4 * l;
        }
    }

    class Circle : Picture
    {
       private float r;
        public Circle(float r)
        {
            this.r = r;
        }
        public override float Area()
        {
            return (float)(3.14f * r * r);
        }
        public override float Length()
        {
            return (float)(2 * 3.14f * r);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson17_多态_vob");

            #region 问题1
            //真的鸭子嘎嘎叫，木头鸭子吱吱叫，橡皮鸭子唧唧叫



            Duck duck = new True();
            duck.Speak();
            (duck as True).Atk();
            #endregion

            #region 问题2
            //所有员工9点打卡
            //但经理十一点打卡，程序员不打卡

            Employee emp = new Employee();
            emp.Clock();
            Employee emp2 = new Manager();
            emp2.Clock();
            Employee emp3 = new Programmar();
            emp3.Clock();
            #endregion

            #region 问题3

            //创建一个图形类，有求面积和周长两个方法
            //创建矩形类，正方形类，圆形类继承图形类
            //实例化矩形、正方形、
            //圆形对象求面积和周长
            Rectangle rec = new Rectangle(1,2);
            Console.WriteLine( rec.Area());
            Console.WriteLine(rec.Length());
            Square sq = new Square(2);
            Console.WriteLine(sq.Area());
            Console.WriteLine(sq.Length());
            Circle cir = new Circle(1);
            Console.WriteLine(cir.Area());
            Console.WriteLine(cir.Length());



            #endregion

        }
    }
}
