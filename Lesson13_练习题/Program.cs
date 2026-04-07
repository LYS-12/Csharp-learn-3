namespace Lesson13_练习题
{
    #region 问题1
    // is和as的区别是什么
    // is：判断一个对象是否是指定类对象
    // 返回值：bool  是为真 不是为假

    // as：将一个对象转换为指定类对象
    // 返回值：指定类型对象
    // 成功返回指定类型对象，失败返回null
    #endregion

    #region 问题2
    class Monster { }
    class Boss : Monster
    {
        public void Skill()
        {
            Console.WriteLine("Boss技能");
        }
    }
    class Goblin : Monster
    {
        public void Atk()
        {
            Console.WriteLine("Atk技能");
        }
    }







    #endregion

    #region 问题3


    class Weapon
    {
      
    }
    class Sword : Weapon { }
    class SubmachineGun : Weapon { }
    class ShotGun : Weapon { }

    class Dagger : Weapon { }
    class Player
    {
        private Weapon NowHaveWeapon;
        public Player()
        {
            NowHaveWeapon = new Dagger();
        }

        public void PickUp(Weapon w)
        {
            NowHaveWeapon = w;
        }


    }




    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("里氏替换原则");
            Random random = new Random();
            Monster[] monsters = new Monster[10];
            for (int i = 0; i < monsters.Length; i++)
            {
                int num = random.Next(0, 2);
                if (num == 0)
                {
                    monsters[i] = new Boss();
                }
                else
                {
                    monsters[i] = new Goblin();
                }
            }
            for (int i = 0; i < monsters.Length; i++)
            {
                if (monsters[i] is Goblin)
                {
                    (monsters[i] as Goblin).Atk();
                }
                else
                {
                    (monsters[i] as Boss).Skill();
                }
            }




        }
    }
}
