namespace Lesson18_练习题
{
    #region 问题1
    //写一个动物抽象类，写三个子类
    //人叫，狗叫，猫叫
    abstract class Animal
    {
        public abstract void Speak();
    }

    class Human : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("人类说话");
        }
    }
    class Woof : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("狗叫");
        }
    }
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("猫叫");
        }
    }




    #endregion

    #region 问题2
    //创建一个图形类，有求面积和周长两个方法
    //创建矩形类，正方形类，圆形类继承图形类
    //实例化矩形、正方形、圆形对象求面积和周长



    public abstract class  Figure
    {
        public abstract void Area();
        public abstract void Perimeter();

    }
    class Rectangle : Figure
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public override void Area()
        {
            Console.WriteLine($"矩形面积: {Length * Width}");
        }
        public override void Perimeter()
        {
            Console.WriteLine($"矩形周长: {2 * (Length + Width)}");
        }
    }

    class Square : Figure
    {
        public double Side { get; set; }
        public override void Area()
        {
            Console.WriteLine($"正方形面积: {Side * Side}");
        }
        public override void Perimeter()
        {
            Console.WriteLine($"正方形周长: {4 * Side}");
        }
    }

    class Circle : Figure
    {
        public double Radius { get; set; }
        public override void Area()
        {
            Console.WriteLine($"圆形面积: {Math.PI * Radius * Radius}");
        }
        public override void Perimeter()
        {
            Console.WriteLine($"圆形周长: {2 * Math.PI * Radius}");
        }
    }












    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("抽象类和抽象方法");


            Rectangle rectangle = new Rectangle { Length = 5, Width = 3 };
            Square square = new Square { Side = 4 };
            Circle circle = new Circle { Radius = 2 };
            rectangle.Area();
            rectangle.Perimeter();
            square.Area();
            square.Perimeter();
            circle.Area();
            circle.Perimeter();



        }
    }
}
