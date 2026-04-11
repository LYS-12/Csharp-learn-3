namespace Lesson23_练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson23_面向对象相关_string");
            #region 问题1
            //请写出string中提供的截取和替换对应的函数名
            //截取Substring   替换Replace
            #endregion

            #region 问题2
            //请将字符串 1 | 2 | 3 | 4 | 5 | 6 | 7
            //变为      2 | 3 | 4 | 5 | 6 | 7 | 8
            //并输出
            //（使用字符串切割的方法）
            string str = " 1 | 2 | 3 | 4 | 5 | 6 | 7 ";

            Console.WriteLine("原来的字符串:"+str);

        
                str = str.Replace(" 1 | 2 | 3 | 4 | 5 | 6 | 7 ", " 2 | 3 | 4 | 5 | 6 | 7 | 8 ");
 
            


            Console.WriteLine("现在的字符串:" + str);

            string[] strings = str.Split('|');


            Console.WriteLine("输出的字符串:");
            for (int i = 0; i < strings.Length; i++)
            {
                Console.WriteLine(strings[i]);
            }
            #endregion


            #region 问题3
            //String和string、Int32和int、Int16和short、Int64和long他们的区别
            //是什么？

            //String和string是一样的，Int32和int、Int16和short、Int64和long也是一样的，他们都是C#中提供的类型别名，使用哪个都可以，习惯上我们通常使用小写的别名来表示基本类型。
            #endregion


            #region 问题4
            //string str = null;
            //str = "123";    1
            //string str2 = str;
            //str2 = "321";   1
            //str2 += "123";  1
            //请问，上面这段代码，分配了多少个新的堆空间
            //3个新的堆空间，分别是"123"、"321"和"321123"
            #endregion

            #region 问题5
            //编写一个函数，将输入的字符串反转。不要使用中间商，你必须原地修
            //改输入数组。交换过程中不使用额外空间
            //比如:输入{ 'h','e','l','l','o' } 输出
            //        { 'o','l','l','e','h' }  


            static void ReverseString(char[] s)
            {
                int left = 0;
                int right = s.Length - 1;
                while (left < right)
                {
                    // 交换左右指针所指的字符
                    char temp = s[left];
                    s[left] = s[right];
                    s[right] = temp;
                    // 移动指针
                    left++;
                    right--;
                }
            }


            string str1 = "hello";
            char[] charArray = str1.ToCharArray();
            Console.WriteLine("原字符串: " + str1);
            ReverseString(charArray);
            string reversedStr = new string(charArray);
            Console.WriteLine("反转后的字符串: " + reversedStr);

            #endregion

        }
    }
}
