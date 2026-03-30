using System.Security.Cryptography;

namespace Lesson9_练习题
{

    #region 问题1
    //为整形拓展一个求平方的方法
    //写一个玩家类，包含姓名，血量，攻击力，防御力等特征，攻击，移动，受伤等方法
    //为该玩家类拓展一个自杀的方法


 


    class Player
    {
        public  string name;
        public  int hp;
        public  int atk;
        public  int def;


        public  void Atk()
        {
            Console.WriteLine("玩家攻击了");
        }
        public  void Move()
        {
            Console.WriteLine("玩家移动了");
        }
        public  void Hurt()
        {
            Console.WriteLine("玩家受伤了");
        }


    }

    static class Tools
    {
        public static void PgFg(this int value)
        {
            Console.WriteLine("{0}的平方是{1}", value, value * value);
        }
        public static void Killyou(this Player value)
        {
            Console.WriteLine("玩家自杀了");
        }
    }


    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            i.PgFg();

            Player arr2 = new Player();
            arr2.Killyou();
        }


    }
}
