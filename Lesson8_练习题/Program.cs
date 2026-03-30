namespace Lesson8_练习题
{

    #region 问题1
    //写一个用于数学计算的静态类
    //该类中提供计算圆面积，圆周长，矩形面积，矩形周长，取一个数的绝
    //对值等方法
    #endregion
    static class MathTe
    {
        static float PI = 3.1415926f;

        /// <summary>
        /// 计算圆的面积
        /// </summary>
        /// <param name="r"></param>
        public static void Area(float r)
        {
           Console.WriteLine("圆的面积是 ：{0}" , PI * r * r);
        }
        public static void Circumference(float r)
        {

            Console.WriteLine("圆的周长是 ：{0}", 2 * PI * r);
        }
        public static void CubeArea(float l,float h)
        {

            Console.WriteLine("矩形面积是 ：{0}", l*h);
        }
        public static void CubeCircumference(float l, float h)
        {

            Console.WriteLine("矩形周长是 ：{0}", 2*(l+h));
        }
        public static void Absolute(int i)
        {

            if (i>=0)
            {
                Console.WriteLine("{0}的绝对值是{1}",i,i);
            }
            else
            {
                Console.WriteLine("{0}的绝对值是{1}", i,-i);
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("静态类和构造函数");

            MathTe.Area(5);
            MathTe.Circumference(5);
            MathTe.CubeCircumference(1, 2);
            MathTe.CubeArea(1, 2);
            MathTe.Absolute(-50);
        }
    }
}
