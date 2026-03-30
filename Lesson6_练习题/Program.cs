namespace Lesson6_练习题
{

    #region 问题1
    //自定义一个整形数组类，该类中有一个整形数组变量
    //为它封装增删查改的方法
    class Array
    {
        int[] array;
        int capacity;//容量
        int length;//长度
        public int Length
        {
            get { return length; }
        }

        public Array()
        {
            capacity = 5;
            length = 0;
            array = new int[capacity];
        }
        //增加
        public void Add(int value)
        {
            if (length < capacity)
            {
                array[length] = value;
                length++;
            }
            else
            {
                capacity *= 2;
                //新房子
                int[] temparr = new int[capacity];
                //搬家
                for (int i = 0; i < array.Length; i++)
                {
                    temparr[i] = array[i];
                }
                array = temparr;
                array[length] = value;
                length++;
            }
        }

        //删除
        public void Remove(int value)
        {
            for (int i = 0; i < length; i++)
            {
                if (array[i] == value)
                {
                    RemoveAt(i);
                    return;
                }
            }
            Console.WriteLine("没有找到这个值");
        }
        public void RemoveAt(int index)
        {
            if (index > length - 1)
            {
                Console.WriteLine("当前数组只有{0}长,你越界了", length);
                return;
            }
            for (int i = index; i < length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            --length;
        }
        //改 查 
        public int this[int index]
        {
            get
            {
                if (index >= length || index < 0)
                {
                    return 0;
                }

                return array[index];

            }
            set
            {
                if (index >= length || index < 0)
                {
                    Console.WriteLine("当前数组只有{0}长,你越界了", length);
                }
                else
                {
                    array[index] = value;
                }


            }
        }






    }

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Array array = new Array();
            array.Add(100); array.Add(100); array.Add(100); array.Add(100); array.Add(100);
            Console.WriteLine(array[2]);
        }
    }
}
