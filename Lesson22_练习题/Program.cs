namespace Lesson22_练习题
{

    #region 问题1
    //有一个玩家类，有姓名，血量，攻击力，防御力，闪避率等特征
    //请在控制台打印出“玩家XX，血量XX，攻击力XX，防御力XX，XX为具体内容
    class Player
    {
        public string name;
        public int hp;
        public int atk;
        public int def;
        public int dodge;
        public Player(string name, int hp, int atk, int def, int dodge)
        {
            this.name = name;
            this.hp = hp;
            this.atk = atk;
            this.def = def;
            this.dodge = dodge;

        }
        public override string ToString()
        {
            return string.Format("玩家{0},血量{1},攻击力{2},防御力{3},闪避{4}", name, hp, atk, def, dodge);
        }

    }


    #endregion

    #region 问题2

    //一个Monster类的引用对象A，Monster类有攻击力、防御力、血量、
    //技能ID等属性。我想复制一个和A对象一模一样的B对象。并且改变了B
    //的属性，A不会受到影响。请问如何实现？


    //思考：当包含类时该怎么办
    class Monster
    {

        public int Hp
        {
            get;
            set;
        }
        public int Atk
        {
            get;
            set;

        }
        public int Def
        {
            get;
            set;

        }
        public int SkillId
        {
            get;
            set;
        }

        public Monster(int atk, int def, int hp, int skillId)
        {
            Atk = atk;
            Def = def;
            Hp = hp;
            SkillId = skillId;
        }
        public Monster Clone()
        {
            return MemberwiseClone() as Monster;
        }
        public override string ToString()
        {
            return string.Format("攻击力{0},防御力{1},血量{2},技能ID{3}", Atk, Def, Hp, SkillId);
        }


    }


    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("万物之父");
            Player p = new Player("唐老师", 100, 20, 10, 20);
            Console.WriteLine(p);
            Monster m1 = new Monster(100,80,150,1);
            Monster m2 = m1.Clone();
            Console.WriteLine("克隆前");
            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine("克隆后");

            m2.Hp = 100;
            Console.WriteLine(m1);
            Console.WriteLine(m2);

        }
    }
}
