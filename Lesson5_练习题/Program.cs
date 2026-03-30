namespace Lesson5_练习题
{

    #region 问题1
    //定义一个学生类，有五种属性，分别为姓名、性别、年龄、CSharp成
    //绩、Unity成绩
    //有两个方法：
    //一个打招呼：介绍自己交XX，今年几岁了。是男同学还是女同学
    //计算自己总分数和平均分并显示的方法
    //使用属性完成：年龄必须是0~150岁之间，成绩必须是0~100
    //性别只能是男或女
    //实例化两个对象并测试

    class Students
    {
        public string name;
        bool sex;
        private int age;
        private int csharpScore;
        int unityScore;
        public void SayHellow()
        {
            Console.WriteLine("自己叫{0},今年{1}了,是{2}", name, age, sex == true ? "男同学" : "女同学");
        }

        public void ShowScore()
        {
            int totalScore = csharpScore + unityScore;
            float averageScore = totalScore / 2f;
            Console.WriteLine("总分数是{0},平均分数是{1}", totalScore, averageScore);
        }
        public Students(string name)
        {
            this.name = name;
        }

        public int Age
        {
            get
            {

                return age;
            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("年龄必须是0~150岁之间");
                    age = 0;

                }
                else if (value > 150)
                {
                    Console.WriteLine("年龄必须是0~150岁之间");
                    age = 150;
                }
                else
                {
                    age = value;
                }
            }
        }
        public bool Sex
        {
            get
            {
                return sex;
            }
            set
            {
                if (value != false && value != true)
                {
                    Console.WriteLine("性别只能是男或女");
                }
                sex = value;
            }

        }
        public int CsharpScore
        {
            get
            {

                return csharpScore;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("成绩必须是0~100");
                    csharpScore = 0;
                }
                else if (value > 100)
                {
                    Console.WriteLine("成绩必须是0~100");
                    csharpScore = 100;
                }
                else
                {
                    csharpScore = value;
                }

            }


        }
        public int UnityScore
        {
            get
            {
                return unityScore;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("成绩必须是0~100");
                    unityScore = 0;
                }
                else if (value > 100)
                {
                    Console.WriteLine("成绩必须是0~100");
                    unityScore = 100;
                }
                else
                {
                    unityScore = value;
                }
            }

        }
    }
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {

            Students s1 = new Students("唐老师");
            s1.Age = 170;
            s1.Sex = true;
            s1.CsharpScore = 170;
            s1.UnityScore = 90;
            s1.SayHellow();
            s1.ShowScore();
            Students s2 = new Students("狮妹");
            s2.Age = 20;
            s2.Sex = false;
            s2.CsharpScore = 80;
            s2.UnityScore = 90;
            s2.SayHellow();
            s2.ShowScore();

        }
    }
}
