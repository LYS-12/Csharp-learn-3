namespace Lesson15_练习题
{
    class Father
    {

    }

    class Son : Father {
    

        public void Speak()
        {
            Console.WriteLine("儿子说话了");
        }
    
    }

    internal class Program
    {
        static void Main(string[] args)
        {


            #region 问题1
            //请口头描述什么是装箱拆箱
            //装箱：把值类型转换成引用类型的过程叫装箱
            //拆箱：把引用类型转换成值类型的过程叫拆箱

            #endregion

            #region 问题2
            //请用代码描述装箱拆箱

            object o = new Son();
            if (o is Son)
            {
                (o as Son).Speak();
            }

            object o2 = 1f;
            float fl = (float)o2;

            object str = "123123";
            string s = (string)str;


            #endregion
            Console.WriteLine("装箱拆箱");

        }
    }
}
